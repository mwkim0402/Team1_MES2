using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class JobOrderService

    {
        public List<JobOrderCreateVo> JobOrderCreation()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.JobOrderCreation();
        }

        public List<JobOrderCreateVo> MoldingOrderCreation_Req()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.MoldingOrderCreation_Req();
        }
        public List<JobOrderCreateVo> MoldingOrderCreation_WO()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.MoldingOrderCreation_WO();
        }
    }
}
