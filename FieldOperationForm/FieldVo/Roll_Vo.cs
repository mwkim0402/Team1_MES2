using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class Roll_Vo
    {
        public string Mold_Name { get; set; }
        public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public string Plan_Unit { get; set; }
        public int Plan_Qty { get; set; }

        public DateTime Plan_date { get; set; }

        public string Plan_Starttime { get; set; }
        public string Prd_Starttime { get; set; }
        public string Prd_Endtime { get; set; }


    }
}
