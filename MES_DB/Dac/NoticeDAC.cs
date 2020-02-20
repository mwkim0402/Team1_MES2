using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class NoticeDAC : ConnectionAccess
    {
        public List<NoticeVo> GetAllNotice()
        {
            List<NoticeVo> list;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Seq, CONVERT(VARCHAR, Notice_Date, 23) Notice_Date, Title, Description from Sys_Notice ";
                cmd.Connection.Open();

                list = Helper.DataReaderMapToList<NoticeVo>(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return list;
        }
        public bool InsertNotice(NoticeVo vo)
        {
            int isChecked = 0;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "insert into Sys_Notice (Notice_Date, Title, Description) values(@Notice_Date, @Title, @Description)";
                cmd.Parameters.AddWithValue("@Notice_Date", vo.Notice_Date);
                cmd.Parameters.AddWithValue("@Title", vo.Title);
                cmd.Parameters.AddWithValue("@Description", vo.Description);
                cmd.Connection.Open();

                isChecked = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            return isChecked == 1 ? true : false;
        }
    }
}

