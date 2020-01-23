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
        public List<MoldingInfoVo> SaveMoldingInfo(string code, string name, string group, string price, string inputdate, string lastequipdate, string warrentnum, string Ps,int Use)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "insert into Mold_Master(Mold_Code,Mold_Name,Mold_Group,Pruchase_Amt,In_Date,Ins_Date,Guar_Shot_Cnt,Use_YN)values(@Code,@Name,@Group,@Price,@Inputdate,@Lastequipdate,@Warrentnum,@PS,@Use_YN)";
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
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingInfoVo> list = Helper.DataReaderMapToList<MoldingInfoVo>(reader);
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
