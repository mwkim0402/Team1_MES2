using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkOrderService
    {
        public List<WorkReqVo> GetAllWorkReq()
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetWorkReq();
        }
        public List<WorkReqCenterVo> GetAllWorkReqCenter(string code)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetReqCenter(code);
        }

        public List<WorkOrder> GetAllWorkDetail(string code)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetAllWorkOrderDetail(code);
        }

        public int SumWoReq(string type, string Wo_Req_No)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.WoReqSum(type, Wo_Req_No);
        }
    }
}
