using DLWMS.Data;
using DLWMS.Data.IB220240;
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
            dgvPodaci.AutoGenerateColumns = false;
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
            dgvPodaci.DataSource = db.Razmjene.Where(x => x.StudentId == student.Id).ToList();
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
                    ECTS=int.Parse(tbEcts.Text),
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
            try
            {
                int ects = int.Parse(tbEcts.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite validan broj ECTS bodova!");
                return false;
            }
            
            return true;
        }
    }
}
