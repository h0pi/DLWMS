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
                    StipendijaId = stipendija.Id,
                    Iznos = int.Parse(tbIznos.Text)
                };
                db.StipendijeGodine.Add(nova);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private void UcitajPodatke()
        {
            throw new NotImplementedException();
        }

        private bool Validiraj()
        {
            int godina=int.Parse(cmbGodina.Text);
            var stipendija = cmbStipendija.SelectedItem as Stipendije;
            var lista=db.StipendijeGodine.Where(x=>x.Godina==godina&&stipendija.Id==x.StipendijaId).ToList();
            try
            {
                var km = int.Parse(tbIznos.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite validan iznos stipendije!!");
                return false ;
            }
            if (lista.Count > 0) {
                MessageBox.Show("Ova stipendija za ovu godinu je vec dodata!");
                return false; }
            return true;
        }
    }
}
