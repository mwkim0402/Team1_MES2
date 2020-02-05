using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class LoginService
    {
        public List<LoginVO> LoginOK(LoginVO login)
        {
            LoginDAC dac = new LoginDAC();
            return dac.LoginOK(login);
        }
    }
}
