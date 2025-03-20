namespace DLWMS.WinApp.IB220240
{
    partial class frmRazmjene
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
            label1 = new Label();
            cmbUniverzitet = new ComboBox();
            label2 = new Label();
            cmbDrzava = new ComboBox();
            tbEcts = new TextBox();
            btnSacuvaj = new Button();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvPodaci = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Univerzitet:";
            // 
            // cmbUniverzitet
            // 
            cmbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUniverzitet.FormattingEnabled = true;
            cmbUniverzitet.Location = new Point(205, 27);
            cmbUniverzitet.Name = "cmbUniverzitet";
            cmbUniverzitet.Size = new Size(186, 23);
            cmbUniverzitet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Drzava:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(12, 27);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(186, 23);
            cmbDrzava.TabIndex = 1;
            // 
            // tbEcts
            // 
            tbEcts.Location = new Point(397, 27);
            tbEcts.Name = "tbEcts";
            tbEcts.Size = new Size(72, 23);
            tbEcts.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(767, 27);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(102, 23);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(475, 27);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(140, 23);
            dtpPocetak.TabIndex = 4;
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(621, 27);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(140, 23);
            dtpKraj.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 9);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 9);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 0;
            label4.Text = "Pocetak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 9);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 0;
            label5.Text = "Kraj razmjene:";
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, Obrisi });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(857, 244);
            dgvPodaci.TabIndex = 5;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "Pocetak";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.Name = "Pocetak";
            Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "Kraj";
            Kraj.HeaderText = "Kraj";
            Kraj.Name = "Kraj";
            Kraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            // 
            // Okoncana
            // 
            Okoncana.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Obrisi.HeaderText = "";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // frmRazmjene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 459);
            Controls.Add(dgvPodaci);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(btnSacuvaj);
            Controls.Add(tbEcts);
            Controls.Add(cmbDrzava);
            Controls.Add(cmbUniverzitet);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmRazmjene";
            Text = "frmRazmjene";
            Load += frmRazmjene_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbUniverzitet;
        private Label label2;
        private ComboBox cmbDrzava;
        private TextBox tbEcts;
        private Button btnSacuvaj;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn Obrisi;
    }
}