using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IB220240
{
    public partial class frmStudentInfo : Form
    {
        private Student student;
        private readonly DLWMSDbContext db = Shared.dLWMSDbContext;
        public frmStudentInfo(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            this.Text = student.Indeks;
            pbSlika.Image = student.Slika.ToImage();
            lblIme.Text = student.ToString();
            var prosjek = db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Count() <= 0 ? "5" : db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Average(x => x.Ocjena).ToString();
            lblProsjek.Text = $"Prosjek: {prosjek}";
        }
    }
}
