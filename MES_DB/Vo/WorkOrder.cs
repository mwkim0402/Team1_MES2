using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkOrder
    {
        public DateTime stratTime;
        public DateTime endTime;
        public string Workorderno { get; set; }
        public string Process_name { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public DateTime Plan_Date { get; set; }
        public string Plan_Starttime { get; set; }
        public string Plan_Endtime { get; set; }
        public int Plan_Qty { get; set; }
        public string Wo_Status { get; set; }
    }
    public class WorkReqVo
    {
        public string Wo_Req_No { get; set; }
        public int Req_Seq { get; set; }
        public string Item_Name { get; set; }
        public int Req_Qty { get; set; }
        public DateTime Prd_Plan_Date { get; set; }
        public string Cust_Name { get; set; }
        public string Sale_Emp { get; set; }
        public string Req_Status { get; set; }
    }
    public class WorkReqCenterVo
    {
        public string Workorderno { get; set; }
        public DateTime Plan_Date { get; set; }
        public DateTime Plan_Starttime { get; set; }
        public DateTime Plan_Endtime { get; set; }
        public string Wo_Status { get; set; }
    }
}
