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

        public List<MoldingOrderCreation_ReqVo> MoldingOrderCreation_Req()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.MoldingOrderCreation_Req();
        }
        public List<MoldingOrderCreation_WoVo> MoldingOrderCreation_WO(string Wo_Req_No)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.MoldingOrderCreation_WO(Wo_Req_No);
        }

        public int FinishMoldReq(string wo_Req_No, int req_seq)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.FinishMoldReq(wo_Req_No,req_seq);
        }
    }
}
