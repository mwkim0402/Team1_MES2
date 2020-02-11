using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class RegProcess : Form
    {
        MainForm frm;
        List<RegProcessVO> allList;
        DateTime StartDate;
        DateTime EndDate;
        public RegProcess()
        {
            InitializeComponent();
        }

        private void RegProcess_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void GetData(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllRegProcess(StartDate,EndDate);
            dgvJob.DataSource = allList;
        }
        private void ShowDgv()
        {

            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "Workorderno", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Process_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Inspect_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Inspect_name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Inspect_Val", false, 100);


            CommonClass.AddNewColumnToDataGridView(dgvList, "측정항목", "Inspect_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList, "기준값", "SL", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvListDetail, "측정값", "Inspect_Val", true, 100);
            
        }

        private void RegProcess_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void RegProcess_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (fcFactory.SendCode != null && fcWork.SendCode != null)
            //{
            //    List<RegProcessVO> list = (from item in allList
            //                               where item.Process_code == fcFactory.SendCode && item.Wc_Name == fcWork.SendName
            //                               select item).ToList();
            //    dgvJob.DataSource = list;
            //}
            if ((fcWork.SendCode != null && fcWork.SendName != "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
            {
                List<RegProcessVO> list = (from item in allList
                                               where item.Process_code == fcFactory.SendCode && item.Wc_Name == fcWork.SendName
                                               select item).ToList();
                dgvJob.DataSource = list;
            }
            else if ((fcWork.SendCode != null && fcWork.SendCode != "") && (fcFactory.SendCode == null || fcFactory.SendCode == ""))
            {
                List<RegProcessVO> list = (from item in allList
                                               where item.Wc_Name == fcWork.SendName
                                           select item).ToList();
                dgvJob.DataSource = list;
            }
            else if ((fcWork.SendCode == null || fcWork.SendCode == "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
            {
                List<RegProcessVO> list = (from item in allList
                                               where item.Process_code == fcFactory.SendCode
                                               select item).ToList();
                dgvJob.DataSource = list;
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_TabStopChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void dgvJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<RegProcessListVO> list = (from item in allList
                                           select new RegProcessListVO
                                           {
                                               Inspect_name = item.Inspect_name,
                                               SL = item.SL
                                           }).ToList();
            dgvList.DataSource = list;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<RegProcessListMeaVO> list = (from item in allList
                                           select new RegProcessListMeaVO
                                           {
                                               Inspect_Val = item.Inspect_Val
                                           }).ToList();
            dgvListDetail.DataSource = list;
        }
    }
}
