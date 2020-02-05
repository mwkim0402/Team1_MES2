using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class LoginVO
    {
        public string UserGroup_Code { get; set; }
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_PW { get; set; }
        public string Screen_Code { get; set; }
        public string Pre_Type { get; set; }
    }
}
