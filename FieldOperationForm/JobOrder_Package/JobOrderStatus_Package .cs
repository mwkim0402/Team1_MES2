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
    public partial class JobOrderStatus_Package : Form
    {
        Main_P main;

        public JobOrderStatus_Package(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }

        private void JobOrderStatus_Package_Load(object sender, EventArgs e)
        {
            main.lblChange.Text = "작업지시 현황";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            workerAllocation frm = new workerAllocation(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업자할당";
        }
    }
}
