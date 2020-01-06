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

        private void button1_Click(object sender, EventArgs e)
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
            
            Application.Exit();
        }
    }
}
