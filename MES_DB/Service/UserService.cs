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
    }
}
