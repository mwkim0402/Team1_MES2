using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class PrdUnitListView
    {
        public List<PrdUnit> PrdUnits { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}