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
  public  class Mold_Dac : ConnectionAccess
    {
        public List<Mold_Vo> GetYMold()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetYMold";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Mold_Vo> list = Helper.DataReaderMapToList<Mold_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<Mold_Vo> GetNMold()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetNMold";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Mold_Vo> list = Helper.DataReaderMapToList<Mold_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<Mold_Vo>UpdateUseMold (string Mold_Code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "UpdateUseMold";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mold_Code", Mold_Code);
            

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Mold_Vo> list = Helper.DataReaderMapToList<Mold_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
      
        public List<Mold_Vo>DesorptionMold (string Mold_Code)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "DesorptionMold";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mold_Code", Mold_Code);
            

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Mold_Vo> list = Helper.DataReaderMapToList<Mold_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
