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
        DateTime StartDate;
        DateTime EndDate;
        List<MES_DB.ProductListVO> allList; //AllList


        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void GetAllList(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetProductListform();
            dgvSearchResult.DataSource = allList;
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "Prd_Date", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "팔레트번호", "Pallet_No", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "입고수량", "In_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "마감시각", "Closed_Time", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "취소시각", "Cancel_Time", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "ERP 업로드여부", "Upload_Flag", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "Wo_Status", true, 150);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void ProductList_ActivatedAsync(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetAllList);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void ProductList_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetAllList);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (allList != null)
            {
                // AllList 에서 조회해서 데이터 그리드뷰에 넣는 부분
                List<MES_DB.ProductListVO> list = (from item in allList
                                                   where item.Item_Name == fcCategory.SendName && item.Prd_Date >= StartDate.Date && item.Prd_Date <= EndDate.Date
                                                   select item).ToList();
                if (list.Count > 0)
                    dgvSearchResult.DataSource = list;
            }

        }
    }
}
