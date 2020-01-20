using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MES_DB;

namespace FieldOperationForm
{
   public class WorkAllocation_Dac : ConnectionAccess
    {

        public List<WorkAllocation_Vo> GetWorkerList(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetWorkerList";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAllocation_Vo> list = Helper.DataReaderMapToList<WorkAllocation_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

    }
}
