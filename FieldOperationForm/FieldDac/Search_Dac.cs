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
   public class Search_Dac : ConnectionAccess
    {
        public List<Search_Vo>SearchBarcodeDate (Search_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "SearchBarcodeDate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDate", item.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", item.EndDate);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Search_Vo> list = Helper.DataReaderMapToList<Search_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
