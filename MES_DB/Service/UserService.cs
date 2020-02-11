using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserService
    {
        public List<UserGroupManagerVO> UserGroupManagerForm()
        {
            UserDAC dac = new UserDAC();
            return dac.UserGroupManagerForm();
        }

        public void InsUserGroupManagerForm(UserGroupManagerVO user)
        {
            UserDAC dac = new UserDAC();
            dac.InsUserGroupManagerForm(user);
        }

        public void UpdateUserGroupManagerForm(UserGroupManagerVO user)
        {
            UserDAC dac = new UserDAC();
            dac.UpdateUserGroupManagerForm(user);
        }

        public List<UserGroupPowerSettingVO> GetAllUserGroupPowerSettingForm()
        {
            UserDAC dac = new UserDAC();
            return dac.GetAllUserGroupPowerSettingForm();
        }

        public List<UserManagerVO> GetAllUserManager()
        {
            UserDAC dac = new UserDAC();
            return dac.GetAllUserManager();
        }
        public void InsUserManager(UserManagerVO user)
        {
            UserDAC dac = new UserDAC();
            dac.InsUserManager(user);
        }

        public void UpdateUserManager(UserManagerVO user)
        {
            UserDAC dac = new UserDAC();
            dac.UpdateUserManager(user);
        }
    }
}
