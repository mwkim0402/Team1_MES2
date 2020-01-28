using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class JobOrderService

    {
        public List<WorkPlaceCB> GetWorkPlaceCombo()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.GetWorkPlaceCombo();
        }
        public List<ItemCodeCB> GetItemCodeCombo()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.GetItemCodeCombo();
        }

        public List<JobOrderCreateVo> JobOrderCreation()
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.JobOrderCreation();
        }

        //검색 빈칸은 무시하고 오버로딩을 통한 다른 프로시져 제공
        public List<JobOrderCreateVo> JobOrderSearch(string start, string end,string process,string workplace)
        {
            
            JobOrderDac dac = new JobOrderDac();
            return dac.JobOrderSearch(start, end, process, workplace);
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
            return dac.FinishMoldReq(wo_Req_No, req_seq);
        }
        public int FinishJobOrder(string Workorderno)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.FinishJobOrder(Workorderno);
        }
        public int UndoJobOrder(string Workorderno)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.UndoJobOrder(Workorderno);
        }
        public List<MoldingOrderCreation_ReqVo> SearchMoldReq_date(DateTime start, DateTime end,string orderno,string project)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.SearchMoldReq_date(start, end,orderno,project);
        }

        public int InsertJobOrder(JobOrderCreateVo_Insert ins)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.InsertJobOrder(ins);
        }
        public int UpdateJobOrder(JobOrderCreateVo_Insert ins)
        {
            JobOrderDac dac = new JobOrderDac();
            return dac.UpdateJobOrder(ins);
        }
    }
}
