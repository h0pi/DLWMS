using DLWMS.Data;
using DLWMS.Data.IB220240;
using DLWMS.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IB220240
{
    public partial class frmRazmjene : Form
    {
        private Student student;
        private readonly DLWMSContext db = Shared.DLWMSContext;
        List<Razmjene> razmjene = new List<Razmjene>();
        public frmRazmjene(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmRazmjene_Load(object sender, EventArgs e)
        {
            this.Text = $"Razmjene studenta {student}";
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbUni.DataSource = db.Univerziteti.ToList();
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbUniverzitet.DataSource = db.Univerziteti.Where(x => x.Drzava == drzava).ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            razmjene = db.Razmjene.Where(x => x.StudentId == student.Id).ToList();
            dgvPodaci.DataSource = razmjene;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var dtmOd = dtpPocetak.Value;
            var dtmDo = dtpKraj.Value;
            var uni = cmbUniverzitet.SelectedItem as Univerziteti;
            if (Validacija())
            {
                var nova = new Razmjene
                {
                    StudentId = student.Id,
                    UniverzitetId = uni.Id,
                    ECTS = int.Parse(tbEcts.Text),
                    Pocetak = dtmOd,
                    Kraj = dtmDo,
                    Okoncana = dtmDo > DateTime.Now ? false : true
                };
                db.Razmjene.Add(nova);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool Validacija()
        {
            var dtmOd = dtpPocetak.Value;
            var dtmDo = dtpKraj.Value;
            var imaLi = db.Razmjene.Where(x => x.StudentId == student.Id && ((dtmOd >= x.Pocetak && dtmOd < x.Kraj) || (dtmDo > x.Pocetak && dtmDo <= x.Kraj) || (dtmOd <= x.Pocetak && dtmDo >= x.Kraj))).ToList();
            try
            {
                int ects = int.Parse(tbEcts.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite validan broj ECTS bodova!");
                return false;
            }
            if (dtmOd > dtmDo)
            {
                MessageBox.Show("Datum pocetka ne moze biti veci od datuma kraja razmjene!");
                return false;
            }
            if (imaLi.Count > 0)
            {
                MessageBox.Show("Razmjena u ovom periodu vec postoji!");
                return false;
            }
            return true;
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var razmjena = razmjene[e.RowIndex];
                var result = MessageBox.Show($"Da li sigurno zelite obrisati podatke o razmjeni {student}?", "Upit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.Razmjene.Remove(razmjene[e.RowIndex]);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno obrisano!");
                    UcitajPodatke();
                }
                else
                {
                    return;
                }
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var uni = cmbUni.SelectedItem as Univerziteti;
            var ects = int.Parse(tbBrKredita.Text);
            var klk = int.Parse(tbBrRazmjena.Text);

            Thread thrd = new Thread(() => GenerisiRazmjene(uni, ects, klk));
            thrd.Start();
            //UcitajPodatke();
        }

        private void GenerisiRazmjene(Univerziteti? uni, int ects, int klk)
        {
            var dtm = new DateTime(2025, 1, 1);
            for (int i = 0; i < klk; i++)
            {
                Thread.Sleep(300);
                var nova = new Razmjene
                {
                    StudentId = student.Id,
                    Univerzitet = uni,
                    Pocetak = dtm,
                    Kraj = dtm.AddDays(30 + i + 1),
                    ECTS = ects,
                    Okoncana = dtm.AddDays(30 + i + 1) < DateTime.Now ? true : false
                };
                db.Razmjene.Add(nova);
                db.SaveChanges();
                Action ac = () =>
                {
                    tbInfo.Text += $"{i + 1}. raznheba {student} na {uni} od {dtm} do {dtm.AddDays(30 + i + 1)}{Environment.NewLine}";
                };
                BeginInvoke(ac);
                BeginInvoke(UcitajPodatke);
            }
            MessageBox.Show("Dodavanje razmjena je uspjesno zavrseno!");
        }

        private void cmbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbUniverzitet.DataSource = db.Univerziteti.Where(x => x.Drzava == drzava).ToList();
        }
    }
}
