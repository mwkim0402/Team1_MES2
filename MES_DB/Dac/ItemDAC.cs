using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MES_DB
{
    public class ItemDAC : ConnectionAccess
    {
        public List<ItemGroupCombo> GetItemGroupCB()
        {
            List<ItemGroupCombo> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "ItemGroupCombo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<ItemGroupCombo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<ItemGroupVo> GetAllItemGroup()
        {
            List<ItemGroupVo> list = null;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetItemGroup";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<ItemGroupVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<ItemVo> GetAllItemIfno()
        {
            List<ItemVo> list = null;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllItemInfo";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<ItemVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<string> ItemComboName(string level)
        {
            List<string> list = null;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select Level_Code from Item_Level_Master where item_";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<string>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
