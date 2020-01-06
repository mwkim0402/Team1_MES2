using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataBase
{
    public class MenuTreeDac : ConnectionAccess
    {
        public List<MenuTreeVo> GetAllMenu()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetAllMenuTree";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MenuTreeVo> list = Helper.DataReaderMapToList<MenuTreeVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
