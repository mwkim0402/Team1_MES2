using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApplication0106.Models;

namespace WebApplication0106
{
    public class WorkOrderContext : System.Data.Entity.DbContext
    {
        public WorkOrderContext() : base("WorkOrderContext")
        {
        }

        public System.Data.Entity.DbSet<JobOrder> List { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}