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
   public class Inspect_Dac : ConnectionAccess
    {

        public List<Inspect_Vo>InsertInspect (Inspect_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "InsertInspect";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Inspect_Val", item.Inspect_Val);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Inspect_Vo> list = Helper.DataReaderMapToList<Inspect_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }

        public List<Inspect_Vo>GetVal(Inspect_Vo Item )
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetVal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", Item.Item_Name);
                cmd.Parameters.AddWithValue("@Inspect_Val", Item.Inspect_Val);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Inspect_Vo> list = Helper.DataReaderMapToList<Inspect_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }

        public List<Inspect_Vo>deleteVal (Inspect_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteVal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Inspect_Val", item.Inspect_Val);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Inspect_Vo> list = Helper.DataReaderMapToList<Inspect_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
