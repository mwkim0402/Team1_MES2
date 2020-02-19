using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class GoodHistory_Service
    {

        public List<GoodHistory_Vo>UpdateGoodsHistory (GoodHistory_Vo item)
        {
            GoodHistory_Dac dac = new GoodHistory_Dac();
            return dac.UpdateGoodsHistory(item);
        }
        public List<GoodHistory_Vo> GetGoodHistory(   )
        {
            GoodHistory_Dac dac = new GoodHistory_Dac();
            return dac.GetGoodHistory( );
        }
    }
}
