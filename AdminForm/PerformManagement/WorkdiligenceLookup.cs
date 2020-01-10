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
    public partial class WorkdiligenceLookup : dgvOne
    {
        public WorkdiligenceLookup()
        {
            InitializeComponent();
        }

        private void WorkdiligenceLookup_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "근무일", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "근무시작시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "근무종료시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "근무시간", "1", true, 100);
        }
    }
}
