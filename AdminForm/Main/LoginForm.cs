﻿using FieldOperationForm;
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
            btnLogin.DialogResult = DialogResult.OK;
            LoginService service = new LoginService();
            UserLoginService loginService = new UserLoginService();
            LoginVO loginVo = new LoginVO();
            loginVo.User_ID = Convert.ToInt32(txtID.Text);
            loginVo.User_PW = txtPwd.Text;

            List<LoginVO> list = new List<LoginVO>();
            list = service.LoginOK(loginVo);
            if (list.Count > 0)
            {
                //btnLogin.DialogResult = DialogResult.OK;
                Global.LoginID = list[0].User_ID;
                Global.Authority = list[0].Pre_Type;
                MainForm frm = new MainForm(this);
                loginService.InsertLoginMES(Global.LoginID);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.");
                btnLogin.DialogResult = DialogResult.Cancel;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + @"\image\logotest.png");
            btnLogin.Image = new Bitmap(Application.StartupPath + @"\image\Login.png");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
