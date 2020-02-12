using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class InspectDAC : ConnectionAccess
    {
        public List<InspectVo> GetInspectMaster()
        {
            List<InspectVo> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Item_Code, Process_Code, Inspect_Code, Inspect_Name, Spec_Desc, USL, SL, LSL, Inspect_Group, Inspect_Unit, Use_YN, Remark
                                                from Inspect_Spec_Master";
                cmd.Connection.Open();
                    list = Helper.DataReaderMapToList<InspectVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }

        public bool InsertInspectMaster(InspectVo vo)
        {
            int Checked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into Inspect_Spec_Master(Item_Code, Process_Code, Inspect_Code, Inspect_Name, Spec_Desc, USL, SL, LSL, Inspect_Group, Inspect_Unit, Use_YN, Remark, Ins_Emp, Ins_Date, Up_Emp, Up_Date)
                                                values (@Item_Code, @Process_Code, @Inspect_Code, @Inspect_Name, @Spec_Desc, @USL, @SL, @LSL, @Inspect_Group, @Inspect_Unit, @Use_YN, @Remark, '김민우', @Ins_Date, '김민우', @Ins_Date)";
                cmd.Parameters.AddWithValue("@Item_Code",vo.Item_Code);
                cmd.Parameters.AddWithValue("@Process_Code",vo.Process_Code);
                cmd.Parameters.AddWithValue("@Inspect_Code",vo.Inspect_Code);
                cmd.Parameters.AddWithValue("@Inspect_Name",vo.Inspect_Name);
                cmd.Parameters.AddWithValue("@Spec_Desc",vo.Spec_Desc);
                cmd.Parameters.AddWithValue("@USL",vo.USL);
                cmd.Parameters.AddWithValue("@SL",vo.SL);
                cmd.Parameters.AddWithValue("@LSL",vo.LSL);
                cmd.Parameters.AddWithValue("@Inspect_Group", vo.Inspect_Group);
                cmd.Parameters.AddWithValue("@Inspect_Unit",vo.Inspect_Unit);
                cmd.Parameters.AddWithValue("@Use_YN",vo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark",vo.Remark);
                cmd.Parameters.AddWithValue("@Ins_Date",DateTime.Now);
                cmd.Connection.Open();
                Checked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return Checked == 1 ? true : false;
        }
    }
}
