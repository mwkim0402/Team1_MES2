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
    public partial class LoginLogInfo : dgvOne
    {
        List<UserLoginVo> loginHis = null;
        MainForm frm;
        public LoginLogInfo()
        {
            InitializeComponent();
        }

        private void LoginLogInfo_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            UserLoginService service = new UserLoginService();
            loginHis = service.GetAllLoginHis();
            dgvSearchResult.DataSource = loginHis;
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사번", "User_ID", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사원명", "User_Name", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "접속 프로그램", "Form_Type", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로그인 시간", "Login_Time", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "로그아웃 시간", "Logout_Time", true, 200);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserLoginService service = new UserLoginService();
            loginHis = service.GetAllLoginHis();
            dgvSearchResult.DataSource = loginHis;
        }
        private void LoginLogInfo_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += btnSave_Click;
        }

        private void LoginLogInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= btnSave_Click;
        }
    }
}
