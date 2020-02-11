using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WoReqDAC : ConnectionAccess
    {
        public List<Wo_Req> GetAllWoReq()
        {
            List<Wo_Req> list;
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Wo_Req_No, Item_Code, Req_Qty, Prd_Plan_Date, Cust_Name, Project_Name, Ins_Date,Req_Seq from Wo_Req";
                cmd.Connection.Open();
                list = Helper.DataReaderMapToList<Wo_Req>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertWoReq(Wo_Req vo)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"insert into Wo_Req (Wo_Req_No, Req_Seq,Item_Code, Req_Qty, Prd_Plan_Date, Cust_Name, Project_Name,Ins_Date, Req_Status, Sale_Emp)
                                                values(@Wo_Req_No, @Req_Seq, @Item_Code, @Req_Qty, @Prd_Plan_Date, @Cust_Name, @Project_Name,@Ins_Date, @Req_Status, @Sale_Emp)";
                cmd.Parameters.AddWithValue("@Wo_Req_No", vo.Wo_Req_No);
                cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                cmd.Parameters.AddWithValue("@Req_Qty", vo.Req_Qty);
                cmd.Parameters.AddWithValue("@Prd_Plan_Date", vo.Prd_Plan_Date);
                cmd.Parameters.AddWithValue("@Cust_Name", vo.Cust_Name);
                cmd.Parameters.AddWithValue("@Project_Name", vo.Project_Name);
                cmd.Parameters.AddWithValue("@Req_Seq", vo.Req_Seq);
                cmd.Parameters.AddWithValue("@Ins_Date", vo.Ins_Date);
                cmd.Parameters.AddWithValue("@Req_Status", "의뢰접수");
                cmd.Parameters.AddWithValue("@Sale_Emp", "김민우");
                cmd.Connection.Open();
                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked == 1 ? true : false;
        }
    }
}
