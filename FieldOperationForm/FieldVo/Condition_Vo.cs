using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Condition_Vo
    {
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public string Condition_Group { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
    }
    public class InspectMaster_Vo
    {
        public string Inspect_Group { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
    }
}

