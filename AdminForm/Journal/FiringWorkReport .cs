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
   

    public partial class FiringWorkReport : documentViewer
    {
        private delegate void SafeCallDelegate(FiringReport rep);
        MainForm frm;
        public FiringWorkReport()
        {
            InitializeComponent();
        }

        private void FiringWorkReport_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }

        private void setAction()
        {

            string findDate = dtpProduction.Value.ToString().Substring(0, 10);

            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = $"select * from GV_Master where Ins_Date = '{findDate}'";

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "GV");
                conn.Close();
            }
            FiringReport rpt = new FiringReport();
            rpt.Parameters["SelectedDate"].Value = dtpProduction.Value;
            rpt.Parameters["SelectedDate"].Visible = false;
            rpt.DataSource = ds;
            rpt.CreateDocument();
            //Form2 frm = new Form2();
            //frm.documentViewer1.DocumentSource = rpt;
            //frm.ShowDialog();
            WorkOrderDetailView(rpt);

        }

        private void WorkOrderDetailView(FiringReport rep)
        {

            if (documentViewer1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WorkOrderDetailView);
                Invoke(d, new object[] { rep });
            }
            else
            {
                documentViewer1.DocumentSource = rep;
                documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters, new object[] { true });

            }
        }

        private void FiringWorkReport_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += this.Search_Click;
        }

        private void FiringWorkReport_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.Search_Click;
        }
    }
}
