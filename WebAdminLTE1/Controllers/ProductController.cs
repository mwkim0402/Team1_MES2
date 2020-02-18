using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebApplication0106.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        int pageSize = 5;
        public ActionResult List(string group=null,int page = 1)
        {
            ProductDAC product = new ProductDAC();
            ProductListView model = new ProductListView
            {
                Products = product.GetList(page, pageSize, group),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = product.GetWorkCenterTotalCount(group)
                },
                CurrentCategory = group
            };

            ViewBag.WorkOrderList = model;

            
            //페이지 뷰백




            return View(model);
        }

        
        public ActionResult ProductSummary()
        {
            return View();
        }
    }
}