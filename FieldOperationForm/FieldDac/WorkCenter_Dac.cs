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
   public class WorkCenter_Dac: ConnectionAccess
    {


        public List<WorkCenter_Vo> GetWcName()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetWcName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenter_Vo> list = Helper.DataReaderMapToList<WorkCenter_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
