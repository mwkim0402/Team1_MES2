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
    public class Item_Dac: ConnectionAccess
    {
        public List<Item_Vo>GetItemName ()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetItemName";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Item_Vo> list = Helper.DataReaderMapToList<Item_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
