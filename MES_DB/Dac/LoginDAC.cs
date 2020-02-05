using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class LoginDAC : ConnectionAccess
    {
        public List<LoginVO> LoginOK(LoginVO login)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select * from User_Master where User_ID = @User_ID and User_PW = @User_PW";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@User_ID", login.User_ID);
                cmd.Parameters.AddWithValue("@User_PW", login.User_PW);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<LoginVO> list = Helper.DataReaderMapToList<LoginVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
