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
   public class WorkOrder_Dac : ConnectionAccess
    {

        public List<WorkOrder_Vo>InsertWorkOrder (WorkOrder_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "InsertWorkOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@Plan_Qty ", item.Plan_Qty);
            
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_Vo> list = Helper.DataReaderMapToList<WorkOrder_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
    }
}
