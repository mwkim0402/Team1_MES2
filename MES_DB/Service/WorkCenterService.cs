using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkCenterService
    {
        public List<WorkCenterVo> GetAllWorkCenter()
        {
            WorkCenterDAC dac = new WorkCenterDAC();
            return dac.GetAllWorkCenter();
        }

        public bool InsertWorkCenter(WorkCenterVo item)
        {
            WorkCenterDAC dac = new WorkCenterDAC();
            return dac.InsertWorkCenter(item);
        }
    }
}
