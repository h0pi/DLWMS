namespace FIT.WinForms.IB220240
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
            cmbSpol = new ComboBox();
            label2 = new Label();
            dtpOd = new DateTimePicker();
            label3 = new Label();
            dtpDo = new DateTimePicker();
            dgvPodaci = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            dtmRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Items.AddRange(new object[] { "Svi", "Muski", "Zenski" });
            cmbSpol.Location = new Point(64, 8);
            cmbSpol.Margin = new Padding(3, 4, 3, 4);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(138, 28);
            cmbSpol.TabIndex = 1;
            cmbSpol.SelectionChangeCommitted += cmbSpol_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 12);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 0;
            label2.Text = "rodjen u periodu od";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(357, 9);
            dtpOd.Margin = new Padding(3, 4, 3, 4);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(209, 27);
            dtpOd.TabIndex = 2;
            dtpOd.Value = new DateTime(2005, 4, 2, 22, 20, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(572, 13);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(605, 8);
            dtpDo.Margin = new Padding(3, 4, 3, 4);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(216, 27);
            dtpDo.TabIndex = 2;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Indeks, Student, Prosjek, dtmRodjenja, Aktivan, Uvjerenja });
            dgvPodaci.Location = new Point(14, 47);
            dgvPodaci.Margin = new Padding(3, 4, 3, 4);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 51;
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(807, 368);
            dgvPodaci.TabIndex = 3;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // dtmRodjenja
            // 
            dtmRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtmRodjenja.DataPropertyName = "dtmRodjenja";
            dtmRodjenja.HeaderText = "Datum rodjenja";
            dtmRodjenja.MinimumWidth = 6;
            dtmRodjenja.Name = "dtmRodjenja";
            dtmRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 432);
            Controls.Add(dgvPodaci);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(cmbSpol);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPretraga";
            Text = "Pretraga studenata";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbSpol;
        private Label label2;
        private DateTimePicker dtpOd;
        private Label label3;
        private DateTimePicker dtpDo;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn dtmRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}