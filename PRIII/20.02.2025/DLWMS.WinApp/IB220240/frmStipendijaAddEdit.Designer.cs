namespace DLWMS.WinApp.IB220240
{
    partial class frmStipendijaAddEdit
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
            cmbStudenti = new ComboBox();
            label2 = new Label();
            cmbGodina = new ComboBox();
            label3 = new Label();
            cmbStipendija = new ComboBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudenti
            // 
            cmbStudenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(80, 35);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(209, 23);
            cmbStudenti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Godina:";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbGodina.Location = new Point(80, 72);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(209, 23);
            cmbGodina.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Stipendija:";
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(80, 108);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(209, 23);
            cmbStipendija.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(215, 139);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmStipendijaAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 174);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(cmbStudenti);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStipendijaAddEdit";
            Text = "frmStipendijaAddEdit";
            Load += frmStipendijaAddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudenti;
        private Label label2;
        private ComboBox cmbGodina;
        private Label label3;
        private ComboBox cmbStipendija;
        private Button btnSacuvaj;
    }
}