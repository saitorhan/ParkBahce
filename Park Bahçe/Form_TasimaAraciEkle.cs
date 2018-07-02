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
    public partial class Form_TasimaAraciEkle : Form
    {
        static public bool formacikmi = false;
        ParkBahceDataContext ctx= new ParkBahceDataContext();
        
        public Form_TasimaAraciEkle()
        {
            InitializeComponent();
        }

        private void Form_TasimaAraciEkle_Load(object sender, EventArgs e)
        {
            formacikmi = true;
            comboBox_ad.DataSource=ctx.MalzameTips.Where(a=>a.Aktif).Select(a=>a).OrderBy(a=>a.Ad);
            
        }

        private void Form_TasimaAraciEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            formacikmi = false;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc= MessageBox.Show("İşlem iptal edilecek. Onaylamak için Evet butonunu tıklayın","Uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (sonuc==DialogResult.Yes)
            {
		        this.Close();
            }
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            int malzemetip=(comboBox_ad.SelectedItem as MalzameTip).ID;
            DateTime tarih=dateTimePicker_tarih.Value;
            textBox_plaka.Text=textBox_plaka.Text.Trim().ToUpper();
            try 
	{	        
		ctx.ExecuteCommand("INSERT INTO [dbo].[TasimaArac]([MTipID],[Plaka],[STarih]) VALUES({0},{1},{2})",malzemetip,textBox_plaka.Text,tarih);
                toolStripStatusLabel_bilgi.Text="Kayıt başarılı";
	}
	catch (Exception)
	{
		 toolStripStatusLabel_bilgi.Text="Kayıt başarısız";
	}
        }
    }
}
