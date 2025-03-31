using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIT.Data.IB220240;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IB220240
{
    public partial class frmGradovi : Form
    {
        private Drzave drzave;
        private static DLWMSDbContext db = Shared.DLWMSDbContext;
        List<Gradovi> grads = new List<Gradovi>();
        public frmGradovi(Drzave drzave)
        {
            this.drzave = drzave;
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private void frmGradovi_Load(object sender, EventArgs e)
        {
            pbZastava.Image = drzave.Zastava.ToImage();
            lblDrzava.Text = drzave.ToString();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            grads = db.Gradovi.Where(g => g.DrzavaId == drzave.Id).ToList();
            dgvPodaci.DataSource = grads.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var novi = new Gradovi
                {
                    Naziv = tbNaziv.Text,
                    Drzava = drzave,
                    Status = true,
                };
                db.Gradovi.Add(novi);
                db.SaveChanges();
                UcitajPodatke();
            }

        }

        private bool Validiraj()
        {
            if (string.IsNullOrWhiteSpace(tbNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv grada");
                return false;
            }
            grads = db.Gradovi.Where(g => g.DrzavaId == drzave.Id).ToList();
            for (int i = 0; i < grads.Count; i++)
            {
                if (string.Compare(grads[i].ToString(), tbNaziv.Text) == 0)
                {
                    MessageBox.Show("Vec postoji grad sa ovim imenom!");
                    return false;
                }
            }
            return true;
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var grad = grads[e.RowIndex];
                grad.Status = !grad.Status;
                db.Gradovi.Update(grad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGradova;
            try
            {
                brojGradova = int.Parse(tbBrGradova.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Broj gradova nije validan");
                throw;
            }
            var status=cbStatus.Checked;
            await Task.Run(() => Generisi(brojGradova, status));
            MessageBox.Show("Uspjesno generisani gradovi", "Generisanje gotovo");
            UcitajPodatke();
        }

        private void Generisi(int brojGradova, bool status)
        {
            for (int i = 0; i < brojGradova; i++)
            {
                var naziv = $"Grad {i + 1}";
                var novi = new Gradovi
                {
                    Naziv = naziv,
                    Drzava = drzave,
                    Status = status
                };
                db.Gradovi.Add(novi);
                db.SaveChanges(true);
                Thread.Sleep(300);

                Invoke(() =>
                    {
                        tbInfo.Text += $"{DateTime.Now:dd.MM HH:mm:ss} -> dodat grad {naziv} za drzavu {drzave.Naziv}{Environment.NewLine}";
                        tbInfo.ScrollBars = ScrollBars.Vertical;
                        tbInfo.SelectionStart=tbInfo.Text.Length;
                        tbInfo.ScrollToCaret();
                    });
            }
        }
    }
}
