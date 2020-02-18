using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class NoticeService
    {
        public List<NoticeVo> GetAllNotice()
        {
            NoticeDAC dac = new NoticeDAC();
            return dac.GetAllNotice();
        } 
    }
}
