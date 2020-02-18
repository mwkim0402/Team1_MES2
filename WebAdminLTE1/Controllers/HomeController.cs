using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAdminLTE1.DAC;
using WebAdminLTE1.Models;
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


            PrdUnitListView prdUnitmodel = new PrdUnitListView // 작업지시 view만들고
            {
                PrdUnits = jobOrder.GetUnitCount() // 진행중인 작업지시 조회
            };

            ViewBag.TotalmonthWOJS = jobOrder.GetWorkOrderTotalCount_month("제선");
            ViewBag.TotalmonthWOJK = jobOrder.GetWorkOrderTotalCount_month("제강");
            ViewBag.TotalmonthWOAY = jobOrder.GetWorkOrderTotalCount_month("압연");
            ViewBag.TotalmonthWOJJ = jobOrder.GetWorkOrderTotalCount_month("적재");
            ViewBag.TotalmonthWOPJ = jobOrder.GetWorkOrderTotalCount_month("포장");
            //이번달 전체작업지시 뷰백

            ViewBag.FinishmonthWOJS = jobOrder.GetWorkOrderFinishCount_month("제선");
            ViewBag.FinishmonthWOJK = jobOrder.GetWorkOrderFinishCount_month("제강");
            ViewBag.FinishmonthWOAY = jobOrder.GetWorkOrderFinishCount_month("압연");
            ViewBag.FinishmonthWOJJ = jobOrder.GetWorkOrderFinishCount_month("적재");
            ViewBag.FinishmonthWOPJ = jobOrder.GetWorkOrderFinishCount_month("포장");
            //이번달 작업완료 뷰백

            ViewBag.FinishtodayWOJS = jobOrder.GetWorkOrderFinishCount_today("제선");
            ViewBag.FinishtodayWOJK = jobOrder.GetWorkOrderFinishCount_today("제강");
            ViewBag.FinishtodayWOAY = jobOrder.GetWorkOrderFinishCount_today("압연");
            ViewBag.FinishtodayWOJJ = jobOrder.GetWorkOrderFinishCount_today("적재");
            ViewBag.FinishtodayWOPJ = jobOrder.GetWorkOrderFinishCount_today("포장");
            //금일작업완료 뷰백
            ViewBag.FinishWOJS = jobOrder.GetWorkOrderFinishCount("제선");
            ViewBag.FinishWOJK = jobOrder.GetWorkOrderFinishCount("제강");
            ViewBag.FinishWOAY = jobOrder.GetWorkOrderFinishCount("압연");
            ViewBag.FinishWOJJ = jobOrder.GetWorkOrderFinishCount("적재");
            ViewBag.FinishWOPJ = jobOrder.GetWorkOrderFinishCount("포장");
            //누적작업완료 뷰백
            
            ViewBag.TopFive = jobordermodel; 
            //작업지시 뷰백

            ProductDAC workcenter = new ProductDAC();
            ProductListView workcentermodel = new ProductListView
            {
                Products = workcenter.GetList(1, 10, null),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = 1,
                    ItemsPerPage = 10,
                    TotalItems = workcenter.GetWorkCenterTotalCount(null)
                },
                CurrentCategory = null
            };
            ViewBag.TotalWCJS = workcenter.GetWorkCenterTotalCount("제선");
            ViewBag.TotalWCJK = workcenter.GetWorkCenterTotalCount("제강");
            ViewBag.TotalWCAY = workcenter.GetWorkCenterTotalCount("압연");
            ViewBag.TotalWCJJ = workcenter.GetWorkCenterTotalCount("적재");
            ViewBag.TotalWCPJ = workcenter.GetWorkCenterTotalCount("포장");
            //전체 작업장수 뷰백
            ViewBag.StoppingWCJS = workcenter.GetWorkCenterCountStop("제선");
            ViewBag.StoppingWCJK = workcenter.GetWorkCenterCountStop("제강");
            ViewBag.StoppingWCAY = workcenter.GetWorkCenterCountStop("압연");
            ViewBag.StoppingWCJJ = workcenter.GetWorkCenterCountStop("적재");
            ViewBag.StoppingWCPJ = workcenter.GetWorkCenterCountStop("포장");
            //멈춘 작업장수 뷰백
            ViewBag.WorkOrderList = workcentermodel; // 작업장 뷰백

            OrderReqDAC woreq = new OrderReqDAC();
            WoReqListView woreqmodel = new WoReqListView
            {
                WoReqs = woreq.GetWoReqTen()
            };
            ViewBag.WoReqList = woreqmodel; // 생산의뢰 뷰백
            ViewBag.WoReqCount = woreq.GetReqTotalCount(); //누적 생산의뢰 뷰백
            ViewBag.WoReqCountToday = woreq.GetReqTotalCount_Today(); //금일 생산의뢰 뷰백


            MemberDAC memcnt = new MemberDAC();
            MemcntListView memcntmodel = new MemcntListView
            {
                Members = memcnt.GetWorkerCount()
            };

            ViewBag.memcnt = memcntmodel; 
            //직책별 카운트 뷰백
            ViewBag.gn1 = memcntmodel.Members[0].UserGroup_Name;
            ViewBag.gn1cnt = memcntmodel.Members[0].UserCnt;
            ViewBag.gn2 = memcntmodel.Members[1].UserGroup_Name;
            ViewBag.gn2cnt = memcntmodel.Members[1].UserCnt;
            ViewBag.gn3 = memcntmodel.Members[2].UserGroup_Name;
            ViewBag.gn3cnt = memcntmodel.Members[2].UserCnt;
            //직책별 차트데이터 뷰백
            ViewBag.WorkTimeAVG = memcnt.GetWorkTimeAVG();

            return View();
        }


        public ActionResult Member()
        {
            //Bar chart 일을 많이한 사원 데이터 뽑기
            WorkDAC dac = new WorkDAC();
            List<WorkVO> AllList = new List<WorkVO>();
            AllList = dac.GetAllWork();

            StringBuilder sb = new StringBuilder();
            List<string> Name = new List<string>();
            Name = (from it in AllList
                    select it.USER_NAME).ToList();

            List<int> time = new List<int>();
            time = (from a in AllList
                    select  Convert.ToInt32(a.work_time)).ToList();
            string data1 = string.Empty;

            for (int t =0; t<time.Count; t++)
            {
                data1 +=  Name[t]+"," +time[t] +","; 
            }
            data1 = data1.TrimEnd(',');           
            ViewBag.data1 = data1;


            // Pie chart
            List<ProceessCodeWorkVO> pieList = new List<ProceessCodeWorkVO>();
            pieList = dac.GetProcessList();

            List<string> process = new List<string>();
            process = (from b in pieList
                       select b.Process_Code).ToList();


            List<int> ProcessTime = new List<int>();
            ProcessTime = (from p_time in pieList
                    select Convert.ToInt32(p_time.work_time)).ToList();


            string data2 = string.Empty;
            string PCode = string.Empty;

            for(int i=0; i<ProcessTime.Count; i++)
            {
                data2 += ProcessTime[i].ToString() +",";
            }
            for(int q=0; q<process.Count; q++)
            {
                PCode += process[q] + ",";
            }

            data2 = data2.TrimEnd(',');
            PCode = PCode.TrimEnd(',');
            ViewBag.data2 = data2;
            ViewBag.PCode = PCode;



            //Bar chart 매달마다 일 많이 한 인원



            return View();
        }
    }
}