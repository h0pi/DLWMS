namespace DLWMS.WinApp.IB220240
{
    partial class frmStipendije
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
            cmbGodina = new ComboBox();
            label1 = new Label();
            cmbStipendija = new ComboBox();
            label2 = new Label();
            tbIznos = new TextBox();
            label3 = new Label();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbGodina.Location = new Point(12, 27);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(121, 23);
            cmbGodina.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Godina:";
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(140, 27);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(154, 23);
            cmbStipendija.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Stipendija:";
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(300, 27);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(124, 23);
            tbIznos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Mjesecni iznos (BAM):";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(430, 27);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivna });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(663, 244);
            dgvPodaci.TabIndex = 8;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // frmStipendije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 431);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(tbIznos);
            Controls.Add(cmbStipendija);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbGodina);
            Controls.Add(label1);
            Name = "frmStipendije";
            Text = "frmStipendije";
            Load += frmStipendije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGodina;
        private Label label1;
        private ComboBox cmbStipendija;
        private Label label2;
        private TextBox tbIznos;
        private Label label3;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivna;
    }
}