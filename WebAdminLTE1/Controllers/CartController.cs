using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebApplication0106.Controllers
{
    public class CartController : Controller
    {
        List<JobOrder> JOList = new List<JobOrder>();
        // GET: Cart
        public ActionResult Index(string wc_Code)
        {
            JobOrderDAC dac = new JobOrderDAC();

            JOList = dac.GetProductDetailList(wc_Code);
            return View(JOList.ToList());
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
    } 
}