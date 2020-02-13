using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserInfoService
    {
        public UserInfoVo GetUserInfo(int userID)
        {
            UserInfoDac dac = new UserInfoDac();
            return dac.GetUserInfo(userID);
        }
    }
}
