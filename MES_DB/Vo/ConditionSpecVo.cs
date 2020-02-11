using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ConditionSpecVo
    {
        public string Item_Code { get; set; }
        public string Wc_Code { get; set; }
        public string Condition_Code { get; set; }
        public string Condition_Name { get; set; }
        public string Spec_Desc { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
        public string Condition_Unit { get; set; }
        public string Condition_Group { get; set; }
        public string Use_YN { get; set; }
        public string Remark { get; set; }
    }
}
