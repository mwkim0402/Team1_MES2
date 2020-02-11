using System;

namespace MES_DB
{ 
 
    public class JobOrderCreateVo_Insert
    {
        public string item_code { get; set; }
        public string workorderno { get; set; }
        public string plan_unit { get; set; }
        public string plan_date { get; set; }
        public string wc_code { get; set; }
        public int plan_qty { get; set; }
    }
    public class WorkPlaceCB
    {
        public string Wc_code { get; set; }
        public string Wc_Name { get; set; }
    }

    public class ItemCodeCB
    {
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
    }
}
