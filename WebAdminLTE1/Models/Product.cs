using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class Product
    {
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public string Wc_Group { get; set; }
        public string Process_Code { get; set; }
        public string Wo_Status { get; set; }
        public int Plan_Qty { get; set; }
        public int Prd_Qty { get; set; }
    }
}