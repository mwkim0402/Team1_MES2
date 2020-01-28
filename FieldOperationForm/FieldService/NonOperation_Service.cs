using FieldOperationForm.FieldVo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class NonOperation_Service
    {
        public List<NonOperation_Vo> AllNonOperation()
        {
            NonOperation_Dac dac = new NonOperation_Dac();
            return dac.AllNonOperation();
        }

        public List<NonOperation_Vo> GetMa_NameList()
        {
            NonOperation_Dac dac = new NonOperation_Dac();
            return dac.GetMa_NameList();
        }
        public List<updateNonOperation_Vo> UpdateNop(updateNonOperation_Vo item)
        {
            NonOperation_Dac dac = new NonOperation_Dac();
            return dac.UpdateNop(item);
        }

    }
}
