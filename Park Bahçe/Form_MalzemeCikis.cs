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
    public partial class Form_MalzemeCikis : Form
    {
        public Form_MalzemeCikis()
        {
            InitializeComponent();
        }

        static public bool formAcikMi = false;
        ParkBahceDataContext ctx;
        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İşlem iptal edilecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış işlemi yapılacak. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc!=DialogResult.Yes)
            {
                return;
            }
            DepoCiki cikis = new DepoCiki();
            cikis.DMID = (comboBox_malzeme.SelectedItem as DepoBilgi).MTipID;
            cikis.Tarih = dateTimePicker_tarih.Value;
            cikis.Miktar = Convert.ToInt32(numericUpDown_miktar.Value);
            cikis.PID = (comboBox_personel.SelectedItem as Personel).ID;
            ctx.DepoCikis.InsertOnSubmit(cikis);
            (comboBox_malzeme.SelectedItem as DepoBilgi).Miktar -= cikis.Miktar;
            try
            {
                ctx.SubmitChanges();
                MessageBox.Show("Çıkış işlemi başarı ile yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Çıkış işlemi başarısizlıkla sonuçlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_malzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown_miktar.Maximum = (comboBox_malzeme.SelectedItem as DepoBilgi).Miktar;
        }

        private void Form_MalzemeCikis_Load(object sender, EventArgs e)
        {
            formAcikMi = true;
            ctx=new ParkBahceDataContext();
            comboBox_malzeme.DataSource = ctx.DepoBilgis.Where(m => m.Miktar > 0).Select(m => m).OrderBy(m => m.MalzameTip.Ad);
            comboBox_personel.DataSource = ctx.Personels.Where(p=>p.Aktif).Select(p => p).OrderBy(p => p.Ad);
        }

        private void Form_MalzemeCikis_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi = false;
        }
    }
}
