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

 

        private void btn_Quality_Click(object sender, EventArgs e)
        {
            QualityMeasurement frm = new QualityMeasurement(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "품질 측정값 등록";
        }

        private void btn_Worker_Click(object sender, EventArgs e)
        {
            workerAllocation frm = new workerAllocation(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업자할당";
        }

        private void btn_JobOrder_Click(object sender, EventArgs e)
        {
            JobOrder frm = new JobOrder(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업지시 생성";
        }

        private void btn_CreatePalette_Click(object sender, EventArgs e)
        {
            CreatePalette frm = new CreatePalette(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "팔레트 생성";
        }

        private void btn_BarCode_Click(object sender, EventArgs e)
        {
            PaletteBarCode frm = new PaletteBarCode(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "팔레트 바코드 재발행";
        }

        private void btn_warehousing_Click(object sender, EventArgs e)
        {
            warehousing frm = new warehousing(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "포장 입고 등록";
        }

        private void btn_Unloading_Click(object sender, EventArgs e)
        {
            Unloading frm = new Unloading(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "포장 언로딩";
        }
    }
}
