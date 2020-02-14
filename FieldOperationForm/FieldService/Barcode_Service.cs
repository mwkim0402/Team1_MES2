using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class Barcode_Service
    {
        public List<Barcode_Vo> GetBarcode(string Workorderno)
        {
            Barcode_Dac dac = new Barcode_Dac();
            return dac.GetBarcode(Workorderno);
        }
    }
}
