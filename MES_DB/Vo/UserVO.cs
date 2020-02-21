using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserVO
    {}
    public class UserGroupManagerVO
    {
        public string UserGroup_Code { get; set; }
        public string UserGroup_Name { get; set; }
        public string Use_YN { get; set; }
    }
    public class UserGroupPowerSettingVO
    {
        public string UserGroup_Name { get; set; }
        public string Screen_Code { get; set; }
        public string Pre_Type { get; set; }
    }
    
    public class UserManagerVO
    {
        public string User_Name { get; set; }
        public int User_ID { get; set; }
        public string UserGroup_Code { get; set; }
        public string UserGroup_Name { get; set; }
        public string Use_YN { get; set; }
        public int Pw_Reset_Count { get; set; }
        public string Default_Process_Code { get; set; }
        public string User_Type { get; set; }
        
        
    }

    public class ItemCodeListVO
    {
        public string ProcessName { get; set; }
    }
}
