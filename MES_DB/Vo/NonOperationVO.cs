using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class NonOperationVO
    {
        public string Nop_Ma_Code { get; set; }
        public string Nop_Ma_Name { get; set; }
        public string Use_YN { get; set; }
    }
    public class NonOpMiVo
    {
        public string Nop_Mi_Code { get; set; }
        public string Nop_Mi_Name { get; set; }
        public string Nop_Ma_Code { get; set; }
        public string Remark { get; set; }
        public string Use_YN { get; set; }
    }
}
