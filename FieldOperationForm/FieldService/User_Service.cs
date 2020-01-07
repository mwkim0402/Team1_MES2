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
    }
}
