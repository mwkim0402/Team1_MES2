using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using WebApplication0106.Models;

namespace WebApplication0106.DAC
{
    public class JobOrderDAC :IDisposable
    {
        string strconn = string.Empty;
        public JobOrderDAC()
        {
            strconn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;


        }
        public List<JobOrder> GetWorkOrder(int page,int pageSize)
        {
            List<JobOrder> list = new List<JobOrder>();
            string sql = "GetJobOrder"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Page_No", page);
                    cmd.Parameters.AddWithValue("@Page_Size", pageSize);

                    list = Helper.DataReaderMapToList<JobOrder>(cmd.ExecuteReader());
                }
            }
            
                return list;
        }
        public List<PrdUnit> GetUnitCount()
        {
            List<PrdUnit> list = new List<PrdUnit>();
            string sql = @"select Wc_Group,count(Plan_Qty) 생산목표량 ,count(Prd_Qty) 현재생산량 from WorkOrder w, WorkCenter_Master wc
                            where w.Wc_Code = wc.Wc_Code
                            group by Wc_Group";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    list = Helper.DataReaderMapToList<PrdUnit>(cmd.ExecuteReader());
                }
            }

            return list;
        }
        internal List<JobOrder> GetWorkOrderFive()
        {
            List<JobOrder> list = new List<JobOrder>();
            string sql = "GetJobOrderFive";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    list = Helper.DataReaderMapToList<JobOrder>(cmd.ExecuteReader());
                }
            }

            return list;
        }
        public double GetBadrate()
        {
            double iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select  (Sum(Bad_Qty)/1.0/sum(isnull(In_Qty_Main,1)) * 100) c from WorkOrder
                                where (convert(varchar(8), Prd_Starttime, 112) = convert(varchar(8), getdate(), 112))";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    iTotCount = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }

        public int GetWorkOrderTotalCount()
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = "select count(*) totCount from WorkOrder w, WorkCenter_Master wc where w.Wc_Code = wc.Wc_Code";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }

        public int GetWorkOrderTotalCount_month(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select sum(Plan_Qty) from WorkOrder w, WorkCenter_Master wc where (WC_Group = @Wc_Group or isnull(@Wc_Group,'')='')
                                and w.Wc_Code = wc.Wc_Code
								and Plan_Endtime between  DATEADD(MM, DATEDIFF(MM, 0, GETDATE()), 0)
                                and DATEADD(MS, -3, DATEADD(MM, DATEDIFF(MM, 0, GETDATE()) + 1, 0))";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Group", category);

                    int.TryParse(cmd.ExecuteScalar().ToString(), out iTotCount);
                    
                }
            }
            return iTotCount;
        }
        public int GetWorkOrderFinishCount(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select count(*) from WorkOrder w, WorkCenter_Master wc
                                where w.Wc_Code = wc.Wc_Code
                                and w.Wo_Status = '작업종료'
                                and Wc_Group = @Wc_Group";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Group", category);
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }
        public int GetWorkOrderFinishCount_today(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select count(*) from WorkOrder w, WorkCenter_Master wc
                                where w.Wc_Code = wc.Wc_Code
                                and w.Wo_Status = '작업종료'
                                and Wc_Group = @Wc_Group
                                and (convert(varchar(10), Prd_Endtime, 23))= @Today";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Group", category);
                    cmd.Parameters.AddWithValue("@Today", DateTime.Today.ToShortDateString());
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }
        public int GetWorkOrderFinishCount_month(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select sum(Prd_Qty) from WorkOrder w, WorkCenter_Master wc where (WC_Group = @Wc_Group or isnull(@Wc_Group,'')='')
                                and w.Wc_Code = wc.Wc_Code
								and Prd_Endtime between  DATEADD(MM, DATEDIFF(MM, 0, GETDATE()), 0)
                                and DATEADD(MS, -3, DATEADD(MM, DATEDIFF(MM, 0, GETDATE()) + 1, 0))";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Group", category);
                    int.TryParse(cmd.ExecuteScalar().ToString(), out iTotCount);
                }
            }
            return iTotCount;
        }
        public List<JobOrder> GetProductDetailList(string wcCode)
        {
            List<JobOrder> list = null;
            string sql = @"select w.Workorderno, i.Item_Name, wc.Wc_Name, Plan_Qty, Plan_Date, w.Wo_Status from WorkOrder w, Item_Master i, WorkCenter_Master wc 
                            Where w.Item_Code = i.Item_Code and w.Wc_Code = wc.Wc_Code
                            and w.Wc_Code = @Wc_Code"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);
                    list = Helper.DataReaderMapToList<JobOrder>(cmd.ExecuteReader());
                }
            }
            return list;
        }

        public void Dispose()
        {

        }
    }
}