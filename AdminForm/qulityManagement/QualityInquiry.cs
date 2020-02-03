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
    public partial class QualityInquiry : AdminForm.dgvOne
    {
        MainForm frm;
        List<QualityInquiryVO> allList;
        DateTime StartDate;
        DateTime EndDate;
        public QualityInquiry()
        {
            InitializeComponent();
        }

        private void QualityInquiry_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            QualityService service = new QualityService();
            allList =service.GetAllQualityInquiry();
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }
        private void GetData(object sender, EventArgs e)
        {
            dgvSearchResult.DataSource = allList;
        }
        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정항목", "Inspect_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "USL", "USL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SL", "SL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "LSL", "LSL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일시", "Inspect_datetime", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상세품목코드", "Inspect_code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상세품목명", "Inspect_name", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정회차", "Inspect_date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정순번", "Inspect_measure_seq", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정값", "Inspect_val", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Wc_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Process_Code", false, 100);

        }

        private void QualityInquiry_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void QualityInquiry_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(fcWork.SendCode != null && fcFactory.SendCode != null)
            {
                List<QualityInquiryVO> list = (from item in allList
                                               where item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date && item.Process_code == fcFactory.SendCode && item.Wc_Code == fcWork.SendCode
                                               select item).ToList();
                dgvSearchResult.DataSource = list;
            }
            else
            {
                MessageBox.Show("검색조건을 모두 선택해주세요.");
            }
            //dtpStart.CustomFormat.Substring(0, 10);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }
    }
}
