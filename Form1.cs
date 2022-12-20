using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbOtobus.Text) // Travego 8, Setra 12, Neoplan 10 Sıra Olacak
            {
                case "Travego":KoltukDoldur(8, false);
                    break;
                case "Setra":KoltukDoldur(12, true);
                    break;
                case "Neoplan":KoltukDoldur(10, false);
                    break;
              
            }
            void KoltukDoldur(int sira,bool arkaBesliMİ) // Arka sıranın 5 li olup olmadığını belirleyeceğiz
            {
                yavaslat:
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if(btn.Text=="Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat; // Koltuk dizilimindeki dağılımı düzeltiyoruz
                        }
                    }
                }
                int koltukNo = 1;
                for(int i=0; i<sira; i++) // Her sıradaki 5'erli koltukların ortasına koridor açıyoruz
                {
                    for(int j=0;j<5;j++)
                    {
                        if (arkaBesliMİ == true) // Koltuk sayısı tek sayıyla biten aracı arka sırası 5'li olarak düzenliyoruz
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                                continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
            }
        }
        Button tiklanan;

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void İSTİKAMET_Enter(object sender, EventArgs e)
        {

        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cmbOtobus.SelectedIndex==-1 || cmbNereden.SelectedIndex==-1 || cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz!"); // Kullanıcı bütün bilgileri girmeden koltuk rezerve yapılamaz.
                    return;

            }    
            KayıtFormu kf = new KayıtFormu();
            DialogResult sonuc=kf.ShowDialog();
            if(sonuc==DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}",kf.txtIsim.Text,kf.txtSoyIsim.Text);
                lvi.SubItems.Add(kf.mskdTelefon.Text);
                if(kf.rdbBay.Checked)
                {
                    lvi.SubItems.Add("BAY");
                    tiklanan.BackColor = Color.Blue; // Müşteri erkekse koltuk butonu mavi olur
                }
                if(kf.rdbBayan.Checked)
                {
                    lvi.SubItems.Add("BAYAN"); // Müşteri kadınsa koltuk butonu kırmızı olur
                    tiklanan.BackColor = Color.Red;
                }
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                listView1.Items.Add(lvi);

            }
        }
    }
}
