namespace DLWMS.WinApp.IB220240
{
    partial class frmPretraga
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
            cmbGodina = new ComboBox();
            label2 = new Label();
            cmbStipendija = new ComboBox();
            btnStipendije = new Button();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Ukloni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Godina:";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbGodina.Location = new Point(12, 27);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(121, 23);
            cmbGodina.TabIndex = 1;
            cmbGodina.SelectionChangeCommitted += cmbGodina_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Stipendija:";
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(139, 27);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(154, 23);
            cmbStipendija.TabIndex = 1;
            cmbStipendija.SelectionChangeCommitted += cmbStipendija_SelectionChangeCommitted;
            // 
            // btnStipendije
            // 
            btnStipendije.Location = new Point(820, 27);
            btnStipendije.Name = "btnStipendije";
            btnStipendije.Size = new Size(152, 23);
            btnStipendije.TabIndex = 2;
            btnStipendije.Text = "Stipendije po godinama";
            btnStipendije.UseVisualStyleBackColor = true;
            btnStipendije.Click += btnStipendije_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(701, 27);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(113, 23);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj Stipendiju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Student, Godina, Stipendija, Iznos, Ukupno, Ukloni });
            dgvPodaci.Location = new Point(12, 56);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.Size = new Size(960, 313);
            dgvPodaci.TabIndex = 3;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i prezime";
            Student.Name = "Student";
            Student.ReadOnly = true;
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
            Iznos.HeaderText = "Mjesecni iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Ukloni
            // 
            Ukloni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukloni.HeaderText = "";
            Ukloni.Name = "Ukloni";
            Ukloni.ReadOnly = true;
            Ukloni.Text = "Ukloni";
            Ukloni.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 381);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(btnStipendije);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbGodina;
        private Label label2;
        private ComboBox cmbStipendija;
        private Button btnStipendije;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn Ukloni;
    }
}