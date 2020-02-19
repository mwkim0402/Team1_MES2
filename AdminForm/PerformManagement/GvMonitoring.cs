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

namespace AdminForm
{
    public partial class GVMonitoring : Form
    {
        MainForm frm;
        List<WorkCenterVO> Alllist;
        public GVMonitoring()
        {
            InitializeComponent();
        }

        private void GvMonitoring_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
        }

        private void GetDate(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            Alllist = service.GetAllWorkCenter();

            List<WorkCenterVO> RunList = (from item in Alllist
                                          where item.Wo_Status == "RUN"
                                          select item).ToList();
            dgvRun.DataSource = RunList;


            List<WorkCenterVO> NoRunList = (from norun in Alllist
                                            where norun.Wo_Status == "STOP"
                                            select norun).ToList();

            dgvNoRun.DataSource = NoRunList;

        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvRun, "작업장 코드", "Wc_Code", true, 140);
            CommonClass.AddNewColumnToDataGridView(dgvRun, "작업장 이름", "Wc_Name", true, 140);
            CommonClass.AddNewColumnToDataGridView(dgvRun, "작업장 그룹명", "Wc_Group", true, 170);
            CommonClass.AddNewColumnToDataGridView(dgvRun, "작업장 상태", "Wo_Status", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvRun, "최근 시작시간", "Prd_Starttime", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvRun, "최근 멈춘시간", "Prd_Endtime", false, 150);

            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "작업장 코드", "Wc_Code", true, 140);
            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "작업장 이름", "Wc_Name", true, 140);
            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "작업장 그룹명", "Wc_Group", true, 170);
            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "작업장 상태", "Wo_Status", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "최근 시작시간", "Prd_Starttime", false, 150);
            CommonClass.AddNewColumnToDataGridView(dgvNoRun, "최근 멈춘시간", "Prd_Endtime", true, 150);

        }

        private void GVMonitoring_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetDate);
            
        }

        private void GVMonitoring_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetDate);
            
            
        }
    }
}
