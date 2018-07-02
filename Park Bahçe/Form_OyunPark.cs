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
    public partial class Form_OyunPark : Form
    {
        public Form_OyunPark()
        {
            InitializeComponent();
        }

        public Form_OyunPark(int ID)
        {
            InitializeComponent();
            guncellenecekPark = ctx.OyunParks.Where(p => p.ID == ID).Select(p => p).Single();
            textBox_alan.Text = guncellenecekPark.Alan.ToString();
            textBox_ad.Text = guncellenecekPark.Ad;
            parkAd = guncellenecekPark.Ad;
            button_kaydet.Text = "Güncelle";
            button_sil_malzeme.Enabled = true;
        }

        OyunPark guncellenecekPark;
        static public bool formAcikMi=false;
        ParkBahceDataContext ctx=new ParkBahceDataContext();
        string parkAd;
        private void button_iptal_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show( "İşlem iptal edilecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop ) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void Form_OyunPark_Load(object sender, EventArgs e)
        {
            formAcikMi = true;
        }

        private void button_sil_malzeme_Click(object sender, EventArgs e)
        {
            int id = ctx.OyunParks.Where(p => p.Ad == parkAd).Select(p => p.ID).Single();
            Form_OyunParkMalzeme malzeme = new Form_OyunParkMalzeme(id);
            if (Form_OyunParkMalzeme.formAcikMi)
            {
                foreach (Form item in this.MdiParent.MdiChildren)
                {
                    if (item.Text == malzeme.Text)
                    {
                        item.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                malzeme.MdiParent = this.MdiParent;
                malzeme.Show();
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show( "Oyun parkı kaydını onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information ) != DialogResult.Yes )
            {
                return;
            }

            int alan;
            if( Kontroller.SayiKontrol( textBox_alan.Text ) )
            {
                alan = Convert.ToInt32( textBox_alan.Text );
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Alan bilgisi hatalı";
                return;
            }

            if( textBox_ad.Text.Trim().Length == 0 )
            {
                toolStripStatusLabel_bilgi.Text = "Ad bilgisi eksik";
                return;
            }
            parkAd = textBox_ad.Text.Trim().ToUpper();

            // Güncelleme Olacaksa
            if (button_kaydet.Text=="Güncelle")
            {
                guncellenecekPark.Ad = parkAd;
                guncellenecekPark.Alan = alan;
                ctx.SubmitChanges();
                MessageBox.Show("Güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Güncelleme olacaksa son
            try
            {
                ctx.ExecuteCommand("INSERT INTO OyunPark(Ad, Alan) VALUES({0},{1})", parkAd, alan);
                DialogResult sonuc = MessageBox.Show("Kayıt işlemi başarılı. Parka şimdi malzeme eklemek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                button_sil_malzeme.Enabled = true;
                if( sonuc == DialogResult.Yes )
                {
                    int id=ctx.OyunParks.Where(p=>p.Ad==parkAd).Select(p=>p.ID).Single();
                    Form_OyunParkMalzeme malzeme = new Form_OyunParkMalzeme(id);
                    if (Form_OyunParkMalzeme.formAcikMi)
                    {
                        foreach (Form item in this.MdiParent.MdiChildren)
                        {
                            if (item.Text==malzeme.Text)
                            {
                                item.BringToFront();
                                break;
                            }
                        }
                    }
                    else
                    {
                        malzeme.MdiParent = this.MdiParent;
                        malzeme.Show();
                    }
                }

            }
            catch( Exception )
            {
                toolStripStatusLabel_bilgi.Text = "Kayıt işlemi başarısız";
            }
        }

        private void Form_OyunPark_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi = false;
        }
    }
}
