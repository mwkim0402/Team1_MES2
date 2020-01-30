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

        public List<WorkOrder_Vo> GetWorkOrder(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetWorkOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);
                

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_Vo> list = Helper.DataReaderMapToList<WorkOrder_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public List<WorkOrder_Vo> StartWork(string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "StartWork";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_Vo> list = Helper.DataReaderMapToList<WorkOrder_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public List<WorkOrder_Vo> EndWork(string Workorderno)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "EndWork";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_Vo> list = Helper.DataReaderMapToList<WorkOrder_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public List<WorkOrder_Vo> GetTextWorkOrder(WorkOrder_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetTextWorkOrder";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno", item.Workorderno);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrder_Vo> list = Helper.DataReaderMapToList<WorkOrder_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
    }
}
