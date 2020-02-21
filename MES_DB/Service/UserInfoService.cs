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
        public List<UserPlanVo> GetUserPlan(int userID)
        {
            UserDAC dac = new UserDAC();
            return dac.GetUserPlan(userID);
        }
        public void InsImage(UserInfoVo user)
        {
            UserInfoDac dac = new UserInfoDac();
            dac.InsImage(user);
        }
    }
}
