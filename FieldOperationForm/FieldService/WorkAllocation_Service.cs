using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public  class WorkAllocation_Service
    {
        public List<WorkAllocation_Vo> GetWorkerList(string Wc_Name)
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.GetWorkerList(Wc_Name);
        }

    }
}
