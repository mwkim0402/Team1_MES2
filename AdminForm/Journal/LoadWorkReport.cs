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
        private delegate void SafeCallDelegate(LoadingReport rep);
        MainForm frm;
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
            frm.Search_Click += this.Search_Click;
            frm.Insert_Click += this.Print_Click;
        }

        
        private void LoadWorkReport_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.Search_Click;
            frm.Insert_Click -= this.Print_Click;
        }
        public void Search_Click(object sender, EventArgs e)
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
                DataSet ds = new DataSet();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string strSql = $"select * from GV_History where Loading_Date = '{findDate}'";
               
                    SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                    da.Fill(ds, "GV");
                    conn.Close();
                }
                LoadingReport rpt = new LoadingReport();
                rpt.Parameters["SelectedDate"].Value = dtpProduction.Value;
                rpt.Parameters["SelectedDate"].Visible = false;
                rpt.DataSource = ds;
                rpt.CreateDocument();
                //Form2 frm = new Form2();
                //frm.documentViewer1.DocumentSource = rpt;
                //frm.ShowDialog();
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
            Print frm = new Print();
            frm.documentViewer1.DocumentSource = this.documentViewer1.DocumentSource;
            frm.documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters, new object[] { true });
            frm.Show();
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
