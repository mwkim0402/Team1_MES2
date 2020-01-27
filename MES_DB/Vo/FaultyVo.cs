using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class FaultyMasterVo
    {
        public string Def_Ma_Code { get; set; }
        public string Def_Ma_Name { get; set;} 
        public string Use_YN { get; set; }
    }
    public class FaultyDetailVo
    {
        public string Def_Ma_Code { get; set; }
        public string Def_Mi_Code { get; set; }
        public string Def_Mi_Name { get; set; }
        public string Remark { get; set; }
        public string Use_YN { get; set; }
    }
}
