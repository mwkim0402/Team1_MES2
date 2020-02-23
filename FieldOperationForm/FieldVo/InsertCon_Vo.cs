using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class InsertCon_Vo
    {
        public string Item_Name { get; set; }
        public string Wc_Name { get; set; }
        public decimal Condition_Val { get; set; }
        public string Workorderno { get; set; }
        public string Condition_Group { get; set; }
     
        public DateTime Condition_Datetime { get; set; }
    }
    public class InspectHisVo
    {
        public string Inspect_Group { get; set; }
        public decimal Inspect_Val { get; set; }
        public DateTime Inspect_Datetime { get; set; }
    }
}
