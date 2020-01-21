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
        public PerformSearch()
        {
            InitializeComponent();
        }

        private void PerformSearch_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
        }

        // 날짜만 가지고 있는 데이터 나누기 , 날짜 , 작업장, 공정 나누기 , 실적 보정 , 실적 나누기 버튼
        private void GetData(object sender,EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            List<PerformSearchVO> list = service.GetAllPerformSearch();
            

            dgvSearchResult.DataSource = list;
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
        }

        private void PerformSearch_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }

        private void PerformSearch_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }
    }
}
