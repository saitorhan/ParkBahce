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
    public partial class Form_Hatirlatmalar : Form
    {
        enum GorevDurumu
        {
            Yapilacaklar,
            Yapilmislar,
            ButunGorevler
        }
        public Form_Hatirlatmalar()
        {
            InitializeComponent();
        }

        ParkBahceDataContext ctx;
        static public bool formAcikMi=false;
        private void Form_Hatirlatmalar_Load(object sender, EventArgs e)
        {
            formAcikMi=true;
            ctx = new ParkBahceDataContext();
            GorevleriListele( GorevDurumu.ButunGorevler );
            sonGoruntulenen=GorevDurumu.ButunGorevler;
        }

        private void GorevleriListele(GorevDurumu gorevDurumu)
        {
            listView_gorev.Items.Clear();
            IEnumerable<Hatirlatma> Hatirlatmalar;
            switch ( gorevDurumu )
            {
                case GorevDurumu.Yapilacaklar:
                    Hatirlatmalar = ctx.Hatirlatmas.Where( h => h.Yapildi == false ).Select( h => h ).OrderBy( h => h.Tarih );
                    break;
                case GorevDurumu.Yapilmislar:
                    Hatirlatmalar = ctx.Hatirlatmas.Where( h => h.Yapildi ).Select( h => h ).OrderBy( h => h.Tarih );
                    break;
                case GorevDurumu.ButunGorevler:
                    Hatirlatmalar = ctx.Hatirlatmas.Select( h => h ).OrderBy( h => h.Tarih );
                    break;
                default:
                    Hatirlatmalar = ctx.Hatirlatmas.Select( h => h ).OrderBy( h => h.Tarih );
                    break;
            }

            foreach ( Hatirlatma item in Hatirlatmalar )
            {
                ListViewItem i = new ListViewItem( item.ID.ToString() );
                i.SubItems.Add( item.Tarih.ToString() );
                i.SubItems.Add( item.Metin );
                i.SubItems.Add( item.Yapildi ? "Yapıldı" : "Yapılmadı" );
                listView_gorev.Items.Add( i );
            }
        }

        bool yenilendi=false;
        private void listView_gorev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( yenilendi )
            {
                yenilendi=false;
                return;
            }
            int ID;
            if ( listView_gorev.SelectedItems.Count > 0 )
                ID=Convert.ToInt32( listView_gorev.SelectedItems[0].SubItems[0].Text );
            else
                return;
            Form_Hatirlatmalar_MBox mesaj = new Form_Hatirlatmalar_MBox( ID );
            if ( DialogResult.Yes== mesaj.ShowDialog() )
            {
                yenilendi=true;
                GorevleriListele( sonGoruntulenen );
            }
            else
                yenilendi=false;

        }

        GorevDurumu sonGoruntulenen;
        private void butunGorevlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevleriListele( GorevDurumu.ButunGorevler );
            sonGoruntulenen=GorevDurumu.ButunGorevler;
        }

        private void yapilmamisGorevlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevleriListele( GorevDurumu.Yapilacaklar );
            sonGoruntulenen=GorevDurumu.Yapilacaklar;
        }

        private void yapilmisGorevlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GorevleriListele( GorevDurumu.Yapilmislar );
            sonGoruntulenen=GorevDurumu.Yapilmislar;
        }

        private void yeniGorevEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hatirlatmalar_MBox yeniGorev=new Form_Hatirlatmalar_MBox();
            if ( Form_Hatirlatmalar_MBox.formAcikMi )
            {
                foreach ( Form item in this.MdiParent.MdiChildren )
                {
                    if ( item.Text==yeniGorev.Text )
                    {
                        item.BringToFront();
                    }
                }
            }
            else
            {
                yeniGorev.MdiParent=this.MdiParent;
                yeniGorev.Show();
            }
        }

        private void Form_Hatirlatmalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi=false;
        }

    }
}
