using DLWMS.Data.IB220240;
using DLWMS.Infrastructure;
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
        List<StudentiStipendije> studentiStipendijes = new List<StudentiStipendije>();
        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            this.Text = "Broj prikazanih studenata: 0";
            cmbGodina.SelectedIndex = 0;
            var godina= int.Parse(cmbGodina.Text);
            cmbStipendija.DataSource = db.StipendijeGodine.Where(x=>x.Godina==godina).ToList();
        }

        private void btnStipendije_Click(object sender, EventArgs e)
        {
            new frmStipendije().ShowDialog();
        }
    }
}
