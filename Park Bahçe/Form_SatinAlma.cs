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
    public partial class Form_SatinAlma : Form
    {
        public Form_SatinAlma()
        {
            InitializeComponent();
        }

        static public bool formAcikMi = false;
        ParkBahceDataContext ctx;
        double birimFiyat = 0;
        int miktar = 0;
        decimal toplamFiyat = 0;
        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Satın alma işlemi iptal edilecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_SatinAlma_Load(object sender, EventArgs e)
        {
            formAcikMi = true;
            ctx = new ParkBahceDataContext();
            comboBox_MalzemeTip.DataSource = ctx.MalzameTips.Select(m => m).OrderBy(m => m.Ad);
            comboBox_personel.DataSource = ctx.Personels.Select(p => p).OrderBy(p => p.Ad);
        }

        private void Form_SatinAlma_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi = false;
        }

        private void textBox_miktar_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox_miktar.Text, out miktar))
                miktar = Convert.ToInt32(textBox_miktar.Text);
            toplamFiyat = Convert.ToDecimal(miktar * birimFiyat);
            textBox_toplamFiyat.Text = toplamFiyat.ToString();
        }

        private void textBox_birimFiyat_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox_birimFiyat.Text, out birimFiyat))
                birimFiyat = Convert.ToDouble(textBox_birimFiyat.Text);
            toplamFiyat = Convert.ToDecimal(miktar * birimFiyat);
            textBox_toplamFiyat.Text = toplamFiyat.ToString();
        }

        private void button_satinAl_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Satın almayı onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc != DialogResult.Yes)
            {
                return;
            }

            SatinAlma yeniSatinAlma = new SatinAlma();
            yeniSatinAlma.DMID = (comboBox_MalzemeTip.SelectedItem as MalzameTip).ID;
            yeniSatinAlma.Tarih = dateTimePicker_tarih.Value;
            yeniSatinAlma.Miktar = miktar;
            yeniSatinAlma.Ucret = toplamFiyat;
            yeniSatinAlma.PID = (comboBox_personel.SelectedItem as Personel).ID;

            try
            {
                ctx.SatinAlmas.InsertOnSubmit(yeniSatinAlma);
                int depoMID = ctx.DepoBilgis.Count(d => d.MTipID == yeniSatinAlma.DMID);
                if (depoMID==0)
                {
                    DepoBilgi depoBilgi = new DepoBilgi();
                    depoBilgi.MTipID = yeniSatinAlma.DMID;
                    depoBilgi.Miktar = yeniSatinAlma.Miktar;
                    ctx.DepoBilgis.InsertOnSubmit(depoBilgi);
                }
                else
                {
                    DepoBilgi depoBilgi = ctx.DepoBilgis.Where(d => d.MTipID == yeniSatinAlma.DMID).Select(d => d).Single();
                    depoBilgi.Miktar += yeniSatinAlma.Miktar;
                }
                ctx.SubmitChanges();
                MessageBox.Show("Satın alma başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
