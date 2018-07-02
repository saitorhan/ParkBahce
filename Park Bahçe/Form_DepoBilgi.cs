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
    public partial class Form_DepoBilgi : Form
    {
        public Form_DepoBilgi()
        {
            InitializeComponent();
        }
        
        static public bool formAcikMi = false;
        private void Form_DepoBilgi_Load(object sender, EventArgs e)
        {
            formAcikMi = true;
            MalzemeListesiCek();
            timer1.Start();
        }

        private void MalzemeListesiCek()
        {
            ParkBahceDataContext ctx = new ParkBahceDataContext();

            IEnumerable<DepoBilgi> DepoBilgisi = ctx.DepoBilgis.Select(d => d).OrderBy(d=>d.MalzameTip.Ad);

            listView_depoBilgi.Items.Clear();
            foreach (DepoBilgi item in DepoBilgisi)
            {
                ListViewItem i = new ListViewItem(item.MalzameTip.Ad);
                i.SubItems.Add(item.Miktar.ToString());
                listView_depoBilgi.Items.Add(i);
                if (item.Miktar<5)
                {
                    i.BackColor = Color.Yellow;
                }
            }
        }

        private void Form_DepoBilgi_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAcikMi = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MalzemeListesiCek();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XtraReport_depoBilgi rapor = new XtraReport_depoBilgi();
            rapor.ShowPreview();
        }
    }
}
