using MES_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class MoldStart_Dac : ConnectionAccess
    {
        public List<MoldStart_Vo>MoldStartHistory (MoldStart_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "MoldStartHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mold_Name", item.Mold_Name);
                cmd.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldStart_Vo> list = Helper.DataReaderMapToList<MoldStart_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
        public List<MoldStart_Vo>MoldEndHistory (MoldStart_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "MoldEndHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mold_Name", item.Mold_Name);
                cmd.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldStart_Vo> list = Helper.DataReaderMapToList<MoldStart_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
        public List<MoldStart_Vo>GetMoldName (string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetMoldName";
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldStart_Vo> list = Helper.DataReaderMapToList<MoldStart_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }

    }
}
