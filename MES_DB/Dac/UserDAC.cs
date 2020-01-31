using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class UserDAC : ConnectionAccess
    {
        public List<UserGroupManagerVO> UserGroupManagerForm()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select m.UserGroup_Code,ug.UserGroup_Name,ug.Use_YN
                                    from UserGroup_Mapping m inner
                                    join User_Master um on m.User_ID = um.User_ID
                                    inner
                                    join UserGroup_Master ug on ug.UserGroup_Code = m.UserGroup_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupManagerVO> list = Helper.DataReaderMapToList<UserGroupManagerVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public void InsUserGroupManagerForm(UserGroupManagerVO user)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select m.UserGroup_Code,ug.UserGroup_Name,ug.Use_YN
                                    from UserGroup_Mapping m inner
                                    join User_Master um on m.User_ID = um.User_ID
                                    inner
                                    join UserGroup_Master ug on ug.UserGroup_Code = m.UserGroup_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
    }
}
