using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MES_DB
{
    public class MoldingDac : ConnectionAccess
    {
        public List<MoldingInfoVo> GetMoldingInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Mold_Code,Mold_Name,Mold_Group,Mold_Status,Cum_Shot_Cnt,Cum_Prd_Qty,Cum_Time,Guar_Shot_Cnt,Purchase_Amt,In_Date,Last_Setup_Time,Remark,Use_YN from Mold_Master";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingInfoVo> list = Helper.DataReaderMapToList<MoldingInfoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public int SaveMoldingInfo(string code, string name, string group, int price, string inputdate, string lastequipdate, int warrentnum, string Ps,string Use)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "insert into Mold_Master(Mold_Code,Mold_Name,Mold_Group,Purchase_Amt,In_Date,Last_Setup_Time,Guar_Shot_Cnt,Remark,Use_YN,Mold_Status)values(@Code,@Name,@Group,@Price,@Inputdate,@Lastequipdate,@Warrentnum,@PS,@Use_YN,'N')";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Group", group);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Inputdate", inputdate);
                cmd.Parameters.AddWithValue("@Lastequipdate", lastequipdate);
                cmd.Parameters.AddWithValue("@Warrentnum", warrentnum);
                cmd.Parameters.AddWithValue("@PS", Ps);
                cmd.Parameters.AddWithValue("@Use_YN", Use);

                cmd.Connection.Open();

                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result;
            }
        }

        public int UpdateMoldingInfo(MoldingInfoDetailVo detail)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "UpdateMoldingInfo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", detail.Mold_Code);
                cmd.Parameters.AddWithValue("@Name", detail.Mold_Name);
                cmd.Parameters.AddWithValue("@Group", detail.Mold_Group);
                cmd.Parameters.AddWithValue("@Price", detail.Purchase_Amt);
                cmd.Parameters.AddWithValue("@Inputdate", detail.In_Date);
                cmd.Parameters.AddWithValue("@Lastequipdate", detail.Last_Setup_Time);
                cmd.Parameters.AddWithValue("@Warrentnum", detail.Guar_Shot_Cnt);
                cmd.Parameters.AddWithValue("@PS", detail.Remark);
                cmd.Parameters.AddWithValue("@Use_YN", detail.Use_YN);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result;
            }
        }

        public List<MoldingInfoDetailVo> GetMoldingInfoDetail(string moldcode)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Mold_Code,Mold_Name,Mold_Group,Mold_Status,Cum_Shot_Cnt,Cum_Prd_Qty,Cum_Time,Guar_Shot_Cnt,Purchase_Amt,In_Date,Last_Setup_Time,Remark,Use_YN from Mold_Master where Mold_Code = @Mold_Code";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Mold_Code", moldcode);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingInfoDetailVo> detaildata = Helper.DataReaderMapToList<MoldingInfoDetailVo>(reader);
                cmd.Connection.Close();
                return detaildata;
            }
        }

        internal List<MoldUseHistoryVo> SearchMoldUse(string start, string end, string item, string workplace)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "SearchMoldUse";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DateStart", start);
                cmd.Parameters.AddWithValue("@DateEnd", end);
                cmd.Parameters.AddWithValue("@ItemCode", item);
                cmd.Parameters.AddWithValue("@WorkPlaceCode", workplace);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseHistoryVo> list = Helper.DataReaderMapToList<MoldUseHistoryVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<MoldingInfoVo> SearchMoldingInfo(string code, string name, string group)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "SearchMoldingInfo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Group", group);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingInfoVo> list = Helper.DataReaderMapToList<MoldingInfoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<MoldUseHistoryVo> MoldUseHistory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "MoldUseHistory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseHistoryVo> list = Helper.DataReaderMapToList<MoldUseHistoryVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

    }
}
