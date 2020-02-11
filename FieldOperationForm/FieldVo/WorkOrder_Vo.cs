using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class WorkOrder_Vo
    {
     public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public string Prd_Unit { get; set; }
        public int Plan_Qty { get; set; }
        public int Prd_Qty { get; set; }
     
        public DateTime Prd_Starttime { get; set; }
        public DateTime Prd_Endtime { get; set; }
            


    }
}
