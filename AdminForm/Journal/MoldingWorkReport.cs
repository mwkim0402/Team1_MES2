﻿using AdminForm.Journal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class MoldingWorkReport : documentViewer
    {
        public MoldingWorkReport()
        {
            InitializeComponent();
        }

        private void MoldingWorkReport_Load(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyDBConn"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = "select * from Employees where EmployeeID < 100";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Employees");
                conn.Close();
            }
            MoldingReport rpt = new MoldingReport();
            rpt.DataSource = ds.Tables["Employees"];
            //ReportPreviewForm frm = new ReportPreviewForm(rpt);

            documentViewer1.DocumentSource = rpt;
        }
    }
}
