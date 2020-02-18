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
   public class Condition_Dac : ConnectionAccess
    {
        public List<Condition_Vo>GetCondition(Condition_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetCondition";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Condition_Vo> list = Helper.DataReaderMapToList<Condition_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
        


    }
}
