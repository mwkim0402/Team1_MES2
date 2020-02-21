using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class ProcessInquiry : dgvOne
    {
        MainForm frm;
        List<ProcessInquiryVO> allList;
        DateTime StartDate;
        DateTime EndDate;
        public ProcessInquiry()
        {
            InitializeComponent();
        }

        private void ProcessInquiry_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void GetData(object sender, EventArgs e)
        {
            QualityService service = new QualityService();
            allList = service.GetAllProcessInquiry();
            dgvSearchResult.DataSource = allList;
        }
        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일", "Plan_Date", true, 100, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정항목", "Condition_Name", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "USL", "USL", true, 100, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SL", "SL", true, 100, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "LSL", "LSL", true, 100, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일시", "Condition_Date", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일자", "Condition_Datetime", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정값", "Condition_Val", true, 100, DataGridViewContentAlignment.MiddleRight);

        }

        private void ProcessInquiry_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }
        private void ProcessInquiry_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (allList != null)
            {
                if (fcFactory.SendCode != null && fcWork.SendCode != null)
                {
                    List<ProcessInquiryVO> list = (from item in allList
                                                   where item.Process_name == fcFactory.SendName && item.Wc_Name == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                                   select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
                else if (fcFactory.SendCode != null && fcWork.SendCode == null)
                {
                    List<ProcessInquiryVO> list = (from item in allList
                                                   where item.Process_name == fcFactory.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                                   select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
                else if (fcFactory.SendCode == null && fcWork.SendCode != null)
                {
                    List<ProcessInquiryVO> list = (from item in allList
                                                   where item.Wc_Name == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                                   select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
            }
        }
    }
}
