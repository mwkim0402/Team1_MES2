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
    public partial class LoginLogInfo : dgvOne
    {
        public LoginLogInfo()
        {
            InitializeComponent();
        }

        private void LoginLogInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자IP", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SesstionID", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자PC", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로그인 일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용 일시", "1", true, 100);
        }
    }
}
