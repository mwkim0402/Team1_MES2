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
  public  class Workorderno_Dac: ConnectionAccess
    {
        public List<Workorderno_Vo>GetWorkorderno (string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetWorkorderno";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Workorderno_Vo> list = Helper.DataReaderMapToList<Workorderno_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }

        public List<Workorderno_Vo> EndWorkorderno(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "EndWorkorderno";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Workorderno_Vo> list = Helper.DataReaderMapToList<Workorderno_Vo>(reader);
                cmd.Connection.Close();

                return list;

            }

        }
        public List<Workorderno_Vo> InspectWorkCenter(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsepectWorkorder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Workorderno_Vo> list = Helper.DataReaderMapToList<Workorderno_Vo>(reader);
                cmd.Connection.Close();

                return list;

            }

        }
    }
}
