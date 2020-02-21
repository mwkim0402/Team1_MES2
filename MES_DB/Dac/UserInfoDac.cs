using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserInfoDac : ConnectionAccess
    {
        public UserInfoVo GetUserInfo(int userID)
        {
            UserInfoVo userVo;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select um.User_ID, User_Name, Default_Process_Code, UserGroup_Name,User_Phone, User_Email, User_Image
                                                from User_Master um inner join UserGroup_Mapping ugm on um.User_ID =ugm.User_ID
					                            inner join UserGroup_Master ugma on ugm.UserGroup_Code = ugma.UserGroup_Code
                                                where um.User_ID = @User_ID";
                cmd.Parameters.AddWithValue("@User_ID", userID);
                cmd.Connection.Open();
                userVo = Helper.DataReaderMapToList<UserInfoVo>(cmd.ExecuteReader())[0];
                cmd.Connection.Close();
            }
            return userVo;
        }

        public void InsImage(UserInfoVo user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"update User_Master set User_Image = @User_Image , User_Phone = @User_Phone , User_Email=@User_Email where User_ID = @User_ID";

                cmd.Parameters.AddWithValue("@User_ID", user.User_ID);
                cmd.Parameters.AddWithValue("@User_Image", user.User_Image);
                cmd.Parameters.AddWithValue("@User_Phone", user.User_Phone);
                cmd.Parameters.AddWithValue("@User_Email", user.User_Email);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                
            }
        }
    }
}
