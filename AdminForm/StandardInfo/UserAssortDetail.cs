using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UserAssortDetail : dgvTwoWithInput
    {
        public UserAssortDetail()
        {
            InitializeComponent();
        }

        private void UserAssortDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();

        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용자정의코드 대분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용자정의코드 대분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용자정의코드 대분류 비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용자정의코드 대분류 사용유무", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자정의코드 상세분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자정의코드 상세분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "정렬순번", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }
    }
}
