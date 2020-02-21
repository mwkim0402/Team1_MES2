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
   public class PackageEnd_Dac: ConnectionAccess
    {
        public int EndPackage (string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "EndPackage";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);
             
                cmd.Connection.Open();
                int icount = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();

                return icount;


            }

        }
    }
}
