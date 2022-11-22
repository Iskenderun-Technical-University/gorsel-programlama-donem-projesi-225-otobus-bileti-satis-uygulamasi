namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOtobus = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.Nereye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.İSTİKAMET = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.İSTİKAMET.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(713, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs Seciniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbOtobus
            // 
            this.cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtobus.FormattingEnabled = true;
            this.cmbOtobus.Items.AddRange(new object[] {
            "Travego",
            "Neoplan",
            "Setra"});
            this.cmbOtobus.Location = new System.Drawing.Point(550, 53);
            this.cmbOtobus.Name = "cmbOtobus";
            this.cmbOtobus.Size = new System.Drawing.Size(121, 21);
            this.cmbOtobus.TabIndex = 2;
            this.cmbOtobus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Antalya",
            "Balıkesir",
            "Hatay",
            "Adana",
            "Muğla",
            "Konya",
            "Kayseri"});
            this.cmbNereden.Location = new System.Drawing.Point(73, 33);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(121, 21);
            this.cmbNereden.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nereden";
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Antalya",
            "Balıkesir",
            "Hatay",
            "Adana",
            "Muğla",
            "Konya",
            "Kayseri"});
            this.cmbNereye.Location = new System.Drawing.Point(73, 77);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(121, 21);
            this.cmbNereye.TabIndex = 6;
            // 
            // Nereye
            // 
            this.Nereye.AutoSize = true;
            this.Nereye.Location = new System.Drawing.Point(20, 85);
            this.Nereye.Name = "Nereye";
            this.Nereye.Size = new System.Drawing.Size(41, 13);
            this.Nereye.TabIndex = 5;
            this.Nereye.Text = "Nereye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(550, 211);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(121, 20);
            this.dtpTarih.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(550, 248);
            this.nudFiyat.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudFiyat.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 11;
            this.nudFiyat.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFiyat.ValueChanged += new System.EventHandler(this.nudFiyat_ValueChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(551, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // İSTİKAMET
            // 
            this.İSTİKAMET.Controls.Add(this.cmbNereden);
            this.İSTİKAMET.Controls.Add(this.label2);
            this.İSTİKAMET.Controls.Add(this.Nereye);
            this.İSTİKAMET.Controls.Add(this.cmbNereye);
            this.İSTİKAMET.Location = new System.Drawing.Point(469, 88);
            this.İSTİKAMET.Name = "İSTİKAMET";
            this.İSTİKAMET.Size = new System.Drawing.Size(210, 111);
            this.İSTİKAMET.TabIndex = 14;
            this.İSTİKAMET.TabStop = false;
            this.İSTİKAMET.Text = "İSTİKAMET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 531);
            this.Controls.Add(this.İSTİKAMET);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOtobus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.İSTİKAMET.ResumeLayout(false);
            this.İSTİKAMET.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.Label Nereye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox İSTİKAMET;
    }
}

