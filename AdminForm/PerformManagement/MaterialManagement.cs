using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class MaterialManagement : dgvOne
    {
        public MaterialManagement()
        {
            InitializeComponent();
        }

        private void MaterialManagement_Load(object sender, EventArgs e)
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산년도", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "레벨코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "레벨명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "차수", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "원자재 LOT 번호", "1", true, 100);
        }
    }
}
