using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MenuTreeVo
    {
        public string Parent_Screen_Code { get; set; } 
        public string Screen_Code { get; set; } 
        public int Sort_index { get; set; }
    }
}
