using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class Search_Vo
    {

        public string Workorderno { get; set; }
        public DateTime In_Date { get; set; }
        public string Item_Name { get; set; }
        public string Barcode_No { get; set; }
        public string Pallet_No { get; set; }
        public int Prd_Qty { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Plan_Unit { get; set; }
    }
}
