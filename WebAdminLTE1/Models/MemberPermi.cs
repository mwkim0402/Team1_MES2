using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class MemberPermi
    {
        public string Wo_Req_No { get; set; }
        public string Item_Name { get; set; }
        public int Req_Qty { get; set; }
        public DateTime Prd_Plan_Date { get; set; }
        public string Req_Status { get; set; }
    }
}