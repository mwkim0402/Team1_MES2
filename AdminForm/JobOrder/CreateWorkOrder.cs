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
        string pType;


        public CreateWorkOrder(string processType)
        {
            InitializeComponent();
            pType = processType;
            lblProcessName.Text = pType + "계획생성";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            reqCenterList = service.GetAllWorkReqCenter(cbWorkCenter.Text);
            WorkCenterSchedule frm = new WorkCenterSchedule(cbWorkCenter.Text);
            frm.ShowDialog();
        }
        private void CreateWorkOrder_Load(object sender, EventArgs e)
        {          
            

            // Do not circle today's date.
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

    }
}
