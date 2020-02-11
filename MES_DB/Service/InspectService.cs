using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class InspectService
    {
        public List<InspectVo> GetAllInspect()
        {
            InspectDAC dac = new InspectDAC();
            return dac.GetInspectMaster();
        }

        public bool InsertInspectMaster(InspectVo vo)
        {
            InspectDAC dac = new InspectDAC();
            return dac.InsertInspectMaster(vo);
        }
    }
}
