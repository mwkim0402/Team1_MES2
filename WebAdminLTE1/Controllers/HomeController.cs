using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebAdminLTE1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //작업지시별 불량률 확인 하고 리스트로 뿌려준다.
            JobOrderDAC jobOrder = new JobOrderDAC();
            JobOrderListView jobordermodel = new JobOrderListView // 작업지시 view만들고
            {
                JobOrders = jobOrder.GetWorkOrderFive() // 진행중인 작업지시 조회
            };
            ViewBag.TopFive = jobordermodel; //작업지시 뷰백

            ProductDAC workcenter = new ProductDAC();
            ProductListView workcentermodel = new ProductListView
            {
                Products = workcenter.GetList(1, 10, null),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = 1,
                    ItemsPerPage = 10,
                    TotalItems = workcenter.GetProductTotalCount(null)
                },
                CurrentCategory = null
            };
            ViewBag.WorkOrderList = workcentermodel; // 작업장 뷰백

            OrderReqDAC woreq = new OrderReqDAC();
            WoReqListView woreqmodel = new WoReqListView
            {
                WoReqs = woreq.GetWoReqTen()
            };
            ViewBag.WoReqList = woreqmodel; // 생산의뢰 뷰백




            return View();
        }
        public ActionResult Member()
        {


            return View();
        }
    }
}