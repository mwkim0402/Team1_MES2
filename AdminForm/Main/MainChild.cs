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
    public partial class MainChild : Form
    {
        MainForm frm;
        UserCalendar workCalendar;
        public MainChild()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainChild_Load(object sender, EventArgs e)
        {
            DateTime[] planDate = { Convert.ToDateTime("2020-02-10"), Convert.ToDateTime("2020-02-13") };
            workCalendar = new UserCalendar(planDate);
            workCalendar.Location = new Point(9, 26);
            groupBox1.Controls.Add(workCalendar);

            frm = (MainForm)this.MdiParent;
        }

        private void MainChild_Activated(object sender, EventArgs e)
        {
            frm.lblLocation.Text = "위치정보 : Home";
        }
    }
}
