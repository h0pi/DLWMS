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
using FIT.WinForms.Helpers;

namespace FIT.WinForms.IB220240
{
    public partial class frmNovaDrzava : Form
    {
        private static readonly DLWMSDbContext db = Shared.DLWMSDbContext;
        private Drzave drzava;
        public frmNovaDrzava(Drzave drzava)
        {
            this.drzava = drzava;
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (drzava == null)
            {
                if (ValidiraJ())
                {
                    var nova = new Drzave
                    {
                        Naziv = tbNaziv.Text,
                        Zastava = Ekstenzije.ToByteArray(pbZastava.Image),
                        Status = cbAktivna.Checked,
                    };
                    db.Drzave.Add(nova);
                    db.SaveChanges();
                    MessageBox.Show("Uspjesno sacuvano");
                    Close();
                }
            }
            else
            {
                drzava.Naziv = tbNaziv.Text;
                drzava.Status = cbAktivna.Checked;
                drzava.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                db.Update(drzava);
                MessageBox.Show("Uspjesno sacuvano");
                Close() ;
            }
        }

        private bool ValidiraJ()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaDrzava_Load(object sender, EventArgs e)
        {
            if (drzava != null)
            {
                pbZastava.Image=drzava.Zastava.ToImage();
                tbNaziv.Text = drzava.Naziv;
                cbAktivna.Checked = drzava.Status;
            }
        }
    }
}
