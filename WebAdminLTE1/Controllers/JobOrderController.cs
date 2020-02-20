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

            ViewBag.TimeLine = jobOrder.GetTimeLine_Out();
            ViewBag.TimeLine_Bad = jobOrder.GetTimeLine_Bad();
            //시간대별 쿼리문



            ViewBag.TodayTotalCountJK = jobOrder.GetWorkCenterTotalCount_today("제강");
            ViewBag.TodayTotalCountJS = jobOrder.GetWorkCenterTotalCount_today("제선");
            ViewBag.TodayTotalCountAY = jobOrder.GetWorkCenterTotalCount_today("압연");
            ViewBag.TodayTotalCountJJ = jobOrder.GetWorkCenterTotalCount_today("적재");
            ViewBag.TodayTotalCountPJ = jobOrder.GetWorkCenterTotalCount_today("포장");

            ViewBag.TodayFinishCountJK = jobOrder.GetWorkCenterFinishCount_today("제강");
            ViewBag.TodayFinishCountJS = jobOrder.GetWorkCenterFinishCount_today("제선");
            ViewBag.TodayFinishCountAY = jobOrder.GetWorkCenterFinishCount_today("압연");
            ViewBag.TodayFinishCountJJ = jobOrder.GetWorkCenterFinishCount_today("적재");
            ViewBag.TodayFinishCountPJ = jobOrder.GetWorkCenterFinishCount_today("포장");


            return View();
        }


        public ActionResult JobOrderSummary()
        {
            return View();
        }
    }
}