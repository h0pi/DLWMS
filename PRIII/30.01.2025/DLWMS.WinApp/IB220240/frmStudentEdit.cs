using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmStudentEdit : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        public frmStudentEdit(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentEdit_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            lblStudent.Text = $"{student.Ime} {student.Prezime}";
            lblIndeks.Text = student.BrojIndeksa;
            cmbDrzava.DataSource = db.Drzave.ToList();
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbGrad.DataSource = db.Gradovi.Where(g => g.Drzava == drzava).ToList();
        }

        private void cmbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbGrad.DataSource = db.Gradovi.Where(g => g.Drzava == drzava).ToList();
        }

        private void btnZaSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            student.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
            student.Grad = cmbGrad.SelectedItem as Grad;
            db.Studenti.Update(student);
            db.SaveChanges();
            MessageBox.Show("Uspjesno sacuvano");
            Close();
        }
    }
}
