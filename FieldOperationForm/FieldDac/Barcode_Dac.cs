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
  public  class Barcode_Dac: ConnectionAccess
    {

        public List<Barcode_Vo>GetBarcode(string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetBarcode";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Barcode_Vo> list = Helper.DataReaderMapToList<Barcode_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
