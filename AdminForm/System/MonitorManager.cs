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
    public partial class MonitorManager : dgvOneWithInput
    {
        public MonitorManager()
        {
            InitializeComponent();
        }

        private void MonitorManager_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면 코드", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면 경로", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "ContentDLL", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 120);
        }
    }
}
