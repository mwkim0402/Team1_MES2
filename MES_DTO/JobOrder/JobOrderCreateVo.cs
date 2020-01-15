using System;

namespace MES_DTO 
{ 
    public class JobOrderCreateVo
    {
        public string Item_Code { get; set; } 
        public string Item_Name { get; set; } 
        public int Wc_Name { get; set; }
        public DateTime Prd_Date { get; set; }
        public DateTime Prd_Starttime{ get; set; }
        public DateTime Prd_Endtime { get; set; }
        public int In_Qty_Main{ get; set; }
        public int Out_Qty_Main{ get; set; }
        public int Prd_Qty{ get; set; }
        public string Wo_Req_No{ get; set; }
        public int Req_Seq{ get; set; }
        public string Remark{ get; set; }
    }
}
