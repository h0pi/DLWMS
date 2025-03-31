namespace FIT.WinForms.IB220240
{
    partial class frmDrzave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPodaci = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            btnNovaDrzava = new Button();
            btnPretraga = new Button();
            lblVrijeme = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrGradova, Status, Gradovi });
            dgvPodaci.Location = new Point(12, 61);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(816, 322);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // BrGradova
            // 
            BrGradova.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrGradova.DataPropertyName = "BrGradova";
            BrGradova.HeaderText = "Broj gradova";
            BrGradova.MinimumWidth = 6;
            BrGradova.Name = "BrGradova";
            BrGradova.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivna";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gradovi.HeaderText = "";
            Gradovi.MinimumWidth = 6;
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(674, 26);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(154, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(714, 389);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(114, 29);
            btnPretraga.TabIndex = 1;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            // 
            // lblVrijeme
            // 
            lblVrijeme.AutoSize = true;
            lblVrijeme.Location = new Point(12, 421);
            lblVrijeme.Name = "lblVrijeme";
            lblVrijeme.Size = new Size(50, 20);
            lblVrijeme.TabIndex = 2;
            lblVrijeme.Text = "label1";
            // 
            // frmDrzave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(lblVrijeme);
            Controls.Add(btnPretraga);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvPodaci);
            Name = "frmDrzave";
            Text = "frmDrzave";
            Load += frmDrzave_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodaci;
        private Button btnNovaDrzava;
        private Button btnPretraga;
        private Label lblVrijeme;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Gradovi;
    }
}