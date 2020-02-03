using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ConditionSpecDAC : ConnectionAccess
    {
        public List<ConditionSpecVo> GetConditionSpec()
        {
            List<ConditionSpecVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Item_Code, Wc_Code, Condition_Code, Condition_Name, Spec_Desc, USL, SL, LSL, Condition_Group, Condition_Unit, Use_YN, Remark
                                                from Condition_Spec_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<ConditionSpecVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }

        public bool InsertConditionMaster(ConditionSpecVo vo)
        {
            int Checked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into Condition_Spec_Master(Item_Code, Wc_Code, Condition_Code, Condition_Name, Spec_Desc, USL, SL, LSL, Condition_Group, Condition_Unit, Use_YN, Remark, Ins_Emp, Ins_Date, Up_Emp, Up_Date)
                                                values (@Item_Code, @Wc_Code, @Condition_Code, @Condition_Name, @Spec_Desc, @USL, @SL, @LSL, @Condition_Group, @Condition_Unit, @Use_YN, @Remark, '김민우', @Ins_Date, '김민우', @Ins_Date)";
                cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                cmd.Parameters.AddWithValue("@Wc_Code", vo.Wc_Code);
                cmd.Parameters.AddWithValue("@Condition_Code", vo.Condition_Code);
                cmd.Parameters.AddWithValue("@Condition_Name", vo.Condition_Name);
                cmd.Parameters.AddWithValue("@Spec_Desc", vo.Spec_Desc);
                cmd.Parameters.AddWithValue("@USL", vo.USL);
                cmd.Parameters.AddWithValue("@SL", vo.SL);
                cmd.Parameters.AddWithValue("@LSL", vo.LSL);
                cmd.Parameters.AddWithValue("@Condition_Group", vo.Condition_Group);
                cmd.Parameters.AddWithValue("@Condition_Unit", vo.Condition_Unit);
                cmd.Parameters.AddWithValue("@Use_YN", vo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", vo.Remark);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Connection.Open();
                Checked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return Checked == 1 ? true : false;
        }
    }
}
