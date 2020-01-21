using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class PerformSearchVO
    {
        public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Wc_Code { get; set; }
        public int In_Qty_Main { get; set; }
        public int Out_Qty_Main { get; set; }
        public int Prd_Qty { get; set; }
        public DateTime Plan_Date { get; set; }
    }
}
