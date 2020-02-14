using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdminLTE1.Models
{
    public class WorkVO
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public DateTime Work_Date { get; set; }
        public decimal work_time { get; set; }
    }
}