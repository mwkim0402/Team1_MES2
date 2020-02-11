using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MoldingInfoVo
    {
        public string Mold_Code { get; set; } 
        public string Mold_Name { get; set; } 
        public string Mold_Group { get; set; }
        public string Mold_Status { get; set; }
        public int Cum_Shot_Cnt { get; set; }
        public int Cum_Prd_Qty { get; set; }
        public Decimal Cum_Time { get; set; }
        public int Guar_Shot_Cnt { get; set; }
        public int Purchase_Amt { get; set; }
        public DateTime In_Date { get; set; }
        public DateTime Last_Setup_Time { get; set; }
        public string Remark { get; set; }
        public string Use_YN { get; set; }
    }
}
