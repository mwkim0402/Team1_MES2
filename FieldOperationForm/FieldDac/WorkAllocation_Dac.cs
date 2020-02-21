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
            using (SqlCommand cmd = new SqlCommand( Wc_Name))
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


        public List<WorkAllocation_Vo> GetWorker(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetWorker";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAllocation_Vo> list = Helper.DataReaderMapToList<WorkAllocation_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<WorkAssignment_Vo> WorkAssignment(WorkAssignment_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "WorkAssignment";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name",item. Wc_Name);
                cmd.Parameters.AddWithValue("@User_Name",item.User_Name );

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public List<WorkAssignment_Vo>deleteWorker (string User_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteWorker";
                cmd.CommandType = CommandType.StoredProcedure;
             
                cmd.Parameters.AddWithValue("@User_Name",User_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<WorkAssignment_Vo> deleteAllWorker(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteAllWorker";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<WorkAssignment_Vo>deleteWorkerHistory(string User_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteWorkerHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_Name", User_Name);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<WorkAssignment_Vo>InsertWorkerHistory (WorkAssignment_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "InsertWorkerHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@User_Name", item.User_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<WorkAssignment_Vo>deleteAllWorkerHistory(string Wc_Name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "deleteAllWorkerHistory";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkAssignment_Vo> list = Helper.DataReaderMapToList<WorkAssignment_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

    }
}
