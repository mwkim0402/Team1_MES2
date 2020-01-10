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
    public partial class UserGroupManger :dgvOneWithInput
    {
        public UserGroupManger()
        {
            InitializeComponent();
        }

        private void UserGroupManger_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
        }
    }
}
