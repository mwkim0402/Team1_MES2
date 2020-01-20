using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ItemGroupVo
    {
        public string Level_Code { get; set; }
        public string Level_Name { get; set; }
        public string Level { get; set; }
        public int PCS_Qty { get; set; }
        public decimal Mat_Qty { get; set; }
        public string Use_YN { get; set; }
    }
}
