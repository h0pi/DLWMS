namespace FIT.WinForms.IB220240
{
    partial class frmNovoUvjerenje
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
            cmbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o polozenim ispitima", "Uvjerenje o statusu studenta" });
            cmbVrsta.Location = new Point(12, 29);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(199, 23);
            cmbVrsta.TabIndex = 1;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(12, 85);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(199, 179);
            tbSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(217, 29);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(388, 206);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(503, 241);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(102, 23);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 0;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 6);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 0;
            label3.Text = "Skenirana uplatnica:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 272);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmNovoUvjerenje";
            Text = "frmNovoUvjerenje";
            Load += frmNovoUvjerenje_Load;
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbVrsta;
        private TextBox tbSvrha;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}