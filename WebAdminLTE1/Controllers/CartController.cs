using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebApplication0106.Controllers
{
    public class CartController : Controller
    {
        private WorkOrderContext db = new WorkOrderContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(db.List.ToList());
        }


        public JobOrder GetJobOrder()
        {
            JobOrder order = (JobOrder)Session["JobOrder"];
            if (order == null)
            {
                order = new JobOrder();
                Session["JobOrder"] = order;
            }
            return order;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    } 
}