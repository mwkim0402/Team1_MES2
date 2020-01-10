using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class ItemClassInfo : dgvOne
    {
        public ItemClassInfo()
        {
            InitializeComponent();
        }

        private void ItemClassInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 1", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 2", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 3", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 4", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 5", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 6", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "P/L당 BOX 수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "BOX당 PCS 수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "PCS당 소재량", "1", true, 100);
        }
    }
}
