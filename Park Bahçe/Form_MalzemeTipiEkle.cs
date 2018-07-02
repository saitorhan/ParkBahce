using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Park_Bahçe
{
    public partial class Form_MalzemeTipiEkle : Form
    {
        public static bool FormAcikMi = false;
        ParkBahceDataContext ctx = new ParkBahceDataContext();

        public Form_MalzemeTipiEkle()
        {
            InitializeComponent();
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            Form_Ana.FormuKapat(this);
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string malzemeTipAd = textBox_ad.Text.ToUpper();

            if (malzemeTipAd.Length > 0)
            {
                try
                {
                    ctx.ExecuteCommand("INSERT INTO MalzameTip(Ad, Aktif) values({0}, {1})", malzemeTipAd, checkBox_aktif.Checked);
                    toolStripStatusLabel_bilgi.Text = "Kayıt başarılı";
                }
                catch (Exception)
                {
                    toolStripStatusLabel_bilgi.Text = "Kayıt başarısız.";
                }
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Malzeme Tip adını giriniz.";
            }
        }

        private void Form_MalzemeTipiEkle_Load(object sender, EventArgs e)
        {
            FormAcikMi = true;
        }

        private void Form_MalzemeTipiEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcikMi = false;
        }

        private void textBox_ad_Leave(object sender, EventArgs e)
        {
            textBox_ad.Text = textBox_ad.Text.Trim();
        }
    }
}
