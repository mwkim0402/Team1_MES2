using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WoReqService
    {
        public List<Wo_Req> GetAllWoReq()
        {
            WoReqDAC dac = new WoReqDAC();
            return dac.GetAllWoReq();
        }
        public bool InsertWoReq(Wo_Req vo)
        {
            WoReqDAC dac = new WoReqDAC();
            return dac.InsertWoReq(vo);
        }
    }
}
