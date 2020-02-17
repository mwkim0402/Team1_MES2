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

            ViewBag.FinishmonthWOJS = jobOrder.GetWorkOrderFinishCount_month("제선");
            ViewBag.FinishmonthWOJK = jobOrder.GetWorkOrderFinishCount_month("제강");
            ViewBag.FinishmonthWOAY = jobOrder.GetWorkOrderFinishCount_month("압연");
            ViewBag.FinishmonthWOJJ = jobOrder.GetWorkOrderFinishCount_month("적재");
            ViewBag.FinishmonthWOPJ = jobOrder.GetWorkOrderFinishCount_month("포장");
            //작업완료 뷰백
            ViewBag.FinishWOJS = jobOrder.GetWorkOrderFinishCount("제선");
            ViewBag.FinishWOJK = jobOrder.GetWorkOrderFinishCount("제강");
            ViewBag.FinishWOAY = jobOrder.GetWorkOrderFinishCount("압연");
            ViewBag.FinishWOJJ = jobOrder.GetWorkOrderFinishCount("적재");
            ViewBag.FinishWOPJ = jobOrder.GetWorkOrderFinishCount("포장");
            //누적작업완료 뷰백

            ViewBag.TopFive = jobordermodel; //작업지시 뷰백

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


            return View();
        }
        public ActionResult Member()
        {
            WorkDAC dac = new WorkDAC();
            List<WorkVO> AllList = dac.GetAllWork();

            StringBuilder sb = new StringBuilder();

            List<string> Name = (from it in AllList
                                 select it.USER_NAME).ToList();

            List<string> UserName = new List<string>();
            string data1 = string.Empty;
            string data2 = string.Empty;
            for (int i = 1; i < 32; i++)
            {
                sb.Append(i + "일,");
            }

            for (int t = 0; t < Name.Count; t++)
            {
                UserName.Add(Name[0]);
                var previous = Name[0];
                if (previous == Name[t])
                {
                    continue;
                }
                else
                {
                    UserName.Add("," + Name[t]);
                }
            }


            string labels = sb.ToString().TrimEnd(',');
            //data1 = "[" + string.Join(",", qtys.ToArray()) + "]";


            //ViewBag.Labels = labels;
            //ViewBag.Label1 = Name[0];
            //ViewBag.data1 = data1;
            //ViewBag.Label2 = Name[1];
            //ViewBag.data2 = data2;
            return View();
        }
    }
}