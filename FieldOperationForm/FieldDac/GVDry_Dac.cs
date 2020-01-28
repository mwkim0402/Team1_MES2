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
  public  class GVDry_Dac : ConnectionAccess
    {
        public List<GVDry_Vo> GVDry()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GVDry";
                cmd.CommandType = CommandType.StoredProcedure;
           

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GVDry_Vo> list = Helper.DataReaderMapToList<GVDry_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }

        public List<GVDry_Vo>GetGV()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetGV";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GVDry_Vo> list = Helper.DataReaderMapToList<GVDry_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}

