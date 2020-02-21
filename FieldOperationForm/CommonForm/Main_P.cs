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

namespace FieldOperationForm
{
    public partial class Main_P : Form
    {

        bool TagMove;
        int MValX, MValY;
        public Main_P()
        {
            InitializeComponent();
          
        }

        private void FieldmanagementP_Load(object sender, EventArgs e)
        {
            
            Login frm = new Login(this);
            frm.MdiParent = this;
            
            frm.BringToFront();
          
            frm.Dock = DockStyle.Fill;
            frm.Show();
            lblChange.Text = "로그인";

            btn_NonOperation.Enabled = false;
            btn_logout.Enabled = false;
            btn_Home.Enabled = false;
        }



        private void btn_FormClose_Click(object sender, EventArgs e)
        {

            End frm = new End();
            frm.Show();
        }

        private void btn_NonOperation_Click(object sender, EventArgs e)
        {
            NonOperation frm = new NonOperation(this);
            frm.MdiParent = this;
            frm.BringToFront();
           
            frm.Dock = DockStyle.Fill;
            frm.Show();
           lblChange.Text = "비가동 등록";
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogOut frm = new LogOut(this);
            frm.Show();
            //Login frm = new Login(this);
            //frm.MdiParent = this;
            //frm.BringToFront();

            //frm.Dock = DockStyle.Fill;
            //frm.Show();
            //lblChange.Text = "로그인";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbl_Notice.Left < this.Width)
            {
                lbl_Notice.Left = lbl_Notice.Left + 5;
            }
            else
            {
                lbl_Notice.Left = 0;
            }
        }

        private void lbl_Notice_Click(object sender, EventArgs e)
        {

            Notice frm = new Notice(this);
            frm.Show();
            lbl_Notice.Enabled = false;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            JobOrderStatus_Load frm; //압연
            JobOrderStatus frm1;//제선
            JobOrderStatus_Package frm2; // 포장
            JobOrderStatus_Steelmaking frm3; //제강

            if (lbl_Job.Text == "압연")
            {
                frm = new JobOrderStatus_Load(this);
                frm.BringToFront();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else if (lbl_Job.Text == "제선")
            {
                frm1 = new JobOrderStatus(this);
                frm1.BringToFront();
                frm1.MdiParent = this;
                frm1.Dock = DockStyle.Fill;
                frm1.Show();
            }
            else if(lbl_Job.Text=="포장")
            {
                frm2 = new JobOrderStatus_Package(this);
                frm2.BringToFront();
                frm2.MdiParent = this;
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }
            else if (lbl_Job.Text == "제강")
            {
                frm3 = new JobOrderStatus_Steelmaking(this);
                frm3.BringToFront();
                frm3.MdiParent = this;
                frm3.Dock = DockStyle.Fill;
                frm3.Show();
            }
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
               MValY = e.Y;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if(TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //JobOrderStatus_Steelmaking frm = new JobOrderStatus_Steelmaking(this);
            //frm.btn_FieldClose.Location = new Point(100, 100);
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void Main_P_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserLoginService loginService = new UserLoginService();
            loginService.UpdateLogout(Global.User_ID);
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
    }
}
