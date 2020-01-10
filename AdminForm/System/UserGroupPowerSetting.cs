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
    public partial class UserGroupPowerSetting : dgvOne
    {
        public UserGroupPowerSetting()
        {
            InitializeComponent();
        }

        private void UserGroupPowerSetting_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "메뉴 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "모듈권한", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "조회권한", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "추가권한", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "편집권한", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "삭제권한", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "전체권한", "1", true, 100);
        }
    }
}
