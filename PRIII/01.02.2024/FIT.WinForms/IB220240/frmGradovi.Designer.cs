namespace FIT.WinForms.IB220240
{
    partial class frmGradovi
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
            pbZastava = new PictureBox();
            lblDrzava = new Label();
            dgvPodaci = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            label1 = new Label();
            tbNaziv = new TextBox();
            btnDodaj = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            tbBrGradova = new TextBox();
            cbStatus = new CheckBox();
            btnGenerisi = new Button();
            label3 = new Label();
            tbInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(192, 103);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDrzava.Location = new Point(251, 49);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(86, 35);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromjeniStatus });
            dgvPodaci.Location = new Point(12, 194);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 29;
            dgvPodaci.Size = new Size(576, 227);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromjeniStatus.DataPropertyName = "PromjeniStatus";
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.MinimumWidth = 6;
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 3;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(206, 153);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(282, 27);
            tbNaziv.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(494, 153);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbBrGradova);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 446);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 224);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
            // 
            // tbBrGradova
            // 
            tbBrGradova.Location = new Point(104, 41);
            tbBrGradova.Name = "tbBrGradova";
            tbBrGradova.Size = new Size(68, 27);
            tbBrGradova.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(178, 44);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(76, 24);
            cbStatus.TabIndex = 2;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(272, 41);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 78);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Info:";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 101);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(564, 117);
            tbInfo.TabIndex = 1;
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 682);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(tbNaziv);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradovi";
            Text = "Podaci o gradu";
            Load += frmGradovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private DataGridView dgvPodaci;
        private Label label1;
        private TextBox tbNaziv;
        private Button btnDodaj;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromjeniStatus;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox tbBrGradova;
        private Label label2;
        private TextBox tbInfo;
        private Label label3;
    }
}