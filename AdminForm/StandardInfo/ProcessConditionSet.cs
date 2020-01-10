using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class ProcessConditionSet : dgvTwoWithInput
    {
        public ProcessConditionSet()
        {
            InitializeComponent();
        }

        private void ProcessConditionSet_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 등급", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 명", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "설비", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SPEC", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기준값", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "샘플크기", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사기기", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격구분", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
        }
    }
}
