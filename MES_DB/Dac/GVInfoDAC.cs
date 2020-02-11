using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class GVInfoDAC : ConnectionAccess
    {
        public List<GvInfoVo> GetAllGVInfo()
        {
            List<GvInfoVo> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"Select GV_Code, GV_Name, GV_Status, GV_Group,Use_YN from GV_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<GvInfoVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertGVInfo(GvInfoVo vo)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into GV_Master(GV_Code, GV_Name, GV_Status, GV_Group, Use_YN)
                                                values(@GV_Code, @GV_Name, @GV_Status, @GV_Group, @Use_YN)";
                cmd.Parameters.AddWithValue("@GV_Code", vo.GV_Code);
                cmd.Parameters.AddWithValue("@GV_Name", vo.GV_Name);
                cmd.Parameters.AddWithValue("@GV_Status", vo.GV_Status);
                cmd.Parameters.AddWithValue("@GV_Group", vo.GV_Group);
                cmd.Parameters.AddWithValue("@Use_YN", vo.Use_YN);
                cmd.Connection.Open();
                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked ==1 ? true: false;
        }
    }
}
