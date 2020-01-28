using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ProcessService
    {
        public bool InsertProcess (ProcessVo proVo)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.InsertProcess(proVo);
        }
        public List<ProcessVo> GetAllProcess()
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.GetAllProcess();
        }
        public bool UpdateProcess(ProcessVo proVo)
        {
            ProcessDAC dac = new ProcessDAC();
            return dac.UpdateProcess(proVo);
        }
    }
}
