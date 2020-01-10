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
    public partial class NonOperationDetail : dgvTwoWithInput
    {
        public NonOperationDetail()
        {
            InitializeComponent();
        }

        private void NonOperationDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비가동 대분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비가동 대분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용유무", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 상세분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 상세분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "정렬순번", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }
    }
}
