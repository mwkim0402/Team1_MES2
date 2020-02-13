using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class JobOrderListView
    {
        public IEnumerable<JobOrder> JobOrders { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}