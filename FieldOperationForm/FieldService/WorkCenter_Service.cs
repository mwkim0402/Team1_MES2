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
        public List<WorkCenter_Vo> GetWorkCenter(string Wc_Group)
        {
            WorkCenter_Dac dac = new WorkCenter_Dac();
            return dac.GetWorkCenter(Wc_Group);
        }
        public List<WorkCenter_Vo> IronWorkCenter()
        {
            WorkCenter_Dac dac = new WorkCenter_Dac();
            return dac.IronWorkCenter();
        }
    }
}
