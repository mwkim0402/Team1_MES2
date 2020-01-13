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
    public partial class UserManager : dgvOneWithInput
    {
        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 이름", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 ID", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "IP보안 적용유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "패스워드 초기화 횟수", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기본 공정", "1", true, 100);
        }
    }
}
