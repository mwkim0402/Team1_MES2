using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserLoginVo
    {
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string Form_Type { get; set; }
        public string Login_Time { get; set; }
        public string Logout_Time { get; set; }
    }
}
