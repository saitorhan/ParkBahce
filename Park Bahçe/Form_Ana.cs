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
    public partial class Form_Ana : Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        void FormuOneGetir(Form OneGetirilecek)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == OneGetirilecek.Text)
                {
                    item.BringToFront();
                }
            }
        }

        void FormAc(Form AcilacakForm)
        {
            AcilacakForm.MdiParent = this;
            AcilacakForm.Show();
        }

        static public void FormuKapat(Form kapatilacak)
        {
            DialogResult sonuc = MessageBox.Show("İşlem iptal edilecek onaylamak için Tamam butonuna tıklayiniz.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.OK)
            {
                kapatilacak.Close();
            }
        }

        static public DialogResult SilmeOnayiAl(string SilinecekEleman)
        {
            return MessageBox.Show(SilinecekEleman + " silinecek, onaylamak için Evet butununu tıklayınız.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Personel personel = new Form_Personel();

            if (Form_Personel.FormAcik)
            {
                FormuOneGetir(personel);
            }

            else
            {
                personel.MdiParent = this;
                personel.Show();
            }
        }

        private void personelGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PersonelGuncelle guncelle = new Form_PersonelGuncelle();
            if (Form_PersonelGuncelle.FormAcikMi)
            {
                FormuOneGetir(guncelle);
                return;
            }

            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PersonelGuncelle guncelle = new Form_PersonelGuncelle(true);
            if (Form_PersonelGuncelle.FormAcikMi)
            {
                FormuOneGetir(guncelle);
                return;
            }

            guncelle.MdiParent = this;
            guncelle.Show();
        }

        private void personelIzinIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Izin izin = new Form_Izin();

            if (Form_Izin.FormAcikMi)
            {
                FormuOneGetir(izin);
                return;
            }

            izin.MdiParent = this;
            izin.Show();
        }

        private void Form_Ana_Load(object sender, EventArgs e)
        {
            if (!YilinTatilleriniSorgula())
            {
                DialogResult secim = MessageBox.Show("Bu yıla ait tatiller kaydedilmemiş, bu durum izin işlemlerinin hatalı hesaplanmasına sebep olacaktır. Programı kullanmaya devam etmek için lütfen tatilleri kaydediniz. Kaydetmek için Tamam butonuna tıklayınız.", "Önemli Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (secim == DialogResult.OK)
                {
                    Form_TatillerKayit tatil = new Form_TatillerKayit();
                    tatil.MdiParent = this;
                    tatil.Show();
                }
                else
                {
                    MessageBox.Show("Programı kullanmaya devam etmek için tatillerin kaydedilmesi gerekmektedir.", "Uyarı");
                    this.Close();
                }
            }

        }

        private bool YilinTatilleriniSorgula()
        {
            ParkBahceDataContext ctx = new ParkBahceDataContext();
            int TatilSayisi = ctx.Tatillers.Count(t => t.Yil == DateTime.Today.Year);
            return TatilSayisi != 0;
        }

        private void parkEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Park park = new Form_Park();

            if (Form_Park.FormAcikMi)
            {
                FormuOneGetir(park);
                return;
            }

            park.MdiParent = this;
            park.Show();
        }

        static public int ParkID;
        private void parkGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GuncellecekParkSecme park = new Form_GuncellecekParkSecme(Form_Park.AcilmaTipi.Guncelle);
            DialogResult sonuc = park.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                Form_Park park_ = new Form_Park(ParkID, Form_Park.AcilmaTipi.Guncelle);
                park_.MdiParent = this;
                park_.Show();
            }
        }

        private void parkSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GuncellecekParkSecme park = new Form_GuncellecekParkSecme(Form_Park.AcilmaTipi.Sil);
            DialogResult sonuc = park.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                Form_Park park_ = new Form_Park(ParkID, Form_Park.AcilmaTipi.Sil);
                park_.MdiParent = this;
                park_.Show();
            }
        }

        private void malzemeTipiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MalzemeTipiEkle ekle = new Form_MalzemeTipiEkle();
            if (Form_MalzemeTipiEkle.FormAcikMi)
            {
                FormuOneGetir(ekle);
            }
            else
            {
                FormAc(ekle);
            }
        }

        private void malzemeTipislemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_MalzemeTipi tip = new Form_MalzemeTipi();
            if (Form_MalzemeTipi.FormAcikMi)
            {
                FormuOneGetir(tip);
                return;
            }
            FormAc(tip);
        }

        private void motorluMalzemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MoturluMalzeme malzeme = new Form_MoturluMalzeme();
            if (Form_MoturluMalzeme.FormAcikMi)
            {
                FormuOneGetir(malzeme);
                return;
            }

            malzeme.MdiParent = this;
            malzeme.Show();
        }

        private void sulamaMalzemeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SulamaMalzeme malzeme = new Form_SulamaMalzeme();
            if (Form_SulamaMalzeme.FormAcikMi)
            {
                FormuOneGetir(malzeme);
                return;
            }

            malzeme.MdiParent = this;
            malzeme.Show();
        }

        private void tasimaAraclariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TasimaAraclari arac = new Form_TasimaAraclari();
            if (Form_TasimaAraclari.formacikmi)
            {
                FormuOneGetir(arac);
            }
            else
            {
                arac.MdiParent = this;
                arac.Show();
            }
        }

        private void tasimaAraciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TasimaAraciEkle arac = new Form_TasimaAraciEkle();
            if (Form_TasimaAraciEkle.formacikmi)
            {
                FormuOneGetir(arac);
            }
            else
            {
                arac.MdiParent = this;
                arac.Show();
            }
        }

        private void malzemeSatinAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SatinAlma satinAlma = new Form_SatinAlma();
            if (Form_SatinAlma.formAcikMi)
            {
                FormuOneGetir(satinAlma);
            }
            else
            {
                satinAlma.MdiParent = this;
                satinAlma.Show();
            }
        }

        private void malzemeCikisiYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MalzemeCikis cikis = new Form_MalzemeCikis();
            if (Form_MalzemeCikis.formAcikMi)
            {
                FormuOneGetir(cikis);
            }
            else
            {
                cikis.MdiParent = this;
                cikis.Show();
            }
        }

        private void depoBilgisiGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DepoBilgi bilgi = new Form_DepoBilgi();
            if (Form_DepoBilgi.formAcikMi)
            {
                FormuOneGetir(bilgi);
            }
            else
            {
                bilgi.MdiParent = this;
                bilgi.Show();
            }
        }

        private void AjandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hatirlatmalar hatirla = new Form_Hatirlatmalar();
            if (Form_Hatirlatmalar.formAcikMi)
            {
                FormuOneGetir(hatirla);
            }
            else
            {
                hatirla.MdiParent = this;
                hatirla.Show();
            }
        }

        private void yeniRaporEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EkipRapor rapor = new Form_EkipRapor();
            if (Form_EkipRapor.formAcikMi)
            {
                FormuOneGetir(rapor);
            }
            else
            {
                rapor.MdiParent = this;
                rapor.Show();
            }
        }

        private void butunRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EkipRaporlar rapor = new Form_EkipRaporlar();
            if (Form_EkipRaporlar.formAcikMi)
            {
                FormuOneGetir(rapor);
            }
            else
            {
                rapor.MdiParent = this;
                rapor.Show();
            }
        }

        private void yeniParkEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OyunPark park = new Form_OyunPark();
            if (Form_OyunPark.formAcikMi)
            {
                FormuOneGetir(park);
            }
            else
            {
                park.MdiParent = this;
                park.Show();
            }
        }

        private void OyunparkGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OyunParkGuncelle guncelle = new Form_OyunParkGuncelle();
            if (guncelle.ShowDialog() == DialogResult.OK)
            {
                Form_OyunPark park = new Form_OyunPark(guncelle.ParkID);
                park.MdiParent = this;
                park.Show();
            }
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport_personelListesi liste = new XtraReport_personelListesi();
            liste.ShowPreview();
        }

        private void parkMalzemeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OyunParkGuncelle parkG = new Form_OyunParkGuncelle(true);
            DialogResult sonuc = parkG.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                return;
            }

            XtraReport_OyunParkMalzeme liste = new XtraReport_OyunParkMalzeme(parkG.ParkID);
            liste.ShowPreview();
        }

        private void depoCikisBilgisiAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport_depoCikis rapor = new XtraReport_depoCikis();
            rapor.ShowPreview();
        }

        private void satınAlmaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport_depoGiris rapor = new XtraReport_depoGiris();
            rapor.ShowPreview();
        }
    }
}
