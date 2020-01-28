using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class GVDry_Service
    {


        public List<GVDry_Vo> GVDry()
        {
            GVDry_Dac dac = new GVDry_Dac();
            return dac.GVDry();
        }
        public List<GVDry_Vo> GetGV()
        {
            GVDry_Dac dac = new GVDry_Dac();
            return dac.GetGV();
        }
    }
}
