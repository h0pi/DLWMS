using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Data.IB220240;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IB220240
{
    public partial class frmDrzave : Form
    {
        private static readonly DLWMSDbContext db = Shared.DLWMSDbContext;
        List<Drzave> drzave = new List<Drzave>();
        public frmDrzave()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }


        private void frmDrzave_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            PokreniTimer();
        }

        private void PokreniTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) => lblVrijeme.Text = $"Trenutno vrijeme: {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();
        }

        private void UcitajPodatke()
        {
            drzave = db.Drzave.ToList();
            var tabela = new DataTable();
            tabela.Columns.Add("Zastava", typeof(Image));
            tabela.Columns.Add("Drzava");
            tabela.Columns.Add("BrGradova");
            tabela.Columns.Add("Status");

            for (int i = 0; i < drzave.Count; i++)
            {
                var drzava = drzave[i];
                var red = tabela.NewRow();

                red["Zastava"] = drzava.Zastava.ToImage();
                red["Drzava"] = drzava;
                red["BrGradova"] = db.Gradovi.Where(g => g.DrzavaId == drzava.Id).Count();
                red["Status"] = drzava.Status;

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            new frmNovaDrzava(null).ShowDialog();
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                new frmGradovi(drzave[e.RowIndex]).ShowDialog();
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 4)
            {
                new frmNovaDrzava(drzave[e.RowIndex]).ShowDialog();
                UcitajPodatke();
            }
        }
    }
}
