using MES_DB;
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
        MainForm frm;
        List<UserGroupManagerVO> allList;
        public UserGroupManger()
        {
            InitializeComponent();
        }

        private void UserGroupManger_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
        }
        private void GetData(object sender, EventArgs e)
        {
            MES_DB.UserService service = new MES_DB.UserService();
            allList = service.UserGroupManagerForm();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "UserGroup_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "UserGroup_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 100);
        }

        private void UserGroupManger_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }

        private void UserGroupManger_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //txtUserCodeInput
        }
    }
}
