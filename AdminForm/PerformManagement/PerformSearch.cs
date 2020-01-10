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
    public partial class PerformSearch : dgvOne
    {
        public PerformSearch()
        {
            InitializeComponent();
        }

        private void PerformSearch_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "산출수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "1", true, 100);
        }
    }
}
