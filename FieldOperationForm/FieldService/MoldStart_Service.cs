using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class MoldStart_Service
    {
        public List<MoldStart_Vo>MoldStartHistory (MoldStart_Vo item)
        {
            MoldStart_Dac dac = new MoldStart_Dac();
            return dac.MoldStartHistory(item);
        }
        public List<MoldStart_Vo> MoldEndHistory(MoldStart_Vo item)
        {
            MoldStart_Dac dac = new MoldStart_Dac();
            return dac.MoldEndHistory(item);
        }

        public List<MoldStart_Vo> GetMoldName(string Workorderno)
        {
            MoldStart_Dac dac = new MoldStart_Dac();
            return dac.GetMoldName(Workorderno);
        }

    }
}
