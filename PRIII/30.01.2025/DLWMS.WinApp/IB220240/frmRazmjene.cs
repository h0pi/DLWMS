using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
        DLWMSContext db = new DLWMSContext();
        public frmRazmjene(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmRazmjene_Load(object sender, EventArgs e)
        {
            this.Text = $"Razmjene studenta {student}";
            cmbDrzava.DataSource = db.Drzave.ToList();
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbUniverzitet.DataSource = db.Univerziteti.Where(x => x.Drzava == drzava).ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            throw new NotImplementedException();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {

            }
        }

        private bool Validacija()
        {
            var dtmOd = dtpPocetak.Value;
            var dtmDo = dtpKraj.Value;
            try
            {
                int ects = int.Parse(tbEcts.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite validan broj ECTS bodova!");
                throw;
            }
            return false ;
        }
    }
}
