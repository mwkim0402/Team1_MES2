using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UserAssort : AdminForm.dgvOneWithInput
    {
        public UserAssort()
        {
            InitializeComponent();
        }

        private void UserAssort_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자정의코드 대분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자정의코드 대분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
        }
    }
}
