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
    public partial class LoadWorkReport : documentViewer
    {
        private delegate void SafeCallDelegate(LoadingReport rep);
        MainForm frm;
        LoadingReport rpt = new LoadingReport();
        public LoadWorkReport()
        {
            InitializeComponent();
        }

        private void LoadWorkReport_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }


        private void LoadWorkReport_Activated(object sender, EventArgs e)
        {
            frm.btnExcel.Enabled = false;// 엑셀저장 비활성화

            frm.Search_Click += this.Search_Click;
            frm.Create_Click += this.Print_Click;
        }

        
        private void LoadWorkReport_Deactivate(object sender, EventArgs e)
        {
            frm.btnExcel.Enabled = true;// 엑셀저장 활성화

            frm.Search_Click -= this.Search_Click;
            frm.Create_Click -= this.Print_Click;
        }
        public void Search_Click(object sender, EventArgs e)
        {
            setAction();
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
                    string strSql = $@"select workorderno, Pallet_No,Grade_Code,Grade_Detail_Code ,Size_Code ,Prd_Qty
                                        from Goods_In_History
                                        where In_Date =  '{findDate}'";
               
                    SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                    da.Fill(ds, "GV");
                    conn.Close();
                }
                
                rpt.Parameters["SelectedDate"].Value = dtpProduction.Value;
                rpt.Parameters["SelectedDate"].Visible = false;
                rpt.DataSource = ds;
                rpt.CreateDocument();
                WorkOrderDetailView(rpt);
            
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
        private void WorkOrderDetailView(LoadingReport rep)
        {
            
            if (documentViewer1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WorkOrderDetailView);
                Invoke(d, new object[] { rep });
            }
            else
            {
                documentViewer1.DocumentSource= rep;
                documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters, new object[] { true });

            }
        }
    }
}
