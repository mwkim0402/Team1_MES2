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
    public partial class MoldingWorkReport : documentViewer
    {
        private delegate void SafeCallDelegate(MoldingReport rep);
        MainForm frm;
        MoldingReport rpt = new MoldingReport();

        public MoldingWorkReport()
        {
            InitializeComponent();
        }

        private void MoldingWorkReport_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }

        private void setAction()
        {

            string findDate = dtpProduction.Value.ToString().Substring(0, 10);

            string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            DataSet dsQuery = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = $@"select Use_Seq, MM.Mold_Name, MH.Workorderno,MH.Use_Starttime,MH.Use_Endtime
                                    from Mold_Use_History MH inner
                                    join Mold_Master MM on MH.Mold_Code = MM.Mold_Code
									and  convert(varchar(10),Use_Starttime,23) = {findDate}";

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(dsQuery, "Query");

                conn.Close();
            }
            rpt.Parameters["SelectedDate"].Value = dtpProduction.Value;
            rpt.Parameters["SelectedDate"].Visible = false;
            rpt.DataSource = dsQuery;
            rpt.CreateDocument();
            WorkOrderDetailView(rpt);

        }

        private void WorkOrderDetailView(MoldingReport rep)
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

        private void MoldingWorkReport_Activated(object sender, EventArgs e)
        {
            frm.btnExcel.Enabled = false;// 엑셀저장 비활성화

            frm.Search_Click += this.Search_Click;
            
            frm.Create_Click += this.Print_Click;
        }

        private void MoldingWorkReport_Deactivate(object sender, EventArgs e)
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
