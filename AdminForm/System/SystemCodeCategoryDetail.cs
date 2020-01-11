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
    public partial class SystemCodeCategoryDetail : dgvTwoWithInput
    {
        public SystemCodeCategoryDetail()
        {
            InitializeComponent();
        }

        private void SystemCodeCategoryDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            tabPage2.Text = "";
            tabPage4.Text = "";
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "시스템 대분류 코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "시스템 대분류 명", "1", true, 180);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비고", "1", true, 230);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "시스템 상세분류 코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "시스템 상세분류 명", "1", true, 180);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "정렬순번", "1", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 230);
        }
    }
}
