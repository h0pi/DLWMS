﻿namespace DLWMS.WinApp.IB220240
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
            groupBox1 = new GroupBox();
            tbInfo = new TextBox();
            btnGenerisi = new Button();
            btnPotvrda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            cmbGodina.Location = new Point(14, 36);
            cmbGodina.Margin = new Padding(3, 4, 3, 4);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(138, 28);
            cmbGodina.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Godina:";
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(160, 36);
            cmbStipendija.Margin = new Padding(3, 4, 3, 4);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(175, 28);
            cmbStipendija.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Stipendija:";
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(343, 36);
            tbIznos.Margin = new Padding(3, 4, 3, 4);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(141, 27);
            tbIznos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 12);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 4;
            label3.Text = "Mjesecni iznos (BAM):";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(491, 36);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(86, 31);
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
            dgvPodaci.Location = new Point(14, 75);
            dgvPodaci.Margin = new Padding(3, 4, 3, 4);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.Size = new Size(758, 325);
            dgvPodaci.TabIndex = 8;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Location = new Point(14, 453);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(758, 276);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(7, 29);
            tbInfo.Margin = new Padding(3, 4, 3, 4);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(743, 237);
            tbInfo.TabIndex = 6;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(14, 408);
            btnGenerisi.Margin = new Padding(3, 4, 3, 4);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(184, 31);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generisi stipendije >>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(674, 408);
            btnPotvrda.Margin = new Padding(3, 4, 3, 4);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(90, 31);
            btnPotvrda.TabIndex = 7;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            // 
            // frmStipendije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 745);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGenerisi);
            Controls.Add(btnDodaj);
            Controls.Add(tbIznos);
            Controls.Add(cmbStipendija);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbGodina);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStipendije";
            Text = "frmStipendije";
            Load += frmStipendije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private TextBox tbInfo;
        private Button btnGenerisi;
        private Button btnPotvrda;
    }
}