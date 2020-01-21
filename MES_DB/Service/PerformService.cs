
using MES_DB.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class PerformService
    {
        public List<WorkdiligenceStatusanalysisVO> GetAllWorkStatus()
        {
            PerformDAC dac = new PerformDAC();
            return dac.AllWorkStatuseList();
        }
        public List<PerformSearchVO> GetAllPerformSearch()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllPerformSearch();
        }
    }
}
