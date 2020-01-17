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
                cmd.CommandText = "JobOrderCreation";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wo_Req_No", Wo_Req_No);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingOrderCreation_WoVo> list = Helper.DataReaderMapToList<MoldingOrderCreation_WoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public int FinishMoldReq(string wo_Req_No,int req_seq)
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
    }
}
