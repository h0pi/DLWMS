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
            label1.Location = new Point(14, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // cmbStudenti
            // 
            cmbStudenti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(91, 47);
            cmbStudenti.Margin = new Padding(3, 4, 3, 4);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(238, 28);
            cmbStudenti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "Godina:";
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbGodina.Location = new Point(91, 96);
            cmbGodina.Margin = new Padding(3, 4, 3, 4);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(238, 28);
            cmbGodina.TabIndex = 1;
            cmbGodina.SelectionChangeCommitted += cmbGodina_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 148);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Stipendija:";
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(91, 144);
            cmbStipendija.Margin = new Padding(3, 4, 3, 4);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(238, 28);
            cmbStipendija.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(246, 185);
            btnSacuvaj.Margin = new Padding(3, 4, 3, 4);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(86, 31);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmStipendijaAddEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 232);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(cmbStudenti);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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