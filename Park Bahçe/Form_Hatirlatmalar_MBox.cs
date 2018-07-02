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
    public partial class Form_Hatirlatmalar_MBox : Form
    {
        public Form_Hatirlatmalar_MBox()
        {
            InitializeComponent();
            button_guncelle.Text="Kaydet";
            button_sil.Visible=false;
        }
        public Form_Hatirlatmalar_MBox( int ID)
        {
            InitializeComponent();
            gelen=ctx.Hatirlatmas.Where( h => h.ID==ID ).Select( h => h ).Single();
            dateTimePicker_tarih.Value=Convert.ToDateTime( gelen.Tarih );
            dateTimePicker_saat.Value=Convert.ToDateTime( gelen.Tarih );
            textBox_gorev.Text=gelen.Metin;
            checkBox_yapildi.Checked=gelen.Yapildi;
        }

        Hatirlatma gelen;
        ParkBahceDataContext ctx=new ParkBahceDataContext();
        private void button_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=MessageBox.Show( "Görev silinecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
            if ( sonuc==DialogResult.Yes )
            {
                ctx.Hatirlatmas.DeleteOnSubmit( gelen );
                ctx.SubmitChanges();
                MessageBox.Show( "Gorev silindi." );
            }
            this.Close();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            if ( button_guncelle.Text=="Güncelle" )
            {
                DialogResult sonuc = MessageBox.Show( "Görev güncellenecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if ( sonuc!=DialogResult.Yes )
                {
                    return;
                }
                gelen.Tarih=new DateTime( dateTimePicker_tarih.Value.Year, dateTimePicker_tarih.Value.Month, dateTimePicker_tarih.Value.Day, dateTimePicker_saat.Value.Hour, dateTimePicker_saat.Value.Minute, 0 );
                gelen.Metin=textBox_gorev.Text.Trim();
                gelen.Yapildi=checkBox_yapildi.Checked;
                ctx.SubmitChanges();
                MessageBox.Show( "Görev güncellendi." );
            }
            else
            {
                DialogResult sonuc = MessageBox.Show( "Görev eklenecek. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if ( sonuc!=DialogResult.Yes )
                {
                    return;
                }
                gelen=new Hatirlatma();
                gelen.Tarih=new DateTime( dateTimePicker_tarih.Value.Year, dateTimePicker_tarih.Value.Month, dateTimePicker_tarih.Value.Day, dateTimePicker_saat.Value.Hour, dateTimePicker_saat.Value.Minute, 0 );
                gelen.Metin=textBox_gorev.Text.Trim();
                gelen.Yapildi=checkBox_yapildi.Checked;
                ctx.Hatirlatmas.InsertOnSubmit( gelen );
                ctx.SubmitChanges();
                MessageBox.Show( "Görev eklendi." );
            }

            this.Close();
        }

        static public bool formAcikMi=false;
        private void Form_Hatirlatmalar_MBox_Load(object sender, EventArgs e)
        {
            formAcikMi=true;
        }

        private void Form_Hatirlatmalar_MBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi=false;
        }
    }
}
