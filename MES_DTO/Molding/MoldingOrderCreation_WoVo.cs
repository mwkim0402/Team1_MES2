using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DTO
{
    public class MoldingOrderCreation_WoVo
    {
        public string Wo_Status { get; set; } 
        public string Workorderno { get; set; } 
        public DateTime Prd_Date { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Wc_Name { get; set; }
        public int Plan_Qty { get; set; }
        public int In_Qty_Main { get; set; }
        public int Out_Qty_Main { get; set; }
        public int Prd_Qty { get; set; }
        public string Remark { get; set; }
    }
}
