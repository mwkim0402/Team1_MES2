using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MES_DTO;
using System.Web.Configuration;

namespace MES_API.DAC
{
    public class JobOrderDac 
    {
        string ConnectionString = string.Empty;
        public JobOrderDac()
        {
            ConnectionString = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }
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
        public List<MoldingOrderCreation_WoVo> MoldingOrderCreation_WO()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "JobOrderCreation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingOrderCreation_WoVo> list = Helper.DataReaderMapToList<MoldingOrderCreation_WoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
