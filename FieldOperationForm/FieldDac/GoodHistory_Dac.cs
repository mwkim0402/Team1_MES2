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
   public class GoodHistory_Dac: ConnectionAccess
    {
      

        public List<GoodHistory_Vo>UpdateGoodsHistory (GoodHistory_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "UpdateGoodsHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Barcode_No", item.Barcode_No);
                cmd.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GoodHistory_Vo> list = Helper.DataReaderMapToList<GoodHistory_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }


        public List<GoodHistory_Vo>GetGoodHistory ()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetGoodHistory";
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GoodHistory_Vo> list = Helper.DataReaderMapToList<GoodHistory_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
