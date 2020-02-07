using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkCenterDAC : ConnectionAccess
    {
        public List<WorkCenterVo> GetAllWorkCenter()
        {
            List<WorkCenterVo> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Wc_Code, Wc_Name, Wc_Group, Process_Code, Auto_Wo_YN, Auto_Start_YN, Wo_Status, Nop_Auto_YN, Nop_Check_Time, Prd_Req_Type, Pallet_YN, Prd_Unit, Mold_Setup_YN, Use_YN, Remark from WorkCenter_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<WorkCenterVo>(cmd.ExecuteReader());
            }
            return list;
        }
        public bool InsertWorkCenter(WorkCenterVo workVo)
        {
            int Checked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into WorkCenter_Master(Wc_Code, Wc_Name, Wc_Group, Process_Code, Wo_Status, Prd_Req_Type, Pallet_YN, Prd_Unit, Mold_Setup_YN, Use_YN, Remark, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                                                values(@Wc_Code, @Wc_Name, @Wc_Group, @Process_Code, 'STOP', @Prd_Req_Type, @Pallet_YN, @Prd_Unit, @Mold_Setup_YN, @Use_YN, @Remark, @Ins_Date, '김민우', @Ins_Date, '김민우')";
                cmd.Parameters.AddWithValue("@Wc_Code",workVo.Wc_Code);
                cmd.Parameters.AddWithValue("@Wc_Name",workVo.Wc_Name);
                cmd.Parameters.AddWithValue("@Wc_Group",workVo.Wc_Group);
                cmd.Parameters.AddWithValue("@Process_Code",workVo.Process_Code);
                cmd.Parameters.AddWithValue("@Prd_Req_Type",workVo.Prd_Req_Type);
                cmd.Parameters.AddWithValue("@Pallet_YN",workVo.Pallet_YN);
                cmd.Parameters.AddWithValue("@Prd_Unit",workVo.Prd_Unit);
                cmd.Parameters.AddWithValue("@Use_YN",workVo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark",workVo.Remark);
                cmd.Parameters.AddWithValue("@Mold_Setup_YN", workVo.Mold_Setup_YN);
                cmd.Parameters.AddWithValue("@Ins_Date",DateTime.Now);
                cmd.Connection.Open();
                Checked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return Checked==1?true:false;
        }
    }
}
