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
    public partial class LogOut : Form
    {
        Main_P main;
 
        public LogOut(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login(main);
            
           frm.MdiParent = main;
           frm.BringToFront();

            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "로그인";
            main.btn_NonOperation.Enabled = false;
            main.btn_logout.Enabled = false;
            main.btn_Home.Enabled = false;

        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
