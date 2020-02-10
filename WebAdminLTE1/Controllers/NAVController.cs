using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;

namespace WebApplication0106.Controllers
{
    public class NAVController : Controller
    {
        // GET: NAV
        public ActionResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            ProductDAC product = new ProductDAC();
            List<string> categories = product.GetProductCategory();
            return PartialView(categories);
        }
    }
}