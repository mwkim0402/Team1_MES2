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
    }
}
