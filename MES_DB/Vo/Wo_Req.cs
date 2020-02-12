using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class Wo_Req
    {
        public string Wo_Req_No { get; set; }
        public int Req_Seq { get; set; }
        public string Item_Code { get; set; }
        public int Req_Qty { get; set; }
        public DateTime Ins_Date { get; set; }
        public DateTime Prd_Plan_Date { get; set; }
        public string Cust_Name {get; set;}
        public string Project_Name { get; set; }

    }
}
