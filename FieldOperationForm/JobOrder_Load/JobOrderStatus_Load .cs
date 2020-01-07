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
    public partial class JobOrderStatus_Load : Form
    {
        Main_P main;

        public JobOrderStatus_Load(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }

        private void JobOrderStatus_Load_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "적재";
            main.lblChange.Text = "작업지시 현황";
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void btn_Process_Click(object sender, EventArgs e)
        {
            ProcessCondition frm = new ProcessCondition(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "공정조건 등록";
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

        private void btn_JobOrder_Click(object sender, EventArgs e)
        {
         
            LoadJobOrder frm = new LoadJobOrder(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "적재 작업지시 생성";
        }

        private void btn_LoadPerformance_Click(object sender, EventArgs e)
        {
            LoadPerformance frm = new LoadPerformance(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "적재 실적 등록";
        }

        private void btn_frame_Click(object sender, EventArgs e)
        {
            Frame frm = new Frame(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "요입 / 요출 관리";
        }

        private void btn_EmptyDriedTruck_Click(object sender, EventArgs e)
        {
            EmptyTruck frm = new EmptyTruck(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "건조대차 비우기";
        }
    }
}
