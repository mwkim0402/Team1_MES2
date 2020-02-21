using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserLoginDAC : ConnectionAccess
    {
        public List<UserLoginVo> GetAllLoginHis()
        {
            List<UserLoginVo> list = null;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select um.User_ID User_ID, User_Name, CONVERT(CHAR(19), Login_Time, 20) Login_Time, isnull(CONVERT(CHAR(19), Logout_Time, 20),'로그인 중') Logout_Time, Form_Type
                                                    from User_Master um inner join UserLogin_History uh on um.User_ID = uh.User_ID";
                cmd.Connection.Open();

                list = Helper.DataReaderMapToList<UserLoginVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertMESLoginHis(int id)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into UserLogin_History(User_ID, Login_Time, Form_Type)
                                                values(@User_ID, @Login_Time, @Form_Type)";
                cmd.Parameters.AddWithValue("@User_ID", id);
                cmd.Parameters.AddWithValue("@Login_Time", DateTime.Now);
                cmd.Parameters.AddWithValue("@Form_Type", "MES 프로그램");
                cmd.Connection.Open();

                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked == 1 ? true : false;
        }
        public bool InsertPOPLoginHis(int id)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into UserLogin_History(User_ID, Login_Time, Form_Type)
                                                values(@User_ID, @Login_Time, @Form_Type)";
                cmd.Parameters.AddWithValue("@User_ID", id);
                cmd.Parameters.AddWithValue("@Login_Time", DateTime.Now);
                cmd.Parameters.AddWithValue("@Form_Type", "POP 프로그램");
                cmd.Connection.Open();

                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked == 1 ? true : false;
        }
        public bool UpdateLogoutHis(int id)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"update UserLogin_History
                                                    set Logout_Time = @Logout_Time                                               
                                                where User_ID = @User_ID
                                                       and Logout_Time is null";
                cmd.Parameters.AddWithValue("@User_ID", id);
                cmd.Parameters.AddWithValue("@Logout_Time", DateTime.Now);
                cmd.Connection.Open();

                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked == 1 ? true : false;
        }
    }
}
