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
    public partial class Form_TasimaAraclari : Form
    {
        static public bool formacikmi = false;
        TasimaArac guncellenecek;
        ParkBahceDataContext ctx = new ParkBahceDataContext();

        public Form_TasimaAraclari()
        {
            InitializeComponent();
        }

        private void Form_TaşımaAraçları_Load(object sender, EventArgs e)
        {
            formacikmi = true;
            MalzemeleriGetir();
        }

        private void MalzemeleriGetir()
        {
            var malzemeler=from m in ctx.TasimaAracs
                           orderby m.MalzameTip.Ad
                           select new 
                           {
                               m.ID,
                               m.MalzameTip.Ad,
                               m.Plaka,
                               perso=m.Personel.Ad,
                               m.Personel.Soyad,
                               m.STarih
                           };

            dataGridView_malzemeler.DataSource=malzemeler;
            dataGridView_malzemeler.Columns[0].HeaderText = "No";
            dataGridView_malzemeler.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[1].HeaderText = "Taşıt Adı";
            dataGridView_malzemeler.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[2].HeaderText = "Plaka";
            dataGridView_malzemeler.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[3].HeaderText = "Personel Ad";
            dataGridView_malzemeler.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[4].HeaderText = "Personel Soyad";
            dataGridView_malzemeler.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_malzemeler.Columns[5].HeaderText = "Satın Alma";
            dataGridView_malzemeler.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form_TaşımaAraçları_FormClosed(object sender, FormClosedEventArgs e)
        {
            formacikmi = false;
        }

        private void dataGridView_malzemeler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            comboBox_personel.DataSource = ctx.Personels.Where(p => p.Aktif == true).Select(p => p).OrderBy(p => p.Ad);

            foreach (DataGridViewRow item in dataGridView_malzemeler.Rows)
            {
                item.Selected = false;
            }

            dataGridView_malzemeler.Rows[e.RowIndex].Selected = true;
            int ID = Convert.ToInt32(dataGridView_malzemeler.SelectedRows[0].Cells[0].Value);
            guncellenecek = ctx.TasimaAracs.Where(t => t.ID == ID).Select(t => t).Single();

            label_no.Text = guncellenecek.ID.ToString();
            textBox_ad.Text = guncellenecek.MalzameTip.ToString();
            textBox_plaka.Text = guncellenecek.Plaka;
            dateTimePicker_tarih.Value = guncellenecek.STarih;

            foreach (Personel item in comboBox_personel.Items)
            {
                if (item.ID == guncellenecek.Kimde)
                {
                    comboBox_personel.SelectedItem = item;
                    break;
                }
            }

            panel_bilgiler.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncellenecek = null;
            panel_bilgiler.SendToBack();
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                guncellenecek.Plaka = textBox_plaka.Text;
                guncellenecek.STarih = dateTimePicker_tarih.Value;
                guncellenecek.Kimde = (comboBox_personel.SelectedItem as Personel).ID;
                ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarılı";
                MalzemeleriGetir();
            }
            catch (Exception)
            {
                toolStripStatusLabel_bilgi.Text = "Güncelleme başarısız";
            }
            finally
            {
                button1_Click(null, null);
            }
        }
    }
}
