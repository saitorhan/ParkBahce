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
    public partial class Form_SulamaMalzeme : Form
    {
        static public bool FormAcikMi = false;
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        SulamaMalzeme guncellenecek;

        public Form_SulamaMalzeme()
        {
            InitializeComponent();
        }

        private void Form_SulamaMalzeme_Load(object sender, EventArgs e)
        {
            MalzemeleriGetir();
        }

        private void MalzemeleriGetir()
        {
            var Malzemeler = from m in ctx.SulamaMalzemes
                             orderby m.MalzameTip.Ad
                             select new
                             {
                                 m.ID,
                                 m.MalzameTip.Ad,
                                 m.Uzunluk,
                                 m.Cap,
                                 m.Adet
                             };

            dataGridView_malzemeler.DataSource = Malzemeler;

            dataGridView_malzemeler.Columns[0].HeaderText = "No";
            dataGridView_malzemeler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[1].HeaderText = "Malzeme Adı";
            dataGridView_malzemeler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[2].HeaderText = "Uzunluk";
            dataGridView_malzemeler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[3].HeaderText = "Çap";
            dataGridView_malzemeler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[4].HeaderText = "Adet";
            dataGridView_malzemeler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView_malzemeler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            foreach (DataGridViewRow item in dataGridView_malzemeler.Rows)
            {
                item.Selected = false;
            }

            dataGridView_malzemeler.Rows[e.RowIndex].Selected = true;

            int ID = Convert.ToInt32(dataGridView_malzemeler.SelectedRows[0].Cells[0].Value);
            guncellenecek = ctx.SulamaMalzemes.Where(s => s.ID == ID).Select(s => s).Single();

            label_no.Text = guncellenecek.ID.ToString();
            textBox_ad.Text = guncellenecek.MalzameTip.Ad;
            textBox_adet.Text = guncellenecek.Adet.ToString();
            textBox_uzunluk.Text = guncellenecek.Uzunluk.ToString();
            textBox_cap.Text = guncellenecek.Cap.ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            string uzunluk = textBox_uzunluk.Text.Trim();
            textBox_uzunluk.Text = uzunluk;
            if (Kontroller.SayiKontrol(uzunluk))
            {
                guncellenecek.Uzunluk = Convert.ToInt32(uzunluk);
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Uzunluk bilgisini kontrol ediniz.";
                return;
            }

            uzunluk = textBox_cap.Text.Trim();
            textBox_cap.Text = uzunluk;
            try
            {
                guncellenecek.Cap = Convert.ToDouble(uzunluk);
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "Çap bilgisini kontrol ediniz.";
                return;
            }

            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarılı";
                MalzemeleriGetir();
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarısız";
            }

        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (Form_Ana.SilmeOnayiAl(guncellenecek.MalzameTip.Ad) == DialogResult.Yes)
            {
                try
                {
                    ctx.SulamaMalzemes.DeleteOnSubmit(guncellenecek);
                    ctx.SubmitChanges();
                    MalzemeleriGetir();
                    toolStripStatusLabel_bilgi.Text = "Silme başarılı";
                }
                catch (Exception)
                {
                    toolStripStatusLabel_bilgi.Text = "Silme başarısız";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
