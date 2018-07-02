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
    public partial class Form_EkipRapor : Form
    {
        public Form_EkipRapor()
        {
            InitializeComponent();
            button_sil.Visible=false;
        }

        public Form_EkipRapor(int ID)
        {
            InitializeComponent();
            ctx=new ParkBahceDataContext();
            rapor=ctx.ERapors.Where( r => r.ID==ID ).Select( r => r ).Single();
        }

        ParkBahceDataContext ctx;
        static public bool formAcikMi=false;
        ERapor rapor=null;
        private void button_iptal_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show( "İşlem iptal edilecek. Onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Hand ) == DialogResult.Yes )
            {
                this.Close();
            }
        }

        private void Form_EkipRapor_Load(object sender, EventArgs e)
        {
            formAcikMi=true;
            ctx=new ParkBahceDataContext();
            comboBox_ekip.DataSource=ctx.Ekips.Select( ek => ek ).OrderBy( ek => ek.Ad );
            if ( rapor!=null )
            {
                foreach ( Ekip item in comboBox_ekip.Items )
                {
                    if ( item.ID==rapor.E_ID )
                    {
                        comboBox_ekip.SelectedItem=item;
                        break;
                    }
                }

                dateTimePicker_tarih.Value=rapor.Tarih;
                textBox_rapor.Text=rapor.Rapor;
                button_kaydet.Text="Güncelle";
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            switch ( button_kaydet.Text )
            {
                case "Kaydet":
                    YeniRaporKaydiAl();
                    break;
                case "Güncelle":
                    RaporGuncelle();
                    break;
                default:
                    break;
            }
        }

        private void RaporGuncelle()
        {
            rapor.Tarih=dateTimePicker_tarih.Value;
            rapor.E_ID=( comboBox_ekip.SelectedItem as Ekip ).ID;
            rapor.Rapor=textBox_rapor.Text.Trim();
            try
            {
                ctx.SubmitChanges();
                MessageBox.Show( "Güncelleme başarılı şekilde sonuçlandı." );
                this.Close();
            }
            catch ( Exception )
            {
                MessageBox.Show( "Rapor güncellemesi başarısızlıkla sonuçlandı." );
            }
        }

        private void YeniRaporKaydiAl()
        {
            rapor = new ERapor();
            rapor.Tarih=dateTimePicker_tarih.Value;
            rapor.E_ID=( comboBox_ekip.SelectedItem as Ekip ).ID;
            rapor.Rapor=textBox_rapor.Text.Trim();
            ctx.ERapors.InsertOnSubmit( rapor );
            try
            {
                ctx.SubmitChanges();
                MessageBox.Show( "Kayıt başarılı şekilde sonuçlandı." );
                textBox_rapor.Text=String.Empty;
            }
            catch ( Exception )
            {
                MessageBox.Show( "Rapor kaydı başarısızlıkla sonuçlandı." );
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=MessageBox.Show( "Rapor silinecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop );
            if ( sonuc==DialogResult.Yes )
            {
                ctx.ERapors.DeleteOnSubmit( rapor );
            }
            try
            {
                ctx.SubmitChanges();
                MessageBox.Show( "Silme başarılı şekilde sonuçlandı." );
                this.Close();
            }
            catch ( Exception )
            {
                MessageBox.Show( "Rapor silme başarısızlıkla sonuçlandı." );
            }
        }

        private void Form_EkipRapor_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi=false;
        }
    }
}
