using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class QualityService
    {
        public List<ProcessInquiryVO> GetAllProcessInquiry()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllProcessInquiry();
        }
        public List<QualityInquiryVO> GetAllQualityInquiry()
        {
            QualityDAC dac = new QualityDAC();
            return dac.GetQulityInquiryForm();
        }
        public List<ItemCodeListVO> comboItemList()
        {
            QualityDAC dac = new QualityDAC();
            return dac.comboItemList();
        }

        public void InsQuality(InsQualityVO insert)
        {
            QualityDAC dac = new QualityDAC();
            dac.InsQuality(insert);
        }
    }
}
