using DLWMS.Data;
using DLWMS.Infrastructure;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class frmPretraga : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> listaStudenata = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbDrzave.DataSource = db.Drzave.ToList();
            cmbSpol.DataSource = db.Spolovi.ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var drzava = cmbDrzave.SelectedItem as Drzava;
            var spol = cmbSpol.SelectedItem as Spol;
            var imePrezime = tbImePrezime.Text;

            List<Grad> gradovi = db.Gradovi.Where(x => x.Drzava == drzava).ToList();

            if (string.IsNullOrEmpty(imePrezime) || string.IsNullOrWhiteSpace(imePrezime))
            {
                listaStudenata = db.Studenti.ToList().Where(s => s.Spol == spol && gradovi.Any(g => g.Id == s.GradId)).ToList();
            }
            else
            {
                listaStudenata = db.Studenti.ToList().Where(s => s.Spol == spol && gradovi.Any(g => g.Id == s.GradId) && (s.Ime.Contains(imePrezime, StringComparison.CurrentCultureIgnoreCase) || s.Prezime.Contains(imePrezime, StringComparison.CurrentCultureIgnoreCase))).ToList();
            }

            this.Text = $"Broj prikazanih studenata: {listaStudenata.Count}";
            var tabela = new DataTable();
            tabela.Columns.Add("Student");
            tabela.Columns.Add("Drzava");
            tabela.Columns.Add("Grad");
            tabela.Columns.Add("Spol");
            tabela.Columns.Add("Aktivan");

            for (int i = 0; i < listaStudenata.Count; i++)
            {
                var student = listaStudenata[i];
                var red = tabela.NewRow();

                red["Student"] = student;
                red["Drzava"] = drzava;
                red["Grad"] = student.Grad;
                red["Spol"] = student.Spol;
                red["Aktivan"] = student.Aktivan;

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void cmbSpol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void cmbDrzave_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student = listaStudenata[e.RowIndex];
                student.Aktivan = !student.Aktivan;
                db.Studenti.Update(student);
                db.SaveChanges();
                UcitajPodatke();
            }
            if (e.ColumnIndex == 5)
            {
                new frmRazmjene(listaStudenata[e.RowIndex]).ShowDialog();
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 4)
            {
                new frmStudentEdit(listaStudenata[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
