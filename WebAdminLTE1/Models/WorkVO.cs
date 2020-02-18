using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdminLTE1.Models
{
    public class WorkVO
    {
        public string USER_NAME { get; set; }
        public int Work_Date { get; set; }
        public decimal work_time { get; set; }
    }

    public class ProceessCodeWorkVO
    {
        public string Process_Code { get; set; }
        public decimal work_time { get; set; }
    }
}