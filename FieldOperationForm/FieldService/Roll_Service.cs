using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class Roll_Service
    {

        public List<Roll_Vo>getRollWork()
        {
            Roll_Dac dac = new Roll_Dac();
            return dac.getRollWork();
        }
    }
}
