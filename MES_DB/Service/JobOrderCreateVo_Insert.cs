using System;

namespace MES_DB
{ 
 
    public class JobOrderCreateVo_Insert
    {
        public string item_code { get; set; }
        public string workorderno { get; set; }
        public string plan_unit { get; set; }
        public string plan_date { get; set; }
        public string wc_name { get; set; }
        public int plan_qty { get; set; }


    }
}
