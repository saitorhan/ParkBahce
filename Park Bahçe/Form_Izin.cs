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
    public partial class Form_Izin : Form
    {
        public Form_Izin()
        {
            InitializeComponent();
        }

        public static bool FormAcikMi = false;
        IEnumerable<Tatiller> ResmiTatiller;
        Personel izneAyrilacakPersonel;
        int izinUzunlugu;
        DateTime ayrilmaZamani;
        DateTime DonusZamani;
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        private void Form_Izin_Load(object sender, EventArgs e)
        {
            FormAcikMi = true;
            ResmiTatiller = ctx.Tatillers.Where(t => t.Yil == null || t.Yil == DateTime.Today.Year).Select(t => t);
            dateTimePicker_ayrilmaTarih.MinDate = DateTime.Today;
        }

        private void Form_Izin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcikMi = false;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("İzin işlemi iptal edilsin mi?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (sonuc==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox_kimlikNo_TextChanged(object sender, EventArgs e)
        {
            string kimlik = textBox_kimlikNo.Text;

            if (Kontroller.KimlikNoKontrol(kimlik))
            {
                try
                {
                    izneAyrilacakPersonel = ctx.Personels.Where(p => p.Kimlik == kimlik).Select(p => p).Single();
                    if (izneAyrilacakPersonel.Ayrilma != null)
                    {
                        toolStripStatusLabel_bilgi.Text = izneAyrilacakPersonel.ToString() + " işine daha önce sonverilmiştir.";
                        return;
                    }

                    if (izneAyrilacakPersonel.Aktif == false)
                    {
                        toolStripStatusLabel_bilgi.Text = izneAyrilacakPersonel.ToString() + " şuan izindedir.";
                        return;
                    }

                    label_adSoyad.Text = izneAyrilacakPersonel.ToString();
                    label_gorevYer.Text = izneAyrilacakPersonel.Park.Ad;
                }
                catch (Exception)
                {
                    toolStripStatusLabel_bilgi.Text = "Personel bulunamadı";
                }
            }
        }

        private void textBox_izinSayisi_TextChanged(object sender, EventArgs e)
        {
            DonusZamaniHesapla();
        }

        private void dateTimePicker_ayrilmaTarih_ValueChanged(object sender, EventArgs e)
        {
            DonusZamaniHesapla();
        }

        private void DonusZamaniHesapla()
        {
            string gunSayisi = textBox_izinSayisi.Text;
            if (!Int32.TryParse(gunSayisi, out izinUzunlugu))
                return;

            izinUzunlugu = Convert.ToInt32(gunSayisi);
            ayrilmaZamani = dateTimePicker_ayrilmaTarih.Value;
            DonusZamani = new DateTime(ayrilmaZamani.Year, ayrilmaZamani.Month, ayrilmaZamani.Day);
            for (int i = 0; i < izinUzunlugu; )
            {
                DonusZamani = DonusZamani.AddDays(1);
                int TatilMi = ResmiTatiller.Count(t => t.Gun == DonusZamani.Day && t.Ay == DonusZamani.Month && (t.Yil == null || t.Yil == DonusZamani.Year));


                if (DonusZamani.DayOfWeek != DayOfWeek.Sunday && TatilMi == 0)
                {
                    i++;
                }
            }

            dateTimePicker_donus.Value = DonusZamani;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Izin izin = new Izin();

            izin.P_ID = izneAyrilacakPersonel.ID;
            izin.IzinUzunlık = izinUzunlugu;
            izin.ATarih = dateTimePicker_ayrilmaTarih.Value;
            izin.DTarih = DonusZamani;
            izin.Ucretlilik = checkBox_ucretliMi.Checked;
            izin.INeden = textBox_izinNeden.Text;

            ctx.Izins.InsertOnSubmit(izin);
            izneAyrilacakPersonel.Aktif = false;

            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "izin kaydı başarılı.";
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "İzin kaydı başarısız";
            }
        }
    }
}
