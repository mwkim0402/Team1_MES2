using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MoldingInfoDetailVo
    {
        public string Mold_Code { get; set; }
        public string Mold_Name { get; set; }
        public string Mold_Group { get; set; }
        public int Guar_Shot_Cnt { get; set; }
        public int Purchase_Amt { get; set; }
        public DateTime In_Date { get; set; }
        public DateTime Last_Setup_Time { get; set; }
        public string Remark { get; set; }
        public Char Use_YN { get; set; }
    }
}