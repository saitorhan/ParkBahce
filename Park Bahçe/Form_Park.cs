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
    public partial class Form_Park : Form
    {
        static public bool FormAcikMi = false;
        Park eklenecekPark;
        ParkBahceDataContext ctx = new ParkBahceDataContext();

        public enum AcilmaTipi
        {
            Guncelle,
            Sil
        }

        public Form_Park()
        {
            InitializeComponent();
        }

        public Form_Park(int ParkID, Form_Park.AcilmaTipi AcilmaAmaci)
        {
            InitializeComponent();
            eklenecekPark = ctx.Parks.Where(p => p.ID == ParkID).Select(p => p).Single();
            textBox_Ad.Text = eklenecekPark.Ad;
            textBox_cimAlan.Text = eklenecekPark.Cim.ToString();
            textBox_igneAgac.Text = eklenecekPark.IgneAgac.ToString();
            textBox_genisAgac.Text = eklenecekPark.GenisAgac.ToString();
            textBox_yuruyus.Text = eklenecekPark.YuruyusPark.ToString();
            checkBox_WC.Checked = eklenecekPark.WC;
            checkBox_Mescid.Checked = eklenecekPark.Mescid;
            textBox_piknik.Text = eklenecekPark.PiknikAlan.ToString();
            textBox_bisiklet.Text = eklenecekPark.BisikletYol.ToString();
            textBox_cesmeAdet.Text = eklenecekPark.CesmeAdet.ToString();
            dateTimePicker_AcilisTarih.Value = eklenecekPark.AcilisTarih;

            switch (AcilmaAmaci)
            {
                case AcilmaTipi.Guncelle:
                    button_kaydet.Text = "Güncelle";
                    break;
                case AcilmaTipi.Sil:
                    button_kaydet.Text = "Sil";
                    panel_bilgiler.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("İptal işlemini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_Park_Load(object sender, EventArgs e)
        {
            FormAcikMi = true;
        }

        private void Form_Park_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcikMi = false;
        }

        private void textBox_Ad_Leave(object sender, EventArgs e)
        {
            textBox_Ad.Text = textBox_Ad.Text.Trim().ToUpper();
            if (textBox_Ad.Text.Length==0)
            {
                textBox_Ad.BackColor = Color.Red;
            }
            else
            {
                textBox_Ad.BackColor = Color.White;
            }
        }

        private void textBox_cimAlan_Leave(object sender, EventArgs e)
        {
            TextBox send = sender as TextBox;
            send.Text = send.Text.Trim();

            if (send.Text=="")
            {
                send.Text = "0";
            }

            if (Kontroller.SayiKontrol(send.Text))
            {
                send.BackColor = Color.White;
            }
            else
            {
                send.BackColor = Color.Red;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            string ParkAdi = textBox_Ad.Text;
            if (ParkAdi.Length == 0)
            {
                textBox_Ad.BackColor = Color.Red;
            }
            else
            {
                textBox_Ad.BackColor = Color.White;
                sayi++;
            }
            

            string textDegerler = textBox_cimAlan.Text.Trim();
            int cimalan = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                cimalan = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_igneAgac.Text;
            int igneAgac = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                igneAgac = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_genisAgac.Text;
            int genisAgac = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                genisAgac = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_yuruyus.Text;
            int yuruyus = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                yuruyus = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_piknik.Text;
            int piknik = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                piknik = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_bisiklet.Text;
            int bisiklet = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                bisiklet = Convert.ToInt32(textDegerler);
                sayi++;
            }

            textDegerler = textBox_cesmeAdet.Text;
            int cesme = 0;
            if (Kontroller.SayiKontrol(textDegerler))
            {
                cesme = Convert.ToInt32(textDegerler);
                sayi++;
            }

            if (sayi != 8)
            {
                toolStripStatusLabel_bilgi.Text = "Form üzerinde işaretli alanları kontrol ediniz.";
                return;
            }

            switch (button_kaydet.Text)
            {
                case "Kaydet":
                    eklenecekPark = new Park();
                    eklenecekPark.Ad = ParkAdi;
                    eklenecekPark.Cim = cimalan;
                    eklenecekPark.IgneAgac = igneAgac;
                    eklenecekPark.GenisAgac = genisAgac;
                    eklenecekPark.YuruyusPark = yuruyus;
                    eklenecekPark.WC = checkBox_WC.Checked;
                    eklenecekPark.Mescid = checkBox_Mescid.Checked;
                    eklenecekPark.PiknikAlan = piknik;
                    eklenecekPark.BisikletYol = bisiklet;
                    eklenecekPark.CesmeAdet = cesme;
                    eklenecekPark.AcilisTarih = dateTimePicker_AcilisTarih.Value;
                    ctx.Parks.InsertOnSubmit(eklenecekPark);
                    break;

                case "Güncelle":
                    eklenecekPark.Ad = ParkAdi;
                    eklenecekPark.Cim = cimalan;
                    eklenecekPark.IgneAgac = igneAgac;
                    eklenecekPark.GenisAgac = genisAgac;
                    eklenecekPark.YuruyusPark = yuruyus;
                    eklenecekPark.WC = checkBox_WC.Checked;
                    eklenecekPark.Mescid = checkBox_Mescid.Checked;
                    eklenecekPark.PiknikAlan = piknik;
                    eklenecekPark.BisikletYol = bisiklet;
                    eklenecekPark.CesmeAdet = cesme;
                    eklenecekPark.AcilisTarih = dateTimePicker_AcilisTarih.Value;
                    break;
                case "Sil":
                    ctx.Parks.DeleteOnSubmit(eklenecekPark);
                    break;
                default:
                    break;
            }

            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = button_kaydet.Text + "me başarılı";
                
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = button_kaydet.Text + "me başarısız";
            }
        }

        private void textBox_cimAlan_Enter(object sender, EventArgs e)
        {
            TextBox send = sender as TextBox;

            if (send.Text == "0")
            {
                send.Text = "";
            }
        }


    }
}
