using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MES_DTO;
using System.Web.Configuration;

namespace MES_API.DAC
{
    public class MenuTreeDac
    {
        string ConnectionString = string.Empty;
        public MenuTreeDac()
        {
            ConnectionString = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }
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

        public List<FindCategoryVo> GetCategory(string catTable)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select code Code,cName CodeName from VW_CatCode where CodeType = @CodeType";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@CodeType", catTable);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<FindCategoryVo> list = Helper.DataReaderMapToList<FindCategoryVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
