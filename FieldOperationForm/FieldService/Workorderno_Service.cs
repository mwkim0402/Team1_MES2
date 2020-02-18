using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class Workorderno_Service
    {
        public List<Workorderno_Vo>GetWorkorderno (string Wc_Name)
        {
            Workorderno_Dac dac = new Workorderno_Dac();
            return dac.GetWorkorderno(Wc_Name);
        }

        public List<Workorderno_Vo> EndWorkorderno(string Wc_Name)
        {
            Workorderno_Dac dac = new Workorderno_Dac();
            return dac.EndWorkorderno(Wc_Name);
        }
    }
}
