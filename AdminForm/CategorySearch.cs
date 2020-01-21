using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class CategorySearch: Form
    {
        string catCode;
        string catName;
        string catTable;
        public string CatCode { get => catCode; set => catCode = value; }
        public string CatName { get => catName; set => catName = value; }
        List<FindCategoryVo> List = null;

        private void RoadList()
        {
            FindCategoryService service = new FindCategoryService();
            List = service.GetCategory(catTable);
        }

        public CategorySearch(string searchTable)
        {
            InitializeComponent();
            catTable = searchTable;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // dgv 중 선택된 코드를 catCode에 입력
            // dgv 중 선택된 카테고리명을 catName에 입력
            

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //cmb와 txtsearch명으로 데이터를 검색해 dgv에 출력
        }

        private void CategorySearch_Load(object sender, EventArgs e)
        {
            CommonClass.AddNewColumnToDataGridView(dgvList, "코드번호", "Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList, "코드명", "CodeName", true, 176);
            RoadList();
            dgvList.DataSource = List;
            dgvList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            cmbCat.Text = catTable;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            catCode = dgvList.Rows[e.RowIndex].Cells[0].Value.ToString();
            catName = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
