using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserLoginService
    {
        public bool InsertLoginMES(int id)
        {
            UserLoginDAC dac = new UserLoginDAC();
             return dac.InsertMESLoginHis(id);
        }
        public bool InsertLoginPOP(int id)
        {
            UserLoginDAC dac = new UserLoginDAC();
            return dac.InsertPOPLoginHis(id);
        }
        public bool UpdateLogout(int id)
        {
            UserLoginDAC dac = new UserLoginDAC();
            return dac.UpdateLogoutHis(id);
        }

        public List<UserLoginVo> GetAllLoginHis()
        {
            UserLoginDAC dac = new UserLoginDAC();
            return dac.GetAllLoginHis();
        }
    }
}
