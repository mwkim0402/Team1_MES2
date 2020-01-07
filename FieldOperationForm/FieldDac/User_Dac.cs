using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class User_Dac
    {
        public string ConnectionString { get; private set; }

        public List<User_Vo> GetCustomerCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetCustomerCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<User_Vo> list = Helper.DataReaderMapToList<User_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

    }
}
