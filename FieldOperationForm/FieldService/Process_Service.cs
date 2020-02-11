using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Process_Service
    {

        public List<Process_Vo> GetProName()
        {
            Process_Dac dac = new Process_Dac();
            return dac.GetProName();
        }
    }
}
