using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MES_API.Models.Perform
{
    public class ProductListVO
    {
        public DateTime Prd_Date { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Pallet_No { get; set; }
        public int In_Qty { get; set; }
        public DateTime Closed_Time { get; set; }
        public DateTime Cancel_Time { get; set; }
        public string Upload_Flag { get; set; }
        public string Workorderno { get; set; }
        public string Wo_Status { get; set; }
    }
}