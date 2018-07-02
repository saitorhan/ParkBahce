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
    public partial class Form_OyunParkGuncelle : Form
    {
        public Form_OyunParkGuncelle()
        {
            InitializeComponent();
        }

        public Form_OyunParkGuncelle(bool MalzemeListesi)
        {
            InitializeComponent();
            label1.Text = "Park Seçin: ";
            Text = "Malzeme Listelenecek Park";
        }

        public int ParkID;
        private void Form_OyunParkGuncelle_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = (new ParkBahceDataContext()).OyunParks.Select(p => p).OrderBy(p => p.Ad);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParkID = (comboBox1.SelectedItem as OyunPark).ID;
        }
    }
}
