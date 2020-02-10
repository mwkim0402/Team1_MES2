using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class GVInfoService
    {
        public bool InsertGVInfo(GvInfoVo vo)
        {
            GVInfoDAC dac = new GVInfoDAC();
            return dac.InsertGVInfo(vo);
        }
        public List<GvInfoVo> GetAllGVInfo()
        {
            GVInfoDAC dac = new GVInfoDAC();
            return dac.GetAllGVInfo();
        }
    }
}
