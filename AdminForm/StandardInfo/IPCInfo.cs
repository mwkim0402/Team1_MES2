using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class IPCInfo : AdminForm.dgvOneWithInput
    {
        public IPCInfo()
        {
            InitializeComponent();
        }

        private void IPCInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "IPC 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "IPC 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "IP", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SPEC", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
        }
    }
}
