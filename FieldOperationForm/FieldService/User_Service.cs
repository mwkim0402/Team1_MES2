using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FieldOperationForm
{
    public class User_Service
    {
        public List<User_Vo> GetCustomerCode()
        {
            User_Dac dac = new User_Dac();
            return dac.GetCustomerCode();
        }
        public int UserLogin(string User_ID, string User_PW)
        {
            User_Dac dac = new User_Dac();
            return dac.UserLogin(User_ID, User_PW);
        }
        public string GetUserType(string User_ID, string User_PW)
        {
            User_Dac dac = new User_Dac();
            return dac.GetUserType(User_ID, User_PW);
        }

        public string GetUserName(string User_ID, string User_PW)
        {
            User_Dac dac = new User_Dac();
            return dac.GetUserName(User_ID, User_PW);
        }
    }
}
