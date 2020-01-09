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
   public class Notice_Dac: ConnectionAccess
    {
   

        public List<Notice_Vo> NoticeList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "NoticeList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Notice_Vo> list = Helper.DataReaderMapToList<Notice_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public bool GetNotice (Notice_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetNotice";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", item.Title);

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowsAffected > 0;
            }
        }
    }
}
