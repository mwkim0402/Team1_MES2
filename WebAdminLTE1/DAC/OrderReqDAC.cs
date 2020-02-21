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
    public class OrderReqDAC : IDisposable
    {
        string strconn = string.Empty;
        public OrderReqDAC()
        {
            strconn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;


        }
        public List<WoReq> GetWoReqTen()
        {
            List<WoReq> list = new List<WoReq>();
            string sql = "select top 10 Wo_Req_No,Item_Name,Req_Qty,Prd_Plan_Date,Req_Status from Wo_Req wr, Item_Master i "+
                " where wr.Item_Code = i.Item_Code"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    list = Helper.DataReaderMapToList<WoReq>(cmd.ExecuteReader());
                }
            }
            
                return list;
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
        public int GetReqTotalCount()
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select count(*) from Wo_Req where Req_Status = '의뢰접수'";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }

        public int GetReqTotalCount_Today()
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = @"select count(*) from Wo_Req where Req_Status = '의뢰접수' and convert(nvarchar(10), Ins_Date,23) = convert(nvarchar(10), getdate(),23)";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }


        public void Dispose()
        {

        }
    }
}