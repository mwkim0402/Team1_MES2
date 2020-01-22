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
    public partial class PerformSearch : dgvOne
    {
        MainForm frm;
        string StartDate;
        string EndDate;
        List<PerformSearchVO> list;
        public PerformSearch()
        {
            InitializeComponent();
        }

        // 실적 보정 , 실적 나누기 버튼
        private void PerformSearch_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            MES_DB.PerformService service = new MES_DB.PerformService();
            list = service.GetAllPerformSearch();
        }


        private void GetData(object sender, EventArgs e)
        {
            if (StartDate == null && EndDate == null && fcFactory.SendName == null && fcWork.SendName == null)
            {
                dgvSearchResult.DataSource = list;
            }
            else
            {
                List<PerformSearchVO> SelectList = (from item in list
                                                    where item.Plan_Date >= Convert.ToDateTime(StartDate.Substring(0, 10)) && item.Plan_Date <= Convert.ToDateTime(EndDate.Substring(0, 10))
                                                    && item.Process_code == fcFactory.SendCode && item.Wc_Code == fcWork.SendCode
                                                    select item).ToList();
                dgvSearchResult.DataSource = SelectList;
            }
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "Wo_Status", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "In_Qty_Main", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "산출수량", "Out_Qty_Main", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Prd_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Plan_Date", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Process_code", false, 100);
        }

        private void PerformSearch_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }
        private void PerformSearch_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value.ToString();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value.ToString();
        }
    }
}
