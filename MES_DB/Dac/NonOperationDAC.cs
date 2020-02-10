using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class NonOperationDAC : ConnectionAccess
    {
        public bool InsertNonOperationMa(NonOperationVO vo)
        {
            int CheckNum = 0;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"Insert into Nop_Ma_Master(Nop_Ma_Code, Nop_Ma_Name, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                                                values (@Nop_Ma_Code, @Nop_Ma_Name, @USE_YN, @Ins_Date, @Ins_Emp, @Ins_Date, @Ins_Emp)";
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", vo.Nop_Ma_Name);
                cmd.Parameters.AddWithValue("@USE_YN", vo.Use_YN);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Ins_Emp", "김민우");
                cmd.Connection.Open();
                CheckNum = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            return CheckNum == 1 ? true : false;
        } 
        public bool InsertNonOpMi(NonOpMiVo vo)
        {
            int CheckNum = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"Insert into Nop_Mi_Master(Nop_Mi_Code, Nop_Mi_Name, Nop_Ma_Code, Remark, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                                                values (@Nop_Mi_Code, @Nop_Mi_Name, @Nop_Ma_Code, @Remark, @USE_YN, @Ins_Date, @Ins_Emp, @Ins_Date, @Ins_Emp)";
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", vo.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", vo.Nop_Mi_Name);
                cmd.Parameters.AddWithValue("@USE_YN", vo.Use_YN);
                cmd.Parameters.AddWithValue("@Remark", vo.Remark);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Ins_Emp", "김민우");
                cmd.Connection.Open();
                CheckNum = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            return CheckNum == 1 ? true : false;
        }
        public List<NonOperationVO> GetAllNonOpMa()
        {
            List<NonOperationVO> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Nop_Ma_Code, Nop_Ma_Name, Use_YN from Nop_Ma_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<NonOperationVO>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public List<NonOpMiVo> GetNonOpMi()
        {
            List<NonOpMiVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select Nop_Mi_Code, Nop_Mi_Name, Nop_Ma_Code, Remark, Use_YN from Nop_Mi_Master";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<NonOpMiVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
    }
}
