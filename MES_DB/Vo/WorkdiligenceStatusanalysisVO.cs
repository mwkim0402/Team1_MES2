using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB.Vo
{
    public class WorkdiligenceStatusanalysisVO
    {
        public DateTime Work_Date { get; set; } 
        public string Workorderno { get; set; }
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public DateTime Allocation_datetime { get; set; }
        public DateTime Release_datetime { get; set; }
        //public decimal Work_Time { get; set; }
        public int Prd_Qty { get; set; }
        public string User_ID { get; set; }
    }
}
