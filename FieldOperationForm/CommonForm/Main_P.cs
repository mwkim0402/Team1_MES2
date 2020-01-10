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
            btn_home1.Enabled = false;
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
            Notice frm = new Notice();
            frm.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            JobOrderStatus_Load frm; //적재
            JobOrderStatus frm1;//성형
            JobOrderStatus_Package frm2; // 포장

            if (lbl_Job.Text == "적재")
            {
                frm = new JobOrderStatus_Load(this);
                frm.BringToFront();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else if (lbl_Job.Text == "성형")
            {
                frm1 = new JobOrderStatus(this);
                frm1.BringToFront();
                frm1.MdiParent = this;
                frm1.Dock = DockStyle.Fill;
                frm1.Show();
            }
            else
            {
                frm2 = new JobOrderStatus_Package(this);
                frm2.BringToFront();
                frm2.MdiParent = this;
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }
        }
    }
}
