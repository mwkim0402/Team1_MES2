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
    public partial class CreateWorkOrder : Form
    {
        List<WorkReqCenterVo> reqCenterList;
        List<WorkCenterVo> workCenters;
        List<WorkOrder> workOrderList;
        WorkReqVo workReq;
        string pType;
        string workOrdNo;

        public CreateWorkOrder(string processType, string WorkOrderNo)
        {
            InitializeComponent();
            pType = processType;
            workOrdNo = WorkOrderNo;
            lblProcessName.Text = pType + "계획생성";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            reqCenterList = service.GetAllWorkReqCenter(cbWorkCenter.SelectedValue.ToString());
            WorkCenterSchedule frm = new WorkCenterSchedule(cbWorkCenter.SelectedValue.ToString(), this);
            frm.ShowDialog();
        }



        private void CreateWorkOrder_Load(object sender, EventArgs e)
        {
            WorkCenterService centerService = new WorkCenterService();
            workCenters = centerService.GetAllWorkCenter().FindAll(x => x.Wc_Group == pType);
            List<ComboItem> cbItem = new List<ComboItem>();
            foreach (var item in workCenters)
            {
                ComboItem a = new ComboItem
                {
                    comboText = item.Wc_Name,
                    comboValue = item.Wc_Code
                };
                cbItem.Add(a);
            }
            ComboClass.ComboBind(cbItem, cbWorkCenter, false);

            WorkOrderService service = new WorkOrderService();
            workReq = service.GetAllWorkReq().Find(x => x.Wo_Req_No == workOrdNo);
            txtWorkReqNo.Text = workReq.Wo_Req_No;
            txtClient.Text = workReq.Cust_Name;
            txtIem.Text = workReq.Item_Name;
            nuQty.Value = workReq.Req_Qty;
            dtpEndDate.Value = workReq.Prd_Plan_Date;
            nuDefaultQty.Value = workReq.Req_Qty - service.SumWoReq(pType, workOrdNo);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            if (nuDefaultQty.Value < nuPlanQty.Value)
            {
                MessageBox.Show("잔여수량 보다 계획수량의 양이 많습니다. 다시 확인하세요.");
                return;
            }
            int count = service.GetAllWorkDetail(txtWorkReqNo.Text).FindAll(x => x.Process_name == pType).Count;

            WorkOrderInsVo insVo = new WorkOrderInsVo
            {
                Item_Name = txtIem.Text,
                Workorderno = string.Format($"{txtWorkReqNo.Text}_No{pType}{count + 1}"),
                Plan_Date = dtpPlanStart.Value.Date,
                Plan_Starttime = Convert.ToDateTime($"{dtpPlanStart.Value.ToShortDateString()} {String.Format("{0:tt HH:mm}", dtpStartTime.Value)}"),
                Plan_Endtime = Convert.ToDateTime($"{dtpPlanStart.Value.ToShortDateString()} {String.Format("{0:tt HH:mm}", dtpEndTime.Value)}"),
                Plan_Qty = Convert.ToInt32(nuPlanQty.Value),
                Wc_Code = cbWorkCenter.SelectedValue.ToString(),
                Wo_Req_No = txtWorkReqNo.Text
            };

            bool isChecked = service.InsertWorkOrder(insVo);
            if (!isChecked)
            {
                MessageBox.Show("등록에 실패하였습니다. 정보를 확인하세요.");
                return;
            }
            MessageBox.Show("등록되었습니다.");
            this.Close();
        }

        private void nuDefaultQty_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
