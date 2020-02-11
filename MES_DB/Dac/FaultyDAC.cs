using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MES_DB
{
    public class FaultyDAC : ConnectionAccess
    {
        public List<FaultyMasterVo> GetAllFaultyMaster()
        {
            List<FaultyMasterVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllFaultyMaster";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection.Open();

                list = Helper.DataReaderMapToList<FaultyMasterVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertFaultyMaster(FaultyMasterVo list)
        {
            int Checked = 0;
            string sqlString = "insert into Def_Ma_Master(Def_Ma_Code, Def_Ma_Name, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp) values(@Def_Ma_Code, @Def_Ma_Name, @Use_YN, @Date, '김민우', @Date, '김민우')";
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = new SqlConnection(ConnectionString);
                    cmd.CommandText = sqlString;
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", list.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Def_Ma_Name", list.Def_Ma_Name);
                    cmd.Parameters.AddWithValue("@Use_YN", list.Use_YN);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Connection.Open();
                    Checked = cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }
                catch (Exception)
                {
                    throw new Exception("등록실패하였습니다, 모든 데이터를 입력하여야합니다.");
                }

            }
            return Checked == 1 ? true : false;
        }
        public bool UpdateFaultyMaster(FaultyMasterVo fMaster)
        {
            int Checked = 0;
            string sqlString = "Update Def_Ma_Master set Def_Ma_Name = @Def_Ma_Name, Use_YN=@Use_YN, Up_Date=@Date, Up_Emp=@UpEmp where Def_Ma_Code = @Def_Ma_Code";
            using(SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = new SqlConnection(ConnectionString);
                    cmd.CommandText = sqlString;
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", fMaster.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Def_Ma_Name", fMaster.Def_Ma_Name);
                    cmd.Parameters.AddWithValue("@Use_YN", fMaster.Use_YN);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UpEmp", "김민우");
                    cmd.Connection.Open();
                    Checked = cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }
                catch (Exception)
                {
                    throw new Exception("저장실패하였습니다, 다시 확인하세요.");
                }
                return Checked == 1 ? true : false;
            }
        }
        public List<FaultyDetailVo> GetAllFaultyDetail()
        {
            List<FaultyDetailVo> list;
            string sqlString = "Select Def_Ma_Code, Def_Mi_Code, Def_Mi_Name, Use_YN, Remark from Def_Mi_Master";
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = sqlString;
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<FaultyDetailVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertFaultyDetail(FaultyDetailVo insertVo)
        {
            int Checked = 0;
            string sqlString = "insert into Def_Mi_Master(Def_Ma_Code, Def_Mi_Code, Def_Mi_Name ,Use_YN, Remark, Ins_Date, Ins_Emp, Up_Date, Up_Emp) values(@Def_Ma_Code, @Def_Mi_Code, @Def_Mi_Name, @Use_YN, @Remark, @Date, '김민우', @Date, '김민우')";
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = new SqlConnection(ConnectionString);
                    cmd.CommandText = sqlString;
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", insertVo.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Def_Mi_Code", insertVo.Def_Mi_Code);
                    cmd.Parameters.AddWithValue("@Def_Mi_Name", insertVo.Def_Mi_Name);
                    cmd.Parameters.AddWithValue("@Use_YN", insertVo.Use_YN);
                    cmd.Parameters.AddWithValue("@Remark", insertVo.Remark);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Connection.Open();
                    Checked = cmd.ExecuteNonQuery();

                    cmd.Connection.Close();
                }
                catch (Exception)
                {
                    throw new Exception("등록실패하였습니다, 모든 데이터를 입력하여야합니다.");
                }

            }
            return Checked == 1 ? true : false;
        }
    }
}
