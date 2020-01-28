using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ProcessDAC : ConnectionAccess
    {
        public List<ProcessVo> GetAllProcess()
        {
            List<ProcessVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select Process_Code, Process_Name, Process_Group, Use_YN, Remark from Process_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<ProcessVo>(cmd.ExecuteReader());

                cmd.Connection.Close();
            }
            return list;
        }
        public bool UpdateProcess (ProcessVo proVo)
        {
            int a = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update Process_Master set Process_Name=@Process_Name, Process_Group=@Process_Group, Use_YN=@Use_YN, Remark=@Remark, Up_Date=@Up_Date, Up_Emp='김민우' where Process_Code=@Process_Code";
                cmd.Parameters.AddWithValue("@Process_Code", proVo.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name", proVo.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group", proVo.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN", proVo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", proVo.Remark);
                cmd.Parameters.AddWithValue("@Up_Date", DateTime.Now);
                cmd.Connection.Open();
                a = cmd.ExecuteNonQuery();

                cmd.Connection.Close();
            }
            return a == 1 ? true : false;
        }
        public bool InsertProcess (ProcessVo proVo)
        {
            int a = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Insert into Process_Master(Process_Code, Process_Name, Process_Group, Use_YN, Remark, Ins_Date, Ins_Emp, Up_Date, Up_Emp)  Values (@Process_Code, @Process_Name, @Process_Group, @Use_YN, @Remark, @Ins_Date, '김민우', @Up_Date, '김민우')";
                cmd.Parameters.AddWithValue("@Process_Code", proVo.Process_Code);
                cmd.Parameters.AddWithValue("@Process_Name", proVo.Process_Name);
                cmd.Parameters.AddWithValue("@Process_Group", proVo.Process_Group);
                cmd.Parameters.AddWithValue("@Use_YN", proVo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", proVo.Remark);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Up_Date", DateTime.Now);
                cmd.Connection.Open();
                a = cmd.ExecuteNonQuery();

                cmd.Connection.Close();
            }
            return a == 1 ? true : false;
        }
    }
}
