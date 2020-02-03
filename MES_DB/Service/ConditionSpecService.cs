using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ConditionSpecService
    {
        public List<ConditionSpecVo> GetAllCond()
        {
            ConditionSpecDAC dac = new ConditionSpecDAC();
            return dac.GetConditionSpec();
        }

        public bool InsertCondSpecsMaster(ConditionSpecVo vo)
        {
            ConditionSpecDAC dac = new ConditionSpecDAC();
            return dac.InsertConditionMaster(vo);
        }
    }
}
