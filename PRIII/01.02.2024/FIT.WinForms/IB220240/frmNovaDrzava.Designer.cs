namespace FIT.WinForms.IB220240
{
    partial class frmNovaDrzava
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbZastava = new PictureBox();
            label2 = new Label();
            tbNaziv = new TextBox();
            cbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Zastava:";
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 32);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(418, 278);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 324);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(12, 356);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(418, 27);
            tbNaziv.TabIndex = 2;
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(12, 401);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(80, 24);
            cbAktivna.TabIndex = 3;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(311, 401);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(119, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaDrzava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivna);
            Controls.Add(tbNaziv);
            Controls.Add(pbZastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaDrzava";
            Text = "Podaci o drzavi";
            Load += frmNovaDrzava_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private Label label2;
        private TextBox tbNaziv;
        private CheckBox cbAktivna;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}