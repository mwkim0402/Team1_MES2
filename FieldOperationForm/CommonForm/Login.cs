using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FieldOperationForm
{
    public partial class Login : Form
    {
        string strconn;
        Main_P main;
        public Login(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            User_Service service = new User_Service();
            JobOrderStatus_Load frm; //적재
            JobOrderStatus frm1;//성형
            JobOrderStatus_Package frm2; // 포장

           
            

            if (service.UserLogin(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == 0)
            {
                MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다", "알림");
                txt_UserID.Text = "";
                txt_UserPwd.Text = "";
                txt_UserID.Focus();
                return;
            }
            else if (service.GetUserType(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == "적재")
            {

                frm = new JobOrderStatus_Load(main);
                frm.BringToFront();
                frm.MdiParent = main;
                frm.Dock = DockStyle.Fill;
                frm.Show();
                this.Hide();
                main.lbl_name.Text = service.GetUserName(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim());
                main.label3.Text = "님";
                main.btn_NonOperation.Enabled = true;
                main.btn_logout.Enabled = true;
                main.btn_Home.Enabled = true;
            }

            else if (service.GetUserType(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == "성형")
            {
                frm1 = new JobOrderStatus(main);
                frm1.BringToFront();
                frm1.MdiParent = main;
                frm1.Dock = DockStyle.Fill;
                frm1.Show();
                this.Hide();
                main.lbl_name.Text = service.GetUserName(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim());
                main.label3.Text = "님";
                main.btn_NonOperation.Enabled = true;
                main. btn_logout.Enabled = true;
                main.btn_Home.Enabled = true;
            }

            else
            {
                frm2 = new JobOrderStatus_Package(main);
                frm2.BringToFront();
                frm2.MdiParent = main;
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
                this.Hide();
                main.lbl_name.Text = service.GetUserName(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim());
                main.label3.Text = "님";
                main.btn_NonOperation.Enabled = true;
                main.btn_logout.Enabled = true;
                main.btn_Home.Enabled = true;
            }




        }

        private void Login_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "";
            main.lbl_name.Text = "";
            main.label3.Text = "";
        }
    }
}
