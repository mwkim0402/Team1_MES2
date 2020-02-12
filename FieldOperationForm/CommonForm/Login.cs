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
       
        Main_P main;
        public Login(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            User_Service service = new User_Service();
            JobOrderStatus_Load frm; //압연
            JobOrderStatus frm1;//제선
            JobOrderStatus_Package frm2; // 포장
            JobOrderStatus_Steelmaking frm3;//제강

            if (service.UserLogin(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == 0)
            {
                MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다", "알림");
                txt_UserID.Text = "";
                txt_UserPwd.Text = "";
                txt_UserID.Focus();
                return;
            }
            else if (service.GetUserType(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == "압연")
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
                Global.User_ID =Convert.ToInt32(txt_UserID.Text);
            }

            else if (service.GetUserType(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == "제선")
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
                Global.User_ID = Convert.ToInt32(txt_UserID.Text);
            }

            else if (service.GetUserType(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim()) == "제강")
            {
                frm3 = new JobOrderStatus_Steelmaking(main);
                frm3.BringToFront();
                frm3.MdiParent = main;
                frm3.Dock = DockStyle.Fill;
                frm3.Show();
                this.Hide();
                main.lbl_name.Text = service.GetUserName(txt_UserID.Text.Trim(), txt_UserPwd.Text.Trim());
                main.label3.Text = "님";
                main.btn_NonOperation.Enabled = true;
                main.btn_logout.Enabled = true;
                main.btn_Home.Enabled = true;
                Global.User_ID = Convert.ToInt32(txt_UserID.Text);
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
                Global.User_ID = Convert.ToInt32(txt_UserID.Text);
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
