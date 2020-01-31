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
        List<WorkReqCenterVo> reqCenterList;
        string workCenter;
        public WorkCenterSchedule(string WorkCenter)
        {
            InitializeComponent();
            workCenter = WorkCenter;
        }

        private void WorkCenterSchedule_Load(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            reqCenterList = service.GetAllWorkReqCenter(workCenter);
            string[] planDate = (from item in reqCenterList
                                 where DateTime.Now.Month == item.Plan_Date.Month
                                 select item.Plan_Date.ToString("dd")).ToArray();
            UserCalendar workCalendar = new UserCalendar(planDate, workCenter);
            workCalendar.Location = new Point(6, 41);
            this.Controls.Add(workCalendar);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "생산의뢰번호", "Workorderbo", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획날짜", "Plan_Date", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획 시작시간", "Plan_Starttime", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "계획 마감시간", "Plan_Endtime", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvCenter, "작업 상태", "Wo_Status", true, 110);

        }
    }
}
