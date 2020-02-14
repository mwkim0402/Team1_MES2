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
  public  class CreatePalette_Dac : ConnectionAccess
    {
        public List<CreatePalette_Vo> CreatePalette(CreatePalette_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "CreatePalette";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno ", item.Workorderno);
                cmd.Parameters.AddWithValue("@Pallet_No", item.Pallet_No);
                cmd.Parameters.AddWithValue("@Prd_Qty", item.Prd_Qty);
                cmd.Parameters.AddWithValue("@Grade_Code", item.Grade_Code);
                cmd.Parameters.AddWithValue("@Size_Code", item.Size_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", item.Grade_Detail_Code);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CreatePalette_Vo> list = Helper.DataReaderMapToList<CreatePalette_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
    }
}
