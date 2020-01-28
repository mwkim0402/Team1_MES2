using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ConditionSpecService
    {
        public List<ConditionSpecVo> GetAllInspect()
        {
            ConditionSpecDAC dac = new ConditionSpecDAC();
            return dac.GetConditionSpec();
        }

        public bool InsertInspectMaster(ConditionSpecVo vo)
        {
            ConditionSpecDAC dac = new ConditionSpecDAC();
            return dac.InsertConditionMaster(vo);
        }
    }
}
