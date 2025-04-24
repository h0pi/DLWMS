namespace FIT.WinForms.IB220240
{
    partial class frmUvjerenja
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
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            btnNoviZahtjev = new Button();
            groupBox1 = new GroupBox();
            btnDodaj = new Button();
            tbBrZahtjeva = new TextBox();
            tbInfo = new TextBox();
            tbSvrha = new TextBox();
            cmbVrsta = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Printano, Brisi, Printaj });
            dgvPodaci.Location = new Point(12, 41);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(635, 195);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(526, 12);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(121, 23);
            btnNoviZahtjev.TabIndex = 1;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(tbBrZahtjeva);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbSvrha);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(534, 48);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(95, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // tbBrZahtjeva
            // 
            tbBrZahtjeva.Location = new Point(449, 49);
            tbBrZahtjeva.Name = "tbBrZahtjeva";
            tbBrZahtjeva.Size = new Size(79, 23);
            tbBrZahtjeva.TabIndex = 2;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 93);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(623, 126);
            tbInfo.TabIndex = 2;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(223, 49);
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(220, 23);
            tbSvrha.TabIndex = 2;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o polozenim ispitima", "Uvjerenje o statusu studenta" });
            cmbVrsta.Location = new Point(6, 49);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(211, 23);
            cmbVrsta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 31);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 31);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Svrha izdavanja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // frmUvjerenja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 479);
            Controls.Add(groupBox1);
            Controls.Add(btnNoviZahtjev);
            Controls.Add(dgvPodaci);
            Name = "frmUvjerenja";
            Load += frmUvjerenja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private Button btnNoviZahtjev;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private TextBox tbBrZahtjeva;
        private TextBox tbSvrha;
        private ComboBox cmbVrsta;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbInfo;
        private Label label4;
    }
}