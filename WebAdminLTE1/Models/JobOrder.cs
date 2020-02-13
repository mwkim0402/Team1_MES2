using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class JobOrder
    {
        public string Workorderno { get; set; }
        public string Item_Name { get; set; }
        public string Wc_Name { get; set; }
        public string Plan_Qty { get; set; }
        public string Plan_Date { get; set; }
        public string Wo_Status { get; set; }
    }
}