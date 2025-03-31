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
    public partial class frmPretraga : Form
    {
        private readonly DLWMSContext db = Shared.DLWMSContext;
        List<StudentiStipendije> studentiStipendijes = new List<StudentiStipendije>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;

        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            this.Text = "Broj prikazanih studenata: 0";
            cmbGodina.SelectedIndex = 0;
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            var stip = cmbStipendija.SelectedItem as StipendijeGodine;
            if (stip != null)
            {
                studentiStipendijes = db.StudentiStipendije.Include(x => x.Student).Where(x => x.StipendijeGodineId == stip.Id).ToList();
            }

            var tabela = new DataTable();
            tabela.Columns.Add("Student");
            tabela.Columns.Add("Godina");
            tabela.Columns.Add("Stipendija");
            tabela.Columns.Add("Iznos");
            tabela.Columns.Add("Ukupno");

            for (int i = 0; i < studentiStipendijes.Count; i++)
            {
                var stips = studentiStipendijes[i];

                var red = tabela.NewRow();

                int mjeseci = (stips.StipendijeGodine.Godina == DateTime.Now.Year) ? DateTime.Now.Month - 1 : 12;

                red["Student"] = stips.Student;
                red["Godina"] = stips.StipendijeGodine.Godina;
                red["Stipendija"] = stips.StipendijeGodine.Stipendija;
                red["Iznos"] = stips.StipendijeGodine.Iznos;
                red["Ukupno"] = stips.StipendijeGodine.Iznos * mjeseci;

                tabela.Rows.Add(red);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = tabela;
        }

        private void btnStipendije_Click(object sender, EventArgs e)
        {
            new frmStipendije().ShowDialog();
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
        }

        private void cmbGodina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var godina = int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Include(x => x.Stipendija).Where(x => x.Godina == godina).ToList();
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            new frmStipendijaAddEdit(null).ShowDialog();
            UcitajPodatke();
        }

        private void cmbStipendija_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var result = MessageBox.Show("Da li ste sigurni da zelite ukloniti zapis o odabranoj stipendiji", "Upit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.StudentiStipendije.Remove(studentiStipendijes[e.RowIndex]);
                    db.SaveChanges();
                    MessageBox.Show("Upsjesno uklonjeno");
                    UcitajPodatke();
                }
                else { return; }
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frmStipendijaAddEdit(studentiStipendijes[e.RowIndex]).ShowDialog();
            UcitajPodatke();
        }
    }
}
