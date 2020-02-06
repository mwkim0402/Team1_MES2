using FieldOperationForm;
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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginService service = new LoginService();
            LoginVO loginVo = new LoginVO();
            loginVo.User_ID = Convert.ToInt32(txtID.Text);
            loginVo.User_PW = txtPwd.Text;

            List<LoginVO> list = new List<LoginVO>();
            list = service.LoginOK(loginVo);
            if(list.Count > 0)
            {
                //btnLogin.DialogResult = DialogResult.OK;
                Global.User_Name = list[0].User_Name;
                Global.User_ID = list[0].User_ID;
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
            }
        }
    }
}
