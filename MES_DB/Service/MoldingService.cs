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

        public List<MoldingInfoVo> SearchMoldingInfo(string code, string name, string group)
        {
            MoldingDac dac = new MoldingDac();
            return dac.SearchMoldingInfo(code,name,group);
        }
        public int SaveMoldingInfo(string code, string name, string group, string price, string inputdate, string lastequipdate, string warrentnum, string Ps, int isUse)
        {
            MoldingDac dac = new MoldingDac();
            return dac.SaveMoldingInfo(code, name, group,price,inputdate,lastequipdate,warrentnum,Ps,isUse);
        }
        public List<MoldUseHistoryVo> MoldUseHistory()
        {
            MoldingDac dac = new MoldingDac();
            return dac.MoldUseHistory();
        }

        public List<MoldUseHistoryVo> SearchMoldUse(string start, string end, string item, string workplace)
        {
            MoldingDac dac = new MoldingDac();
            return dac.SearchMoldUse(start,end,item,workplace);
        }

        public List<MoldingInfoDetailVo> GetMoldingInfoDetail(string moldcode)
        {
            MoldingDac dac = new MoldingDac();
            return dac.GetMoldingInfoDetail(moldcode);
        }

        public int UpdateMoldingInfo(MoldingInfoDetailVo detail)
        {
            MoldingDac dac = new MoldingDac();
            return dac.UpdateMoldingInfo(detail);
        }
    }
}
