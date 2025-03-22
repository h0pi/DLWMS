using DLWMS.Data;
using DLWMS.Data.IB220240;
using DLWMS.Infrastructure;
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
    public partial class frmStipendijaAddEdit : Form
    {
        DLWMSContext db = new DLWMSContext();
        private StudentiStipendije studentiStipendije;

        public frmStipendijaAddEdit(StudentiStipendije studentiStipendije)
        {
            InitializeComponent();
            this.studentiStipendije = studentiStipendije;
        }

        private void frmStipendijaAddEdit_Load(object sender, EventArgs e)
        {
            cmbStudenti.DataSource = db.Studenti.ToList();
           
            if(studentiStipendije!=null)
            {
                cmbStudenti.SelectedIndex = studentiStipendije.StudentId-1;
                cmbStudenti.Enabled = false;
            }
                cmbGodina.SelectedIndex = 0;
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (studentiStipendije == null)
            {
                var student = cmbStudenti.SelectedItem as Student;
                var stipendija = cmbStipendija.SelectedItem as StipendijeGodine;
                List<StudentiStipendije> imali = db.StudentiStipendije.Where(x => x.StipendijeGodine == stipendija && x.Student == student).ToList();
                if (imali.Count == 0)
                {
                    var nova = new StudentiStipendije
                    {
                        Student = student,
                        StipendijeGodine = stipendija
                    };
                    db.StudentiStipendije.Add(nova);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno sacuvano!");
                    Close();
                }
            }
            else
            {
                var stipendija = cmbStipendija.SelectedItem as StipendijeGodine;
                List<StudentiStipendije> imali = db.StudentiStipendije.Where(x => x.StipendijeGodine == stipendija ).ToList();
                if (imali.Count == 0)
                {
                    studentiStipendije.StipendijeGodine = stipendija;
                    db.StudentiStipendije.Update(studentiStipendije);
                    db.SaveChanges();
                }
            }
            
        }
    }
}
