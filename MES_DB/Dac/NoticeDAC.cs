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
    }
}

