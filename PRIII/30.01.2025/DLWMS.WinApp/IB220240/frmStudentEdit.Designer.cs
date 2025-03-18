namespace DLWMS.WinApp.IB220240
{
    partial class frmStudentEdit
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
            pbSlika = new PictureBox();
            lblStudent = new Label();
            lblIndeks = new Label();
            label3 = new Label();
            cmbDrzava = new ComboBox();
            label4 = new Label();
            cmbGrad = new ComboBox();
            btnZaSliku = new Button();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(202, 230);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 20F);
            lblStudent.Location = new Point(259, 27);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(90, 37);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "label1";
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 15F);
            lblIndeks.Location = new Point(259, 87);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(65, 28);
            lblIndeks.TabIndex = 1;
            lblIndeks.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(259, 166);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Drzava:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(315, 163);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(180, 23);
            cmbDrzava.TabIndex = 2;
            cmbDrzava.SelectionChangeCommitted += cmbDrzava_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(259, 203);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Grad:";
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(315, 200);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(180, 23);
            cmbGrad.TabIndex = 2;
            // 
            // btnZaSliku
            // 
            btnZaSliku.Location = new Point(12, 257);
            btnZaSliku.Name = "btnZaSliku";
            btnZaSliku.Size = new Size(202, 23);
            btnZaSliku.TabIndex = 3;
            btnZaSliku.Text = "Ucitaj sliku";
            btnZaSliku.UseVisualStyleBackColor = true;
            btnZaSliku.Click += btnZaSliku_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(374, 257);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(121, 23);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 292);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnZaSliku);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblIndeks);
            Controls.Add(lblStudent);
            Controls.Add(pbSlika);
            Name = "frmStudentEdit";
            Text = "Podaci o studentu";
            Load += frmStudentEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblStudent;
        private Label lblIndeks;
        private Label label3;
        private ComboBox cmbDrzava;
        private Label label4;
        private ComboBox cmbGrad;
        private Button btnZaSliku;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
    }
}