using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class ItemInfo : Form
    {
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문명 약어", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목유형", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "캐비티", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "이론 생산량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "횟수당 생산량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 1", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 2", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 3", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 4", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 5", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 6", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "한줄당PCS수", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "한Shot당 PCS수", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "건조대차 기본 수량 ", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "소성대차 기본 수량 ", "1", true, 100);
        }
    }
}
