using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MES_DB
{
    public class MenuTreeDac : ConnectionAccess
    {
        public List<MenuTreeVo> GetAllMenu()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllMenuTree";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MenuTreeVo> list = Helper.DataReaderMapToList<MenuTreeVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<FindCategoryVo> GetCategory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select code,cName from VW_CatCode";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FindCategoryVo> list = Helper.DataReaderMapToList<FindCategoryVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
