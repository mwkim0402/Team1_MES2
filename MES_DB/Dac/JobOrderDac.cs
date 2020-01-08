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
        public List<JobOrderCreateVo> MoldingOrderCreation_Req()
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
        public List<JobOrderCreateVo> MoldingOrderCreation_WO()
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
    }
}
