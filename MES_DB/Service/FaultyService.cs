using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class FaultyService
    {
        public List<FaultyMasterVo> GetAllFaultyMaster()
        {
            FaultyDAC dac = new FaultyDAC();
            return dac.GetAllFaultyMaster();
        }
        public bool InsertFaultyMaster(FaultyMasterVo list)
        {
            FaultyDAC dac = new FaultyDAC();
            return dac.InsertFaultyMaster(list);
        }
        public bool UpdateFaultyMaster(FaultyMasterVo fMaster)
        {
            FaultyDAC dac = new FaultyDAC();
            return dac.UpdateFaultyMaster(fMaster);
        }
    }
}
