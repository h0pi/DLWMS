using DLWMS.Data.IB220240;
using DLWMS.Infrastructure;
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
        DLWMSContext db = new DLWMSContext();
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
                //if (row.Cells["Godina"].Value != null && row.Cells["Iznos"].Value != null)
                {
                    int godina = Convert.ToInt32(row.Cells["Godina"].Value);
                    decimal iznos = Convert.ToDecimal(row.Cells["Iznos"].Value);

                    // Broj prošlih mjeseci
                    int mjeseci = (godina == DateTime.Now.Year) ? DateTime.Now.Month - 1 : 12;

                    // Proizvod iznosa i mjeseci
                    row.Cells["Ukupno"].Value = iznos * mjeseci;

                    // Checkbox uvijek postavljen na true
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

        }
    }
}
