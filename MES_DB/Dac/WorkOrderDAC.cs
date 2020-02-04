using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkOrderDAC : ConnectionAccess
    {
        public List<WorkReqVo> GetWorkReq()
        {
            List<WorkReqVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Wo_Req_No, Req_Seq, Item_Name, Req_Qty, Prd_Plan_Date, Cust_Name, Sale_Emp, Req_Status
                                                from Wo_Req wo inner join Item_Master i on wo.Item_Code = i.Item_Code ";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<WorkReqVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public List<WorkReqCenterVo> GetReqCenter(string wcCode)
        {
            List<WorkReqCenterVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Workorderno, Plan_Date, Plan_Starttime, Plan_Endtime, Wo_Status
                                                from WorkOrder
                                                where Wc_Code = @Wc_Code";
                cmd.Parameters.AddWithValue("@WC_Code", wcCode);
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<WorkReqCenterVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertWorkOrder(WorkOrderInsVo vo)
        {
            int checkNum = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsertWorkOrderDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", vo.Workorderno);
                cmd.Parameters.AddWithValue("@Wc_Code", vo.Wc_Code);
                cmd.Parameters.AddWithValue("@item_Name", vo.Item_Name);
                cmd.Parameters.AddWithValue("@Plan_Date", vo.Plan_Date);
                cmd.Parameters.AddWithValue("@Plan_Starttime", vo.Plan_Starttime);
                cmd.Parameters.AddWithValue("@Plan_Endtime", vo.Plan_Endtime);
                cmd.Parameters.AddWithValue("@Plan_Qty", vo.Plan_Qty);
                cmd.Parameters.AddWithValue("@Wo_Req_No", vo.Wo_Req_No);
                cmd.Connection.Open();
                checkNum = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return checkNum==1?true:false;
        }
        public List<WorkOrder> GetAllWorkOrderDetail(string work_reqNo)
        {
            List<WorkOrder> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllWorkOrderDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wo_Req_No", work_reqNo);
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<WorkOrder>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public int WoReqSum(string Type, string Wo_Req_No)
        {
            int sum = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select sum(plan_qty)
                                                from WorkOrder wo inner join WorkCenter_Master wc on wo.Wc_Code = wc.Wc_Code
                                                inner join Process_Master p on wc.Process_Code = p.Process_code
                                                inner join Item_Master i on wo.Item_Code = i.Item_Code
                                                where wo.Wo_Status <> '작업종료'
                                                and Process_Group = @Type
                                                and Wo_Req_No = @Wo_Req_No";
              
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Wo_Req_No", Wo_Req_No);
                cmd.Connection.Open();

                if (cmd.ExecuteScalar() != DBNull.Value)
                {
                    sum = Convert.ToInt32(cmd.ExecuteScalar());
                }
                cmd.Connection.Close();
            }
            return sum;
        }
    }
}
