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
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dgvPodaci = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Spol:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 9);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 0;
            label2.Text = "rodjen u periodu od";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(301, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 9);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(471, 6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(143, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Location = new Point(12, 35);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowTemplate.Height = 25;
            dgvPodaci.Size = new Size(602, 276);
            dgvPodaci.TabIndex = 3;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 324);
            Controls.Add(dgvPodaci);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretraga";
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DataGridView dgvPodaci;
    }
}