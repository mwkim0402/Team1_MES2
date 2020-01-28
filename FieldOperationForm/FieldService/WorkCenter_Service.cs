using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class WorkCenter_Service
    {
        public List<WorkCenter_Vo> GetWcName()
        {
            WorkCenter_Dac dac = new WorkCenter_Dac();
            return dac.GetWcName();
        }

    }
}
