using AdminForm.Journal;
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
    public partial class LoadWorkReport : documentViewer
    {
        public LoadWorkReport()
        {
            InitializeComponent();
        }

        private void LoadWorkReport_Load(object sender, EventArgs e)
        {
            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = "select * from GV_History";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "GV");
                conn.Close();
            }
            LoadingReport rpt = new LoadingReport();
            rpt.DataSource = ds.Tables["GV"];
            //ReportPreviewForm frm = new ReportPreviewForm(rpt);

        }
    }
}
