using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Park_Bahçe
{
    public partial class XtraReport_OyunParkMalzeme : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_OyunParkMalzeme(int ID)
        {
            InitializeComponent();
            park.Value = ID;
        }

    }
}
