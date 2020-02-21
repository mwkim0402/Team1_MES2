using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FieldOperationForm.JobOrder_Package
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(string c,string f,string t)
        {
            InitializeComponent();
            string c1 = c;
            string f1 = f;
            string t1 = t;
            //string barcode1 = barcode;

            xrTableCell2.Text = f1;
            xrTableCell5.Text = t1;
           xrTableCell8.Text = c1;
            //xrBarCode1.Text = barcode1;
        }
     
    }
}
