using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MoldingOrderCreation_ReqVo
    {
        public string Wo_Req_No { get; set; } 
        public int Req_Seq { get; set; } 
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int Req_Qty { get; set; }
        public string Prd_Unit { get; set; }
        public DateTime Prd_Plan_Date { get; set; }
        public string Remark { get; set; }
        public string Cust_Name { get; set; }
        public string Sale_Emp { get; set; }
        public string Req_Status { get; set; }
        public int Out_Qty_Main { get; set; }
        public int Prd_Qty { get; set; }
        public int Plan_Qty { get; set; }
    }
}
