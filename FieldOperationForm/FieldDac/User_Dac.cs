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
   public class User_Dac: ConnectionAccess
    {
       

        public List<User_Vo> GetCustomerCode()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetCustomerCode";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<User_Vo> list = Helper.DataReaderMapToList<User_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public int UserLogin(string User_ID, string User_PW)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "UserLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                cmd.Parameters.AddWithValue("@User_PW", User_PW);
                cmd.Connection.Open();
                int checkCnt = Convert.ToInt32(cmd.ExecuteScalar());
                return checkCnt;
            }
        }
        public string GetUserType(string User_ID, string User_PW)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetUserType";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                cmd.Parameters.AddWithValue("@User_PW", User_PW);
                cmd.Connection.Open();
                string checkType = cmd.ExecuteScalar().ToString();
                return checkType;
            }
        }

        public string GetUserName(string User_ID, string User_PW)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetUserName";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                cmd.Parameters.AddWithValue("@User_PW", User_PW);
                cmd.Connection.Open();
                string checkName = cmd.ExecuteScalar().ToString();
                return checkName;
            }
        }



    }
}
