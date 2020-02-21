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
       // public string Plan_Unit { get; set; }
        public int Plan_Qty { get; set; }

        public DateTime Plan_Date { get; set; }

        public string Plan_Starttime { get; set; }
        public string Prd_Starttime { get; set; }
        public string Prd_Endtime { get; set; }



    }
}
