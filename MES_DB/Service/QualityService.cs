using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class QualityService
    {
        public List<QulityInquiryVO> GetAllProcessInquiry()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllProcessInquiry();
        }
    }
}
