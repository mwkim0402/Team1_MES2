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

        public int GetWorkOrderTotalCount(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = "select count(*) totCount from WorkOrder";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
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
        public JobOrder GetWorkOrderInfo(string workorderno)
        {
            List<JobOrder> list = null;
            string sql = "select w.Workorderno, i.Item_Name, wc.Wc_Name, Plan_Qty, Plan_Date,Wo_Status from WorkOrder w, Item_Master i, WorkCenter_Master wc" +
                "Where workorderno = @workorderno and w.Item_Code = i.Item_Code and w.Wc_Code = wc.Wc_Code"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@workorderno", workorderno);
                    list = Helper.DataReaderMapToList<JobOrder>(cmd.ExecuteReader());
                }
            }
            return (list == null) ? null : list[0];
        }

        public void Dispose()
        {

        }
    }
}