using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class Search_Service
    {
        public List<Search_Vo> SearchBarcodeDate(Search_Vo item)
        {
            Search_Dac dac = new Search_Dac();
            return dac.SearchBarcodeDate(item);
        }
    }
}
