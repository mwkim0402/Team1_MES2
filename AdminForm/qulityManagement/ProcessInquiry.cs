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
        List<QulityInquiryVO> allList;
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
            QualityService service = new QualityService();
            allList = service.GetAllProcessInquiry();
        }

        private void GetData(object sender, EventArgs e)
        {
            if(StartDate != null && EndDate != null && fcFactory.SendCode !=null && fcWork.SendCode != null)
            {
                List<QulityInquiryVO> list = (from item in allList
                                              where item.Plan_Date >= StartDate.Date && item.Plan_Date.Date <= EndDate && item.Process_code == fcFactory.SendCode && item.Wc_Code == fcWork.SendCode
                                              select item).ToList();

                dgvSearchResult.DataSource = list;
            }
            else
            {
                MessageBox.Show("검색 조건을 모두 선택해주세요.");
            }
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정항목", "Inspect_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "USL", "USL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SL", "SL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "LSL", "LSL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일시", "Inspect_datetime", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일자", "Inspect_date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정값", "Inspect_val", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Wc_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Inspect_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Process_code", false, 100);


        }

        private void ProcessInquiry_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);

        }
        private void ProcessInquiry_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
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
