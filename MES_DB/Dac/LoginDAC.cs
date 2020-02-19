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
                cmd.CommandText = @"select um.UserGroup_Code,u.User_ID,u.User_Name,s.Screen_Code,s.Pre_Type
                                    from User_Master u inner
                                    join UserGroup_Mapping m on m.User_ID = u.User_ID
                                    inner
                                    join UserGroup_Master um on m.UserGroup_Code = um.UserGroup_Code
                                    inner
                                    join ScreenItem_Authority s on s.UserGroup_Code = um.UserGroup_Code
                                    where u.User_ID = @User_ID and u.User_PW = @User_PW ";
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

        public List<LoginVO> LoginAuthority(LoginVO login)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select um.UserGroup_Code,u.User_ID,u.User_Name,s.Screen_Code,s.Pre_Type
                                    from User_Master u inner
                                    join UserGroup_Mapping m on m.User_ID = u.User_ID
                                    inner
                                    join UserGroup_Master um on m.UserGroup_Code = um.UserGroup_Code
                                    inner
                                    join ScreenItem_Authority s on s.UserGroup_Code = um.UserGroup_Code
                                    where u.User_ID = @User_ID and s.Screen_Code = @Screen_Code";

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@User_ID", login.User_ID);
                cmd.Parameters.AddWithValue("@Screen_Code", login.Screen_Code);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<LoginVO> list = Helper.DataReaderMapToList<LoginVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
