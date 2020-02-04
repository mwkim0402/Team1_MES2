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
    public partial class WorkCenterSchedule : Form
    {
        CreateWorkOrder frm;
        UserCalendar workCalendar;
        List<WorkReqCenterVo> reqCenterList;
        string workCenter;
        public WorkCenterSchedule(string WorkCenter, CreateWorkOrder form)
        {
            InitializeComponent();
            workCenter = WorkCenter;
            frm = form;
        }

        private void WorkCenterSchedule_Load(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            reqCenterList = service.GetAllWorkReqCenter(workCenter);
            DateTime[] planDate = (from item in reqCenterList
                                   select item.Plan_Date).ToArray();
            workCalendar = new UserCalendar(planDate, workCenter);
            workCalendar.Search_Click += btnSearch;
            workCalendar.Location = new Point(6, 41);
            this.Controls.Add(workCalendar);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "생산의뢰번호", "Workorderno", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획날짜", "Plan_Date", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획 시작시간", "Plan_Starttime", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획 마감시간", "Plan_Endtime", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "작업 상태", "Wo_Status", true, 110);

        }
        private void btnSearch(object sender, EventArgs e)
        {
            List<WorkReqCenterVo> bindList = (from item in reqCenterList
                                              where item.Plan_Date.Date == Convert.ToDateTime($"{workCalendar.lblYear.Text.Split('년')[0]}-{workCalendar.lblMonth.Text}-{workCalendar.lblDate.Text}")
                                              select item).ToList();
            dgvCenter.DataSource = bindList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime($"{dtpPlanDate.Value.ToShortDateString()} {String.Format("{0:tt HH:mm}", dtpStartTime.Value)}");
            DateTime endTime = Convert.ToDateTime($"{dtpPlanDate.Value.ToShortDateString()} {String.Format("{0:tt HH:mm}", dtpEndTime.Value)}");
            foreach (WorkReqCenterVo item in reqCenterList)
            {

                if ((item.Plan_Starttime < startTime && item.Plan_Endtime > startTime) || (item.Plan_Starttime < endTime && item.Plan_Endtime > endTime))
                {
                    MessageBox.Show("계획한 시간에 예정된 작업이 있습니다. 다시 확인해주세요.");
                    return;
                }
            }
            frm.dtpPlanStart.Value = frm.dtpPlanEnd.Value = dtpPlanDate.Value.Date;
            frm.dtpStartTime.Value = dtpStartTime.Value;
            frm.dtpEndTime.Value = dtpEndTime.Value;
        }
    }
}
