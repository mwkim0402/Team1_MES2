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
        
        public string SendName { get; set; }
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
                SendName = list[0].User_Name;
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
            }
        }
    }
}
