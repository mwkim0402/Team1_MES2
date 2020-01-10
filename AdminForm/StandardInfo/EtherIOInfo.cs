using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class EtherIOInfo : dgvOneWithInput
    {
        public EtherIOInfo()
        {
            InitializeComponent();
        }

        private void EtherIOInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "EtherIO 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "EtherIO 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "EtherIO IP", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }
    }
}
