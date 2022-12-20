namespace Form1
{
    partial class KayıtFormu
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
            this.txtİsim = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyİsim = new System.Windows.Forms.Label();
            this.txtSoyIsim = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.mskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtİsim
            // 
            this.txtİsim.AutoSize = true;
            this.txtİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİsim.Location = new System.Drawing.Point(86, 63);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(35, 16);
            this.txtİsim.TabIndex = 0;
            this.txtİsim.Text = "İsim";
            this.txtİsim.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(164, 59);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(112, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // txtSoyİsim
            // 
            this.txtSoyİsim.AutoSize = true;
            this.txtSoyİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyİsim.Location = new System.Drawing.Point(83, 98);
            this.txtSoyİsim.Name = "txtSoyİsim";
            this.txtSoyİsim.Size = new System.Drawing.Size(62, 16);
            this.txtSoyİsim.TabIndex = 2;
            this.txtSoyİsim.Text = "Soyİsim";
            this.txtSoyİsim.Click += new System.EventHandler(this.txtSoyİsim_Click);
            // 
            // txtSoyIsim
            // 
            this.txtSoyIsim.Location = new System.Drawing.Point(164, 94);
            this.txtSoyIsim.Name = "txtSoyIsim";
            this.txtSoyIsim.Size = new System.Drawing.Size(112, 20);
            this.txtSoyIsim.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(86, 140);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(60, 16);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Text = "Telefon";
            // 
            // mskdTelefon
            // 
            this.mskdTelefon.Location = new System.Drawing.Point(164, 136);
            this.mskdTelefon.Mask = "(999) 000-0000";
            this.mskdTelefon.Name = "mskdTelefon";
            this.mskdTelefon.Size = new System.Drawing.Size(112, 20);
            this.mskdTelefon.TabIndex = 5;
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Checked = true;
            this.rdbBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbBay.Location = new System.Drawing.Point(107, 176);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(52, 20);
            this.rdbBay.TabIndex = 6;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            this.rdbBay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbBayan.Location = new System.Drawing.Point(214, 176);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(69, 20);
            this.rdbBayan.TabIndex = 7;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            this.rdbBayan.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(86, 202);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 28);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(197, 202);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(97, 28);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 293);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.rdbBayan);
            this.Controls.Add(this.rdbBay);
            this.Controls.Add(this.mskdTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyIsim);
            this.Controls.Add(this.txtSoyİsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtİsim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayıtFormu";
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtİsim;
        private System.Windows.Forms.Label txtSoyİsim;
        private System.Windows.Forms.Label txtTelefon;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtIsim;
        public System.Windows.Forms.TextBox txtSoyIsim;
        public System.Windows.Forms.MaskedTextBox mskdTelefon;
        public System.Windows.Forms.RadioButton rdbBay;
        public System.Windows.Forms.RadioButton rdbBayan;
    }
}