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
        private readonly DLWMSContext db = Shared.DLWMSContext;
        private StudentiStipendije studentiStipendije;

        public frmStipendijaAddEdit(StudentiStipendije studentiStipendije)
        {
            InitializeComponent();
            this.studentiStipendije = studentiStipendije;
        }

        private void frmStipendijaAddEdit_Load(object sender, EventArgs e)
        {
            cmbStudenti.DataSource = db.Studenti.ToList();

            if (studentiStipendije != null)
            {
                cmbStudenti.SelectedIndex = studentiStipendije.StudentId - 1;
                cmbStudenti.Enabled = false;
            }
            cmbGodina.SelectedIndex = 0;
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (Validiraj())
            {
                var student = cmbStudenti.SelectedItem as Student;
                var stipendija = cmbStipendija.SelectedItem as StipendijeGodine;
                if (studentiStipendije != null)
                {
                    studentiStipendije.StipendijeGodine = stipendija;
                    db.StudentiStipendije.Update(studentiStipendije);
                    MessageBox.Show("Uspjesno Update-ovano!");

                }
                else
                {
                    var nova = new StudentiStipendije
                    {
                        StipendijeGodine = stipendija,
                        Student = student
                    };
                    db.StudentiStipendije.Add(nova);
                    MessageBox.Show("Uspjesno dodano!");
                }
                db.SaveChanges();
                Close();
            }

        }

        private bool Validiraj()
        {
            var student = cmbStudenti.SelectedItem as Student;
            var stipendija = cmbStipendija.SelectedItem as StipendijeGodine;
            var lista = db.StudentiStipendije.Where(x => x.StipendijeGodine == stipendija && x.Student == student).ToList();
            if (lista.Count > 0)
            {
                MessageBox.Show($"{student} vec ima {stipendija.Stipendija} stipendiju!");
                return false;
            }
            return true;
        }

        private void cmbGodina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
        }
    }
}
