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
    public partial class Form_TatillerKayit : Form
    {
        public Form_TatillerKayit()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ramazan_ValueChanged(object sender, EventArgs e)
        {
            ListViewDoldur();
        }


        List<Tatiller> ResmiTatiller = new List<Tatiller>();
        private void ListViewDoldur()
        {
            listView_tatiller.Items.Clear();
            ResmiTatiller.Clear();

            DateTime ramazan = new DateTime(dateTimePicker_ramazan.Value.Year, dateTimePicker_ramazan.Value.Month, dateTimePicker_ramazan.Value.Day);

            for (int i = 1; i <= 3; i++)
            {
                ListViewItem item = new ListViewItem(ramazan.ToLongDateString());
                string tatilIsmi = "Ramazan Bayramı " + i + ". Gün";
                item.SubItems.Add(tatilIsmi);
                listView_tatiller.Items.Add(item);
                Tatiller tatil = new Tatiller();
                tatil.Ad = tatilIsmi;
                tatil.Gun = ramazan.Day;
                tatil.Ay = ramazan.Month;
                tatil.Yil = ramazan.Year;
                ResmiTatiller.Add(tatil);
                ramazan = ramazan.AddDays(1);
            }

            ramazan = dateTimePicker_kurban.Value;

            for (int i = 1; i <= 4; i++)
            {
                ListViewItem item = new ListViewItem(ramazan.ToLongDateString());
                string tatilIsmi = "Kurban Bayramı " + i + ". Gün";
                item.SubItems.Add(tatilIsmi);
                listView_tatiller.Items.Add(item);
                Tatiller tatil = new Tatiller();
                tatil.Ad = tatilIsmi;
                tatil.Gun = ramazan.Day;
                tatil.Ay = ramazan.Month;
                tatil.Yil = ramazan.Year;
                ResmiTatiller.Add(tatil);
                ramazan = ramazan.AddDays(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParkBahceDataContext ctx = new ParkBahceDataContext();
            ctx.Tatillers.InsertAllOnSubmit(ResmiTatiller);
            try
            {
                ctx.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Tatiller kaydedilirken bir hata ile karşılaşıldı.");
            }
            finally
            {
                this.Close();
            }
        }
    }
}
