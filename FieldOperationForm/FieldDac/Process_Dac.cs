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
   public class Process_Dac : ConnectionAccess
    {
        public List<Process_Vo> GetProName()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetProName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Process_Vo> list = Helper.DataReaderMapToList<Process_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
