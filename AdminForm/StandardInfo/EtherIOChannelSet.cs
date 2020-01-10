using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class EtherIOChannelSet : dgvTwoWithInput
    {
        public EtherIOChannelSet()
        {
            InitializeComponent();
        }

        private void EtherIOChannelSet_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "EtherIO 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "EtherIO 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "EtherIO IP", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비고", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "채널번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "센서위치", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "캐비티 적용유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Data Desc", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
        }
    }
}
