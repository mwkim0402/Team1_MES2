using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class InsertCon_Service
    {
        public List<InsertCon_Vo> InsertInspect(InsertCon_Vo item )
        {
            InsertCon_Dac dac = new InsertCon_Dac();
            return dac.InsertInspect(item);
        }
        public List<InsertCon_Vo> GetConditionVal(InsertCon_Vo item )
        {
            InsertCon_Dac dac = new InsertCon_Dac();
            return dac.GetConditionVal(item);
        }
    }
}
