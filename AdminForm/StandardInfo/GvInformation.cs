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
    public partial class GvInformation : dgvOneWithInput
    {
        public GvInformation()
        {
            InitializeComponent();
        }

        private void GvInformation_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차그룹", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차상태", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
        }
    }
}
