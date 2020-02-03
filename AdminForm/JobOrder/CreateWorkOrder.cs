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
            WorkCenterSchedule frm = new WorkCenterSchedule(cbWorkCenter.SelectedValue.ToString());
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
            txtWorkOrderNo.Text = workReq.Wo_Req_No;
            txtClient.Text = workReq.Cust_Name;
            txtIem.Text = workReq.Item_Name;
            nuQty.Value = workReq.Req_Qty;
            dtpEndDate.Value = workReq.Prd_Plan_Date;
            nuDefaultQty.Value = workReq.Req_Qty-service.SumWoReq(pType, workOrdNo);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
