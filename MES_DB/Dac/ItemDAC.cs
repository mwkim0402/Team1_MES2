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

        public bool InsertItemIfno(ItemVo item)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsertItemInfo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Item_Name_Eng", item.Item_Name_Eng);
                cmd.Parameters.AddWithValue("@Item_Name_Eng_Alias", item.Item_Name_Eng_Alias);
                cmd.Parameters.AddWithValue("@Item_Type", item.Item_Type);
                cmd.Parameters.AddWithValue("@Item_Spec", item.Item_Spec);
                cmd.Parameters.AddWithValue("@Item_Unit", item.Item_Unit);
                cmd.Parameters.AddWithValue("@Level_1", item.Level_1);
                cmd.Parameters.AddWithValue("@Level_2", item.Level_2);
                cmd.Parameters.AddWithValue("@Level_3", item.Level_3);
                cmd.Parameters.AddWithValue("@Level_4", item.Level_4);
                cmd.Parameters.AddWithValue("@Level_5", item.Level_5);
                cmd.Parameters.AddWithValue("@Item_Stock", item.Item_Stock);
                cmd.Parameters.AddWithValue("@PrdQty_Per_Hour", item.PrdQty_Per_Hour);
                cmd.Parameters.AddWithValue("@PrdQTy_Per_Batch", item.PrdQTy_Per_Batch);
                cmd.Parameters.AddWithValue("@Cavity", item.Cavity);
                cmd.Parameters.AddWithValue("@Line_Per_Qty", item.Line_Per_Qty);
                cmd.Parameters.AddWithValue("@Shot_Per_Qty", item.Shot_Per_Qty);
                cmd.Parameters.AddWithValue("@Dry_GV_Qty", item.Dry_GV_Qty);
                cmd.Parameters.AddWithValue("@Heat_GV_Qty", item.Heat_GV_Qty);
                cmd.Parameters.AddWithValue("@Remark", item.Remark);
                cmd.Parameters.AddWithValue("@LotSize",item.LotSize );
                int Checked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (Checked == 0)
                    return false;
                return true;
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

        public bool DeleteItemInfo(string id)
        {
            int Checekd = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"Delete from Item_Master where Item_Code = @Item_Code";
                cmd.Parameters.AddWithValue("@Item_Code", id);
                cmd.Connection.Open();
                Checekd = cmd.ExecuteNonQuery();
                cmd.Connection.Close();    
            }
            return Checekd == 1 ? true : false;
        }
    }
}
