using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserInfoVo
    {
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string Default_Process_Code { get; set; }
        public byte[] User_Image { get; set; }
        public string User_Phone { get; set; }
        public string User_Email { get; set; }
        public string UserGroup_Name { get; set; }
    }
    public class UserPlanVo
    {
        public int User_ID { get; set; }
        public int Seq { get; set; }
        public string Plan_Date { get; set; }
        public string Notice { get; set; }
        public string Title { get; set; }
    }
}
