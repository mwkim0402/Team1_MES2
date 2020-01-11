using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class QualityInquiry : AdminForm.dgvOne
    {
        public QualityInquiry()
        {
            InitializeComponent();
        }

        private void QualityInquiry_Load(object sender, EventArgs e)
        {
            ShowDgv();

        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정항목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "USL", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SL", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "LSL", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상세품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상세품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정회차", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정순번", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "측정값", "1", true, 100);
        }
    }
}
