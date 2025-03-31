using DLWMS.Data;
using DLWMS.Data.IB220240;
using DLWMS.Infrastructure;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB220240
{
    public partial class frmStipendije : Form
    {
        private readonly DLWMSContext db = Shared.DLWMSContext;
        List<StipendijeGodine> stipendijeGodines = new List<StipendijeGodine> { };
        public frmStipendije()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmStipendije_Load(object sender, EventArgs e)
        {
            cmbGodina.SelectedIndex = 0;
            cmbStipendija.DataSource = db.Stipendije.ToList();
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int godina = int.Parse(cmbGodina.Text);
            var stipendija = cmbStipendija.SelectedItem as Stipendije;
            if (Validiraj())
            {
                var nova = new StipendijeGodine
                {
                    Godina = godina,
                    Stipendija = stipendija,
                    Iznos = int.Parse(tbIznos.Text)
                };
                db.StipendijeGodine.Add(nova);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private void UcitajPodatke()
        {
            stipendijeGodines = db.StipendijeGodine.ToList();
            dgvPodaci.DataSource = stipendijeGodines;
            foreach (DataGridViewRow row in dgvPodaci.Rows)
            {
                {
                    int godina = Convert.ToInt32(row.Cells["Godina"].Value);
                    decimal iznos = Convert.ToDecimal(row.Cells["Iznos"].Value);

                    int mjeseci = (godina == DateTime.Now.Year) ? DateTime.Now.Month - 1 : 12;

                    row.Cells["Ukupno"].Value = iznos * mjeseci;

                    row.Cells["Aktivna"].Value = true;
                }
            }
        }

        private bool Validiraj()
        {
            int godina = int.Parse(cmbGodina.Text);
            var stipendija = cmbStipendija.SelectedItem as Stipendije;
            var lista = db.StipendijeGodine.Where(x => x.Godina == godina && stipendija.Id == x.StipendijaId).ToList();
            try
            {
                var km = int.Parse(tbIznos.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite validan iznos stipendije!!");
                return false;
            }
            if (lista.Count > 0)
            {
                MessageBox.Show("Ova stipendija za ovu godinu je vec dodata!");
                return false;
            }
            return true;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (dgvPodaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite stipendiju iz liste!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var odabraniRed = dgvPodaci.SelectedRows[0]; // Uzimamo prvi selektovani red

            var stipendijaGodina = (StipendijeGodine)odabraniRed.DataBoundItem; // Stipendija koja je odabrana u dgv

            var studenti = db.Studenti.ToList();

            await Task.Run(() => GenerisiStipendije(studenti, stipendijaGodina));

            MessageBox.Show("Generisanje stipendija završeno!", "Info", MessageBoxButtons.OK);
        }

        private void GenerisiStipendije(List<Student> studenti, StipendijeGodine stipendijaGodina)
        {
            for (int i = 0; i < studenti.Count; ++i)
            {
                var stud = studenti[i];

                if (!PostojiStipendija(stud, stipendijaGodina))
                {
                    var novaStipendija = new StudentiStipendije
                    {
                        StudentId = stud.Id,
                        StipendijeGodineId = stipendijaGodina.Id,
                    };

                    Action ac = () =>
                    {
                        tbInfo.Text += $"{i+1}. {stipendijaGodina.Stipendija.Naziv} u iznosu od {stipendijaGodina.Iznos} dodata {stud}{Environment.NewLine}";
                        tbInfo.SelectionStart = tbInfo.Text.Length;
                        tbInfo.ScrollToCaret();
                    };
                    BeginInvoke(ac);
                    db.StudentiStipendije.Add(novaStipendija);
                    db.SaveChanges(); // Čuvanje nakon svake promjene
                }

                Thread.Sleep(300); 
            }
        }
        private bool PostojiStipendija(Student student, StipendijeGodine stipendija)
        {
            var lista = db.StudentiStipendije.Where(x => x.Student == student && stipendija.Id == x.StipendijeGodineId).ToList();
            if (lista.Count > 0)
            {
                return true;
            }
            return false;
        }

    }
}
