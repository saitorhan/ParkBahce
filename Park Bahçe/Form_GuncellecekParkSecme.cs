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
    public partial class Form_GuncellecekParkSecme : Form
    {
        public Form_GuncellecekParkSecme(Form_Park.AcilmaTipi acilmatip)
        {
            InitializeComponent();

            switch (acilmatip)
            {
                case Form_Park.AcilmaTipi.Sil:
                    this.Text = "Silinecek Parkı Seçiniz";
                    label1.Text = "Silinecek Park";
                    break;
                default:
                    break;
            }
        }


        private void Form_GuncellecekParkSecme_Load(object sender, EventArgs e)
        {
            ParkBahceDataContext ctx=new ParkBahceDataContext();
            try
            {
                comboBox1.DataSource = ctx.Parks.Select(p => p).OrderBy(p => p.Ad);
            }
            catch (Exception)
            {
                MessageBox.Show("Park bilgileri alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Ana.ParkID = (comboBox1.SelectedItem as Park).ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
