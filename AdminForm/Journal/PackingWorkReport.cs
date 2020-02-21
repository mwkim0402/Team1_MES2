using AdminForm.Journal;
using DevExpress.XtraReports.UI;
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
    public partial class PackingWorkReport : documentViewer
    {
        private delegate void SafeCallDelegate(PackingReport rep);
        MainForm frm;
        PackingReport rpt = new PackingReport();

        public PackingWorkReport()
        {
            InitializeComponent();
        }

        private void PackingWorkReport_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            setAction();
            //frm = (MainForm)this.MdiParent;
            //using (FrmWaitForm frm = new FrmWaitForm(setAction))
            //{
            //    frm.ShowDialog(this);
            //}
        }
        private void setAction()
        {

            string findDate = dtpProduction.Value.ToString().Substring(0, 10);

            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = $@"select Workorderno, im.Item_Name, wc.Wc_Name, Plan_Qty, w.Wo_Status from WorkOrder w, WorkCenter_Master wc, Item_Master im
                                    where w.Wc_Code = wc.Wc_Code and w.Item_Code = im.Item_Code
                                    and wc.Wc_Group = '포장' and convert(varchar(10), w.Ins_Date,23) = '{findDate}'";
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Query");
                conn.Close();
            }
            rpt.Parameters["SelectedDate"].Value = dtpProduction.Value;
            rpt.Parameters["SelectedDate"].Visible = false;
            rpt.DataSource = ds;
            rpt.CreateDocument();
            WorkOrderDetailView(rpt);

        }

        private void WorkOrderDetailView(PackingReport rep)
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

        private void PackingWorkReport_Activated(object sender, EventArgs e)
        {
            frm.btnExcel.Enabled = false;// 엑셀저장 비활성화

            frm.Search_Click += this.Search_Click;
            frm.Create_Click += this.Print_Click;
        }

        private void PackingWorkReport_Deactivate(object sender, EventArgs e)
        {
            frm.btnExcel.Enabled = true;// 엑셀저장 활성화

            frm.Search_Click -= this.Search_Click;
            frm.Create_Click -= this.Print_Click;
        }
        private void Print_Click(object sender, EventArgs e)
        {
            using (FrmWaitForm frm = new FrmWaitForm(printAction))
            {
                frm.ShowDialog(this);
            }
           
        }

        private void printAction()
        {

            rpt.ShowPreviewDialog();
        }
    }
}
