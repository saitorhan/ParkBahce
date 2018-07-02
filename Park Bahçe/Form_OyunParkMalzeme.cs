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
    public partial class Form_OyunParkMalzeme : Form
    {
        OyunPark park;
        static public bool formAcikMi = false;
        ParkBahceDataContext ctx = new ParkBahceDataContext();
        public Form_OyunParkMalzeme(int ID )
        {
            InitializeComponent();
            park = ctx.OyunParks.Where(p => p.ID == ID).Select(p => p).Single();
            label_parkAd.Text = "Park Adı: " + park.Ad;
        }

        private void Form_OyunParkMalzeme_Load(object sender, EventArgs e)
        {
            formAcikMi = true;
            comboBox_malzeme.DataSource = ctx.MalzameTips.Select(m => m).OrderBy(m => m.Ad);
            ParkMalzemeListesi();
        }

        private void ParkMalzemeListesi()
        {
            listView_malzeme.Items.Clear();

            IEnumerable<OParkMalzeme> malzemeler = ctx.OParkMalzemes.Where(p => p.OParkID == park.ID).Select(m => m).OrderBy(m => m.MalzameTip.Ad);

            foreach (OParkMalzeme item in malzemeler)
            {
                ListViewItem i = new ListViewItem(item.MalzameTip.Ad);
                i.SubItems.Add(item.Adet.ToString());
                listView_malzeme.Items.Add(i);
            }
        }

        private void Form_OyunParkMalzeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi = false;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            int adet;
            if (Kontroller.SayiKontrol(textBox_adet.Text))
            {
                adet = Convert.ToInt32(textBox_adet.Text);
            }
            else
            {
                return;
            }

            OParkMalzeme malzeme;
            int secilenMalzeme=(comboBox_malzeme.SelectedItem as MalzameTip).ID;
            if (ctx.OParkMalzemes.Count(m=>m.MID==secilenMalzeme && m.OParkID==park.ID) > 0)
            {
                malzeme = ctx.OParkMalzemes.Where(m => m.MID == secilenMalzeme && m.OParkID == park.ID).Select(m => m).Single();
                malzeme.Adet += adet;
            }
            else
            {
                malzeme = new OParkMalzeme();
                malzeme.MID = secilenMalzeme;
                malzeme.OParkID = park.ID;
                malzeme.Adet = adet;
                ctx.OParkMalzemes.InsertOnSubmit(malzeme);
            }
            ctx.SubmitChanges();
            ParkMalzemeListesi();
        }

    }
}
