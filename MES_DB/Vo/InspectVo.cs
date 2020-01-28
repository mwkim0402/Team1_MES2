using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class InspectVo
    {
        public string Item_Code { get; set; }
        public string Process_Code { get; set; }
        public string Inspect_Code { get; set; }
        public string Inspect_Name { get; set; }
        public string Spec_Desc { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
        public int Sample_Size { get; set; }
        public string Inspect_Unit { get; set; }
        public string Use_YN { get; set; }
        public string Remark { get; set; }

    }
}
