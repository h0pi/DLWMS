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
    public partial class frmUvjerenja : Form
    {
        private readonly DLWMSDbContext db = Shared.dLWMSDbContext;
        List<StudentiUvjerenja> uvjerenja = new List<StudentiUvjerenja>();
        private Student student;

        public frmUvjerenja(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmUvjerenja_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            uvjerenja = db.StudentiUvjerenja.Where(x => x.StudentId == student.Id).ToList();
            this.Text = $"Broj uvjerenja -> {uvjerenja.Count}";
            dgvPodaci.DataSource = uvjerenja;
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            new frmNovoUvjerenje(student).ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var uvjerenje = (StudentiUvjerenja)dgvPodaci.Rows[e.RowIndex].DataBoundItem;
                DialogResult result = MessageBox.Show($"Da li ste sigurni da zelite obrisati {uvjerenje.Vrsta}?", "Brisanje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.StudentiUvjerenja.Remove(uvjerenje);
                    db.SaveChanges();
                }
                UcitajPodatke();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            int brUvjerenja;
            if(string.IsNullOrEmpty(tbSvrha.Text))
            {
                MessageBox.Show("Unesite svrhu uvjerenja");
                return;
            }
            string svrhaUvjerenja= tbSvrha.Text;
            string vrstaUvjerenja= cmbVrsta.Text;
            try
            {
                brUvjerenja = int.Parse(tbBrZahtjeva.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Broj uvjerenja nije validan");
                throw;
            }

            if (brUvjerenja < 1)
            {
                MessageBox.Show("Broj uvjerenja nije validan");
                return;
            }
            await Task.Run(() => DodajUvjerenja(brUvjerenja,vrstaUvjerenja, svrhaUvjerenja));
            MessageBox.Show("Uvjerenja uspjesno dodata");
            UcitajPodatke();
        }

        private void DodajUvjerenja(int brUvjerenja,string vrstaUvjerenja, string svrhaUvjerenja)
        {
            for (int i = 0; i < brUvjerenja; i++)
            {
                var novo = new StudentiUvjerenja
                {
                    Svrha = svrhaUvjerenja,
                    Vrsta = vrstaUvjerenja,
                    Uplatnica = db.StudentiUvjerenja.Select(x => x.Uplatnica).FirstOrDefault(),
                    Datum = DateTime.Now,
                    StudentId = student.Id,
                };
                db.StudentiUvjerenja.Add(novo);
                db.SaveChanges();

                Invoke(() =>
                {
                    tbInfo.Text += $"{DateTime.Now.ToString("hh:mm:ss")} -> {vrstaUvjerenja} {student} u svrhu {svrhaUvjerenja}{Environment.NewLine}";
                }
                );
                Thread.Sleep(300);
            }
        }
    }
}
