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
    public partial class GVLookup : dgvOne
    {
        public GVLookup()
        {
            InitializeComponent();
        }

        private void GVLookup_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로딩일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로딩수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로딩시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로딩작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "요입시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "중간시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "요출시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "언로딩일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "언로딩일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "언로딩시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "언로딩작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대상대차", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차비우기 일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차비우기 일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차비우기수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차비우기원인", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대상작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대상작업장품목", "1", true, 100);

        }
    }
}
