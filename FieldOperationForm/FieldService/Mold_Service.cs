using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Mold_Service
    {
        public List<Mold_Vo> GetYMold()
        {
            Mold_Dac dac = new Mold_Dac();
            return dac.GetYMold();
        }

        public List<Mold_Vo> GetNMold()
        {
            Mold_Dac dac = new Mold_Dac();
            return dac.GetNMold();
        }

        public List<Mold_Vo> UpdateUseMold(string Mold_Code)
        {
            Mold_Dac dac = new Mold_Dac();
            return dac.UpdateUseMold(Mold_Code);
        }

        public List<Mold_Vo> DesorptionMold(string Mold_Code)
        {
            Mold_Dac dac = new Mold_Dac();
            return dac.DesorptionMold(Mold_Code);
        }
    }
}
