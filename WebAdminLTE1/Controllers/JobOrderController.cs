using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebAdminLTE1.Controllers
{
    public class JobOrderController : Controller
    {
        // GET: JobOrder
        int pageSize = 5;
        public ActionResult List(int page = 1)
        {
            //작업지시별 불량률 확인 하고 리스트로 뿌려준다.
            JobOrderDAC jobOrder = new JobOrderDAC();
            JobOrderListView model = new JobOrderListView // 작업지시 view만들고
            {
                JobOrders = jobOrder.GetWorkOrder(page, pageSize), // 진행중인 작업지시 조회
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = jobOrder.GetWorkOrderTotalCount() //전체조회
                }
            };
            ViewBag.TopFive = model;
            return View(model);
        }
        public ActionResult TimeLine()
        {
            //작업지시별 불량률 확인 하고 리스트로 뿌려준다.
            JobOrderDAC jobOrder = new JobOrderDAC();
            //시간대별 쿼리문
           
            return View();
        }


        public ActionResult JobOrderSummary()
        {
            return View();
        }
    }
}