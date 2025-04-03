using FIT.Data;
using FIT.Data.IB220240;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220240
{
    public partial class frmNovoUvjerenje : Form
    {
        private readonly DLWMSDbContext db = Shared.dLWMSDbContext;
        private Student student;


        public frmNovoUvjerenje(Student student)
        {
            InitializeComponent();
            cmbVrsta.SelectedIndex = 0;
            this.student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var novo = new StudentiUvjerenja
                {
                    Svrha = tbSvrha.Text,
                    Vrsta = cmbVrsta.Text,
                    Uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Datum = DateTime.Now,
                    StudentId = student.Id,
                };
                db.StudentiUvjerenja.Add(novo);
                db.SaveChanges();
                MessageBox.Show("Upsjesno sacuvano");
                Close();
            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue) && Helpers.Validator.ProvjeriUnos(pbUplatnica, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovoUvjerenje_Load(object sender, EventArgs e)
        {

        }
    }
}
