using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class ProcessInfo : AdminForm.dgvOneWithInput
    {
        public ProcessInfo()
        {
            InitializeComponent();
        }

        private void ProcessInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정그룹", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
        }
    }
}
