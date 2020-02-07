using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class NonOperationMaService
    {
        public bool InsertNonOperationMa(NonOperationVO vo)
        {
            NonOperationDAC dac = new NonOperationDAC();
            return dac.InsertNonOperationMa(vo);
        }
        public List<NonOperationVO> GettNonOperationMa()
        {
            NonOperationDAC dac = new NonOperationDAC();
            return dac.GetAllNonOpMa();
        }
    }

}
