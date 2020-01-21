using MES_API.Models.Perform;
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
    public partial class ProductList : dgvOne
    {
        MainForm frm;
        
        List<ProductListVO> list; //AllList
        public ProductList()
        {
            InitializeComponent();
        }

        string StartDate;
        string EndDate;
        

        private void ProductList_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
        }

        // 상세조회
        private async Task GetValue()
        {
            PerformService service = new PerformService();


            // AllList 에서 조회해서 데이터 그리드뷰에 넣는 부분
            List<ProductListVO> list2 = (from item in list
                                         where item.Prd_Date >= Convert.ToDateTime(StartDate.Substring(0, 10)) && item.Prd_Date <= Convert.ToDateTime(EndDate.Substring(0, 10))
                                          && item.Item_Name == fcCategory.SendName
                                         select item).ToList();
            dgvSearchResult.DataSource = list2;
        }

        private async Task GetAllList()
        {
            PerformService service = new PerformService();
            list = await service.GetsListAsync<List<ProductListVO>>("ProductList", new List<ProductListVO>());
            dgvSearchResult.DataSource = list;
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "Prd_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "팔레트번호", "Pallet_No", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "입고수량", "In_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "마감시각", "Closed_Time", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "취소시각", "Cancel_Time", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "ERP 업로드여부", "Upload_Flag", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "Wo_Status", true, 100);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value.ToString();
        }
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value.ToString();
        }
        

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    await GetValue();
        //}
        public async void Search_Click(object sender, EventArgs e)
        {
            await GetAllList();
        }

        private void ProductList_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.Search_Click);
        }

        private void ProductList_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search_Click);
        }
    }
}
