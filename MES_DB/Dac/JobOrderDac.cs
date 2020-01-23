using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MES_DB
{
    public class JobOrderDac : ConnectionAccess
    {
        public List<JobOrderCreateVo> JobOrderCreation()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "JobOrderCreation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<JobOrderCreateVo> list = Helper.DataReaderMapToList<JobOrderCreateVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<JobOrderCreateVo> JobOrderSearch(string start, string end, string process, string workplace)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "JobOrderSearch";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@startdate",start);
                cmd.Parameters.AddWithValue("@enddate",end);
                cmd.Parameters.AddWithValue("@procCode", int.Parse(process));
                cmd.Parameters.AddWithValue("@WC_Name", int.Parse(workplace));

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<JobOrderCreateVo> list = Helper.DataReaderMapToList<JobOrderCreateVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        
        public List<MoldingOrderCreation_ReqVo> MoldingOrderCreation_Req()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "MoldingOrderCreation_Req";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingOrderCreation_ReqVo> list = Helper.DataReaderMapToList<MoldingOrderCreation_ReqVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<MoldingOrderCreation_WoVo> MoldingOrderCreation_WO(string Wo_Req_No)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "JobOrderDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wo_Req_No", Wo_Req_No);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingOrderCreation_WoVo> list = Helper.DataReaderMapToList<MoldingOrderCreation_WoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public int InsertJobOrder(JobOrderCreateVo_Insert ins)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "insert into WorkOrder(Plan_Unit,Plan_Qty,Plan_Date,Item_Code,Wc_Code) values (@Plan_Unit,@Plan_Qty,@Plan_Date,@Item_Code,(select Wc_Code from WorkCenter_Master where Wc_Name = @Wc_Name)) where Workorderno = @workorderno";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Workorderno", ins.workorderno);
                cmd.Parameters.AddWithValue("@Plan_Unit", ins.plan_unit);
                cmd.Parameters.AddWithValue("@Plan_Qty", ins.plan_qty);
                cmd.Parameters.AddWithValue("@Plan_Date", ins.plan_date);
                cmd.Parameters.AddWithValue("@Item_Code", ins.item_code);
                cmd.Parameters.AddWithValue("@Wc_Name", ins.wc_name);


                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        public int UpdateJobOrder(JobOrderCreateVo_Insert ins)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update WorkOrder set Plan_Unit=@Plan_Unit,Plan_Qty=@Plan_Qty,Plan_Date=@Plan_Date,Item_Code=@Item_Code,Wc_Code =(select Wc_Code from WorkCenter_Master where Wc_Name = @Wc_Name)) where Workorderno = @workorderno";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Workorderno", ins.workorderno);
                cmd.Parameters.AddWithValue("@Plan_Unit", ins.plan_unit);
                cmd.Parameters.AddWithValue("@Plan_Qty", ins.plan_qty);
                cmd.Parameters.AddWithValue("@Plan_Date", ins.plan_date);
                cmd.Parameters.AddWithValue("@Item_Code", ins.item_code);
                cmd.Parameters.AddWithValue("@Wc_Name", ins.wc_name);


                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        public int FinishJobOrder(string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update WorkOrder set Req_Status = '작업지시마감' where Workorderno = @Workorderno";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);


                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }
        public int FinishMoldReq(string wo_Req_No, int req_seq)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "FinishMoldReq";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wo_Req_No", wo_Req_No);
                cmd.Parameters.AddWithValue("@Req_Seq", req_seq);


                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }
        public int UndoJobOrder(string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update WorkOrder set Req_Status = '현장마감' where Workorderno = @Workorderno";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);


                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
        }

        public List<MoldingOrderCreation_ReqVo> SearchMoldReq_date(DateTime start, DateTime end, string orderno, string project)
        {
            string strStart = start.ToString().Substring(0, 10);
            string strEnd = end.ToString().Substring(0, 10);

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "SearchMoldingReq";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DateStart", strStart);
                cmd.Parameters.AddWithValue("@DateEnd", strEnd);
                cmd.Parameters.AddWithValue("@OrderNo", orderno);
                cmd.Parameters.AddWithValue("@Project", project);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingOrderCreation_ReqVo> list = Helper.DataReaderMapToList<MoldingOrderCreation_ReqVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
