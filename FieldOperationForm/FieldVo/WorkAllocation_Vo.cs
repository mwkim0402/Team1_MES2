using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class WorkAllocation_Vo
    {
        public string Wc_Code { get; set; }
        public string User_ID { get; set; }
        public DateTime Allocation_datetime { get; set; }
        public DateTime Release_datetime { get; set; }
        public string User_Name { get; set; }
        public string Wc_Name { get; set; }
        public string Wc_Group { get; set; }
        public string Process_Code { get; set; }
    }
}
