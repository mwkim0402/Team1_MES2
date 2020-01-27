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
    public partial class FaultyDetail : Form
    {
        List<FaultyMasterVo> faultyMasterList;
        MainForm frm;
        public FaultyDetail()
        {
            InitializeComponent();
        }

        private void FaultyDetail_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();

        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 코드", "Def_Ma_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 명", "Def_Ma_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용유무", "Use_YN", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 명", "1", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "정렬순번", "1", true, 50);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }

        private void btnSearch(object sender, EventArgs e)
        {
            FaultyService service = new FaultyService();
            faultyMasterList = service.GetAllFaultyMaster();
            dgvSelect.DataSource = faultyMasterList;
        }

        private void FaultyDetail_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += btnSearch;
        }

        private void FaultyDetail_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= btnSearch;
        }
    }
}
