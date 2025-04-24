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

namespace FIT.WinForms.IB220240
{
    public partial class frmPretraga : Form
    {
        private readonly DLWMSDbContext db = Shared.dLWMSDbContext;
        List<Student> studenti = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbSpol.SelectedIndex = 0;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var spol = cmbSpol.Text;
            var dtmOd = dtpOd.Value;
            var dtmDo = dtpDo.Value;
            if (spol == "Svi")
            {
                studenti = db.Studenti.Where(s => (s.DatumRodjenja > dtmOd && s.DatumRodjenja < dtmDo)).ToList();
            }
            else
            {
                studenti = db.Studenti.Where(s => (s.DatumRodjenja > dtmOd && s.DatumRodjenja < dtmDo) && s.Spol.ToLower() == spol.ToLower()).ToList();
            }

            if (studenti.Count == 0) MessageBox.Show($"U bazi nisu evidentirani studenti spola {spol} koji su rodjeni u periodu od {dtmOd} do {dtmDo}");

            var tabela = new DataTable();
            tabela.Columns.Add("Indeks");
            tabela.Columns.Add("Student");
            tabela.Columns.Add("Prosjek");
            tabela.Columns.Add("dtmRodjenja");
            tabela.Columns.Add("Aktivan");

            for (int i = 0; i < studenti.Count; i++)
            {
                var student = studenti[i];
                var red = tabela.NewRow();
                red["Indeks"] = student.Indeks;
                red["Student"] = student;
                red["Prosjek"] = db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Count() <= 0 ? "5" : db.PolozeniPredmeti.Where(p => p.StudentId == student.Id).Average(x => x.Ocjena);
                red["dtmRodjenja"] = student.DatumRodjenja;
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

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                new frmUvjerenja(studenti[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 5)
            {
                new frmStudentInfo(studenti[e.RowIndex]).ShowDialog();
            }
        }
    }
}
