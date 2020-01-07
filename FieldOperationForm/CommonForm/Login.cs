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
            //JobOrderStatus frm = new JobOrderStatus(main);
            JobOrderStatus_Load frm = new JobOrderStatus_Load(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
   
            main.lbl_name.Text = "김지은";
            main.label3.Text = "님";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobOrderStatus frm = new JobOrderStatus(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobOrderStatus_Load frm = new JobOrderStatus_Load(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JobOrderStatus_Package frm = new JobOrderStatus_Package(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "";
            main.lbl_name.Text = "";
            main.label3.Text = "";
        }
    }
}
