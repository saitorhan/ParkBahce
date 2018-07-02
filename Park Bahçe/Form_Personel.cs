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
    public partial class Form_Personel : Form
    {
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        static public bool FormAcik = false;
        Personel DegisecekPersonel;

        public Form_Personel()
        {
            InitializeComponent();
            KontrolleriDoldur();
        }

        public Form_Personel(Personel Degisecek, bool Guncelle)
        {
            InitializeComponent();
            DegisecekPersonel = Degisecek;
            KontrolleriDoldur();

            textBox_KimlikNo.Text = Degisecek.Kimlik;
            textBox_Ad.Text = Degisecek.Ad;
            textBox_soyad.Text = Degisecek.Soyad;
            textBox_baba.Text = Degisecek.Baba;
            textBox_anne.Text = Degisecek.Anne;
            maskedTextBox_telefon.Text = Degisecek.Telefon;
            dateTimePicker_dogumTarih.Value = Degisecek.D_Tarih;

            foreach (var item in comboBox_kan.Items)
            {
                string kan=item as string;
                if (kan == Degisecek.Kan)
                {
                    comboBox_kan.SelectedItem = item;
                    break;
                }
            }

            foreach (Sehir item in comboBox_dogumyer.Items)
            {
                if (item.ID==Degisecek.D_Yer)
                {
                    comboBox_dogumyer.SelectedItem = item;
                    break;
                }
            }

            foreach (Gorev item in comboBox_gorev.Items)
            {
                if (item.ID==Degisecek.Gorev)
                {
                    comboBox_gorev.SelectedItem = item;
                    break;
                }
            }

            foreach (Personel item in comboBox_amir.Items)
            {
                if (item.ID==Degisecek.Ust)
                {
                    comboBox_amir.SelectedItem = item;
                    break;
                }
            }

            foreach (Park item in comboBox_gorevYer.Items)
            {
                int GorevYer = Convert.ToInt32(Degisecek.G_Yer != null ? Degisecek.G_Yer : 0);
                if (item.ID==GorevYer)
                {
                    comboBox_gorevYer.SelectedItem = item;
                    break;
                }
            }

            dateTimePicker_gorevBaslama.Value = Degisecek.Giris;

            switch (Guncelle)
            {
                case true:
                    button_gorev.Text = "Güncelle";
                    break;
                case false:
                    button_gorev.Text = "Sil";
                    foreach (var item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            (item as TextBox).Enabled = false;
                        }
                        else if (item is ComboBox)
                        {
                            (item as ComboBox).Enabled = false;
                        }
                        else if (item is DateTimePicker)
                        {
                            (item as DateTimePicker).Enabled = false;
                        }
                        else if (item is MaskedTextBox)
                        {
                            (item as MaskedTextBox).Enabled = false;
                        }

                        else if (item is CheckBox)
                        {
                            (item as CheckBox).Enabled = false;
                        }
                    }
                    dateTimePicker_gorevdenAyrilma.Enabled = true;
                    break;
            }
        }
        
        private void Form_Personel_Load(object sender, EventArgs e)
        {
            FormAcik = true;
        }

        private void KontrolleriDoldur()
        {
            comboBox_dogumyer.DataSource = ctx.Sehirs.Select(s => s).OrderBy(s => s.Ad);
            comboBox_amir.DataSource = ctx.Personels.Where(p=>p.Ayrilma==null).Select(p => p).OrderBy(p => p.Ad);
            comboBox_gorev.DataSource = ctx.Gorevs.Select(g => g).OrderBy(g => g.Ad);
            comboBox_gorevYer.DataSource = ctx.Parks.Select(p => p).OrderBy(p => p.Ad);
        }

        private void Form_Personel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcik = false;
        }

        private void textBox_KimlikNo_TextChanged(object sender, EventArgs e)
        {
            if (Kontroller.KimlikNoKontrol(textBox_KimlikNo.Text))
            {
                textBox_Ad.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Kayıt işlemi iptal edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (secim==DialogResult.Yes)
            {
                this.Close();
            }
        }

        bool kimlikNo = false;
        bool Ad = false;
        bool Soyad = false;
        bool baba = false;
        bool anne = false;
        

        private void button2_Click(object sender, EventArgs e)
        {
            

            string kimlik = textBox_KimlikNo.Text;
            kimlikNo = Kontroller.KimlikNoKontrol(kimlik);

            string anneAd = textBox_anne.Text;
            anne = Kontroller.MetinKontrol(anneAd);

            string babaAd = textBox_baba.Text;
            baba = Kontroller.MetinKontrol(babaAd);

            string ad = textBox_Ad.Text;
            Ad = Kontroller.MetinKontrol(ad);

            string soyad = textBox_soyad.Text;
            Soyad = Kontroller.MetinKontrol(soyad);

            if (!kimlikNo)
            {
                toolStripStatusLabel_bilgi.Text = "Hatalı girişleri düzeltiniz";
                textBox_KimlikNo.BackColor = Color.Red;
                return;
            }

            if (!Ad)
            {
                toolStripStatusLabel_bilgi.Text = "Hatalı girişleri düzeltiniz";
                textBox_Ad.BackColor = Color.Red;
                return;
            }

            if (!Soyad)
            {
                toolStripStatusLabel_bilgi.Text = "Hatalı girişleri düzeltiniz";
                textBox_soyad.BackColor = Color.Red;
                return;
            }

            if (!baba)
            {
                toolStripStatusLabel_bilgi.Text = "Hatalı girişleri düzeltiniz";
                textBox_baba.BackColor = Color.Red;
                return;
            }

            if (!anne)
            {
                toolStripStatusLabel_bilgi.Text = "Hatalı girişleri düzeltiniz";
                textBox_anne.BackColor = Color.Red;
                return;
            }

            int dogumYer = (comboBox_dogumyer.SelectedItem as Sehir).ID;
            DateTime dogumTarih = dateTimePicker_dogumTarih.Value;
            string Kan = comboBox_kan.SelectedText;
            string Telefon = maskedTextBox_telefon.Text;
            int Amir = (comboBox_amir.SelectedItem as Personel).ID;
            int Gorev = (comboBox_gorev.SelectedItem as Gorev).ID;
            int gorevYeri = (comboBox_gorevYer.SelectedItem as Park).ID;
            DateTime giris = dateTimePicker_gorevBaslama.Value;
            bool Aktif = checkBox_aktiflik.Checked;

            switch (button_gorev.Text)
            {
                case "Kaydet":
                    try
                    {
                        int KayitDurumu = ctx.ExecuteCommand("INSERT INTO Personel(Kimlik, Ad, Soyad, Baba, Anne, D_Yer, D_Tarih, Kan, Telefon, Ust, Gorev, G_Yer, Giris, Aktif) VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})", kimlik, ad, soyad, babaAd, anneAd, dogumYer, dogumTarih, Kan, Telefon, Amir, Gorev, gorevYeri, giris, Aktif);
                        if (KayitDurumu == 1)
                        {
                            toolStripStatusLabel_bilgi.Text = "Kayıt Başarılı";
                            FormuTemizle();
                            Form_Personel_Load(null, null);
                        }
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel_bilgi.Text = "Kayıt Başarısız";
                    }
                    break;
                case "Güncelle":
                    Personel personel = ctx.Personels.Where(p => p.ID == DegisecekPersonel.ID).Select(p => p).Single();
                    personel.Kimlik = kimlik;
                    personel.Ad = ad;
                    personel.Soyad = soyad;
                    personel.Baba = babaAd;
                    personel.Anne = anneAd;
                    personel.D_Yer = (comboBox_dogumyer.SelectedItem as Sehir).ID;
                    personel.D_Tarih = dateTimePicker_dogumTarih.Value;
                    personel.Telefon = maskedTextBox_telefon.Text;
                    personel.Kan = comboBox_kan.SelectedItem.ToString();
                    personel.Ust = (comboBox_amir.SelectedItem as Personel).ID;
                    personel.Gorev = (comboBox_gorev.SelectedItem as Gorev).ID;
                    personel.G_Yer = (comboBox_gorevYer.SelectedItem as Park).ID;
                    personel.Giris = dateTimePicker_gorevBaslama.Value;
                    personel.Aktif = checkBox_aktiflik.Checked;
                    try
                    {
                        ctx.SubmitChanges();
                        toolStripStatusLabel_bilgi.Text = "Güncelleme başarılı";
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel_bilgi.Text = "Güncelleme başarısız";
                    }
                    break;

                case "Sil":

                    DialogResult sonuc = MessageBox.Show(DegisecekPersonel.ToString() + " silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (sonuc != DialogResult.Yes)
                        return;

                    try
                    {
                        Personel silinecek = ctx.Personels.Where(p => p.Kimlik == DegisecekPersonel.Kimlik).Select(p => p).Single();
                        silinecek.Ayrilma = dateTimePicker_gorevdenAyrilma.Value;
                        silinecek.Aktif = false;
                        ctx.SubmitChanges();
                        toolStripStatusLabel_bilgi.Text = "Silme başarılı";
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel_bilgi.Text = "Silme başarısız";
                    }
                    break;
                default:
                    break;
            }
            
            
        }

        private void FormuTemizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox kutu = item as TextBox;
                    kutu.Text = "";
                }
            }


        }


        private void BuyukHarfeCevir(object sender, EventArgs e)
        {
            TextBox cagiran = sender as TextBox;
            cagiran.Text = cagiran.Text.Trim().ToUpper();
        }
    }
}
