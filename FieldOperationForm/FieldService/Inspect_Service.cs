using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Inspect_Service
    {

        public List<Inspect_Vo> InsertInspect(Inspect_Vo item)
        {
            Inspect_Dac dac = new Inspect_Dac();
            return dac.InsertInspect(item);
        }
        public List<Inspect_Vo> deleteVal(Inspect_Vo item)
        {
            Inspect_Dac dac = new Inspect_Dac();
            return dac.deleteVal(item);
        }
        public List<Inspect_Vo> GetVal(Inspect_Vo Item)
        {
            Inspect_Dac dac = new Inspect_Dac();
            return dac.GetVal(Item);
        }
    }
}
