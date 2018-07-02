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
    public partial class Form_MalzemeTipi : Form
    {
        static public bool FormAcikMi = false;
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        public Form_MalzemeTipi()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Form_MalzemeTipiEkle ekle = new Form_MalzemeTipiEkle();
            if (Form_MalzemeTipiEkle.FormAcikMi)
            {
                foreach (Form item in this.MdiParent.MdiChildren)
                {
                    if (item.Text == ekle.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            ekle.MdiParent = this.MdiParent;
            ekle.Show();
        }

        private void Form_MalzemeTipi_Load(object sender, EventArgs e)
        {
            string[] aktiflik = { "Kullanılmıyor", "Kullanılıyor" };
            comboBox_aktiflik.DataSource = aktiflik;

            comboBox_ad.DataSource = ctx.MalzameTips.Where(m => m.Aktif == true).Select(m => m).OrderBy(m => m.Ad);
        }

        MalzameTip tip;

        private void comboBox_ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            tip = comboBox_ad.SelectedItem as MalzameTip;
            textBox1.Text = tip.ToString();

            comboBox_aktiflik.SelectedIndex = Convert.ToInt32(tip.Aktif);
        }


        private void checkBox_listelemeSecenegi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_listelemeSecenegi.Checked)
            {
                comboBox_ad.DataSource = ctx.MalzameTips.Select(m => m).OrderBy(m => m.Ad);
            }
            else
            {
                comboBox_ad.DataSource = ctx.MalzameTips.Where(m => m.Aktif == true).Select(m => m).OrderBy(m => m.Ad);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(tip + " güncellenecek. Onaylamak için Tamam butonuna tıklayınız.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (sonuc == DialogResult.OK)
            {
                try
                {
                    tip.Aktif = Convert.ToBoolean(comboBox_aktiflik.SelectedIndex);
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Güncelleme başarılı";
                    Form_MalzemeTipi_Load(null, null);
                }
                catch (Exception)
                {
                    toolStripStatusLabel_bilgi.Text = "Güncelleme başarısız";
                }
            }
        }
    }
}
