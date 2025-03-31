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
using FIT.Data.IB220240;
using FIT.Infrastructure;

namespace FIT.WinForms.IB220240
{
    public partial class frmPretraga : Form
    {
        private static DLWMSDbContext db = Shared.DLWMSDbContext;
        List<Student> studenti = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            var drzava = cmbDrzava.SelectedItem as Drzave;
            cmbGrad.DataSource = db.Gradovi.Where(g => g.DrzavaId == drzava.Id).ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var drzava = cmbDrzava.SelectedItem as Drzave;
            var grad = cmbGrad.SelectedItem as Gradovi;
            studenti = db.Studenti.Where(s => s.GradId == grad.Id).ToList();

            if (studenti.Count == 0) { MessageBox.Show($"U bazi nisu evidentirani studenti koji je rodjen u {grad}, {drzava}!", "Obavjest"); }

            var tabela = new DataTable();
            tabela.Columns.Add("Ime");
            tabela.Columns.Add("Prezime");
            tabela.Columns.Add("Grad");
            tabela.Columns.Add("Drzava");
            tabela.Columns.Add("Prosjek");

            for (int i = 0; i < studenti.Count; i++)
            {
                var student = studenti[i];
                var red = tabela.NewRow();

                red["Ime"] = student.Ime;
                red["Prezime"] = student.Prezime;
                red["Grad"] = student.Grad;
                red["Drzava"] = drzava;
                red["Prosjek"] = db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Average(x => x.Ocjena);

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void cmbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzave;
            cmbGrad.DataSource = db.Gradovi.Where(g => g.DrzavaId == drzava.Id).ToList();
            UcitajPodatke();
        }

        private void cmbGrad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
