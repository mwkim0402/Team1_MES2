using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Condition_Service
    {

        public List<Condition_Vo> GetCondition(Condition_Vo item)
        {
            Condition_Dac dac = new Condition_Dac();
            return dac.GetCondition(item);
        }
        
    }
}
