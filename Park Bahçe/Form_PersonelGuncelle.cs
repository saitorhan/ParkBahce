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
    public partial class Form_PersonelGuncelle : Form
    {
        static public bool FormAcikMi = false;
        ParkBahceDataContext ctx = new ParkBahceDataContext();

        public Form_PersonelGuncelle()
        {
            InitializeComponent();
        }

        public Form_PersonelGuncelle(bool deger)
        {
            InitializeComponent();
            silme = true;
        }

        bool silme = false;
        private void Form_PersonelGuncelle_Load(object sender, EventArgs e)
        {
            if (silme)
            {
                this.Text = "Personel Sil";
            }
            FormAcikMi = true;
        }

        private void Form_PersonelGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcikMi = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = null;

            try
            {
                personel = ctx.Personels.Where(p => p.Kimlik == textBox_kimlikNo.Text).Select(p => p).Single();
            }
            catch (Exception){}

            if (personel==null)
            {
                toolStripStatusLabel_bilgi.Text = "Personel bulunamadı";
            }
            else
            {
                Form_Personel form;
                if (this.Text=="Personel Sil")
                {
                    form = new Form_Personel(personel, false);
                }
                else
                {
                    form = new Form_Personel(personel, true);
                }
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Close();
            }
        }
    }
}
