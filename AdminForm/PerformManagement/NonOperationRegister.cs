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
    public partial class NonOperationRegister : dgvOne
    {
        public NonOperationRegister()
        {
            InitializeComponent();
        }

        private void NonOperationRegister_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동대분류", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동상세분류", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동발생시각", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동종료시각", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "발생유형", "1", true, 100);
        }
    }
}
