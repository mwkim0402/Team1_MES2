using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MoldingService

    {
        public List<MoldingInfoVo> GetMoldingInfo()
        {
            MoldingDac dac = new MoldingDac();
            return dac.GetMoldingInfo();
        }
    }
}
