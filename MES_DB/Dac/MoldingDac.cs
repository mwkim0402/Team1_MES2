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
        public List<MoldUseHistory> MoldUseHistory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "MoldUseHistory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseHistory> list = Helper.DataReaderMapToList<MoldUseHistory>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

    }
}
