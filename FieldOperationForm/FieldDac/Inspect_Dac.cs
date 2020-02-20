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

        public List<Inspect_Vo>deleteVal (Inspect_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteVal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Condition_Val", item.Condition_Val);
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@Condition_Group", item.Condition_Group);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Inspect_Vo> list = Helper.DataReaderMapToList<Inspect_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
