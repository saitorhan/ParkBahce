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
    public partial class Form_MoturluMalzeme : Form
    {

        static public bool FormAcikMi = false;
        MotorluMalzame Guncellenecek;
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        public Form_MoturluMalzeme()
        {
            InitializeComponent();
        }

        private void Form_MoturluMalzeme_Load(object sender, EventArgs e)
        {
            MalzemelerListesiGetir(true);
        }

        private void MalzemelerListesiGetir(bool Secenek)
        {
            var Sonuclar = from m in ctx.MotorluMalzames
                           where m.Aktif == Secenek
                           orderby m.MalzameTip.Ad
                           select new
                           {
                               m.ID,
                               m.MalzameTip,
                               m.Verim,
                               m.STarih
                           };

            dataGridView_malzemeler.DataSource = Sonuclar;
            dataGridView_malzemeler.Columns[0].HeaderText = "No";
            dataGridView_malzemeler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[1].HeaderText = "Malzeme Adı";
            dataGridView_malzemeler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[2].HeaderText = "Verim";
            dataGridView_malzemeler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[3].HeaderText = "Satın Alma Tarih";
            dataGridView_malzemeler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
            Guncellenecek = ctx.MotorluMalzames.Where(m => m.ID == ID).Select(m => m).Single();

            label_NO.Text = Guncellenecek.ID.ToString();
            textBox_ad.Text = Guncellenecek.MalzameTip.Ad;
            textBox_ortVerim.Text = Guncellenecek.Verim.ToString();
            dateTimePicker_tarih.Value = Guncellenecek.STarih;
            textBox_adet.Text = ctx.MotorluMalzames.Count(m => m.MTipID == Guncellenecek.MTipID).ToString();
            panel_bilgiler.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_bilgiler.SendToBack();
            Guncellenecek = null;
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            Guncellenecek.Verim = Convert.ToDouble(textBox_ortVerim.Text);
            Guncellenecek.STarih = dateTimePicker_tarih.Value;

            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarılı";
                MalzemelerListesiGetir(true);
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarısız";
            }
            finally
            {
                Guncellenecek = null;
                panel_bilgiler.SendToBack();
            }
        }


        private void button_sil_Click(object sender, EventArgs e)
        {
            if (Form_Ana.SilmeOnayiAl(Guncellenecek.MalzameTip.ToString()) != DialogResult.Yes)
            {
                 panel_bilgiler.SendToBack();
                 Guncellenecek = null;
                 return;
            }
            Guncellenecek.SilmeTarih = dateTimePicker_silmeTarih.Value;
            Guncellenecek.Aktif = false;

            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "Silme başarılı";
                MalzemelerListesiGetir(true);
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "Silme başarısız";
            }
            finally
            {
                Guncellenecek = null;
                panel_bilgiler.SendToBack();
            }
        }
    }
}
