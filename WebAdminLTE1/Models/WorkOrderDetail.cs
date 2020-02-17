using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class WorkOrderDetail
    {
        public JobOrder Joborder { get; set; }
        public string ReturnUrl { get; set; }

    }
}