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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //JobOrderStatus_Package frm = new JobOrderStatus_Package(this);
            // JobOrderStatus frm = new JobOrderStatus(this);
            JobOrderStatus_Load frm = new JobOrderStatus_Load(this);
            frm.BringToFront();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
         
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
    }
}
