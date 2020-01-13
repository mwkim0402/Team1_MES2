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
    public partial class FaultyDetail : dgvTwoWithInput
    {
        public FaultyDetail()
        {
            InitializeComponent();
        }

        private void FaultyDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            tabPage3.Text = "";
            tabPage4.Text = "";
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용유무", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "정렬순번", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }
    }
}
