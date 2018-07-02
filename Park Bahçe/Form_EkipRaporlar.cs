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
    public partial class Form_EkipRaporlar : Form
    {
        public Form_EkipRaporlar()
        {
            InitializeComponent();
        }

        ParkBahceDataContext ctx;
        static public bool formAcikMi=false;
        private void Form_EkipRaporlar_Load(object sender, EventArgs e)
        {
            formAcikMi=true;
            ctx = new ParkBahceDataContext();
            RaporlariGetir();
        }

        private void RaporlariGetir()
        {
            listView_raporlar.Items.Clear();
            IEnumerable<ERapor> raporlar = ctx.ERapors.Select( r => r ).OrderByDescending( r => r.Tarih );

            foreach( ERapor item in raporlar )
            {
                ListViewItem i = new ListViewItem( item.ID.ToString() );
                i.SubItems.Add( item.Ekip.Ad );
                DateTime zaman = Convert.ToDateTime( item.Tarih );
                i.SubItems.Add( zaman.ToString( "dd MMMM yyyy dddd HH:mm" ) );
                i.SubItems.Add( item.Rapor.Length > 200 ? item.Rapor.Substring( 0, 200 ) + "..." : item.Rapor );
                listView_raporlar.Items.Add( i );
            }
        }

        private void Form_EkipRaporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi=false;
        }

        private void listView_raporlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( listView_raporlar.SelectedItems.Count == 0 )
                return;
            int ID = Convert.ToInt32( listView_raporlar.SelectedItems[0].SubItems[0].Text );
            Form_EkipRapor rapor=new Form_EkipRapor( ID );
            rapor.ShowDialog();
        }
    }
}
