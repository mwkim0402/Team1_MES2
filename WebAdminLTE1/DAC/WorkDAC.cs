using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebAdminLTE1.Models;
using WebApplication0106.DAC;

namespace WebAdminLTE1.DAC
{
    public class WorkDAC
    {

        string strconn = string.Empty;
        public WorkDAC()
        {
            strconn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<WorkVO> GetAllWork()
        {
            List<WorkVO> list = new List<WorkVO>();
            string sql = @"select a.USER_ID, USER_NAME,a.Work_Date, work_time
                        from(select USER_ID, sum(isnull(Work_Time, 0)) work_time, (Month(Work_Date)) as Work_Date from Work_History group by User_ID, MONTH(Work_Date)) a, User_Master u
                        where a.User_ID = u.User_ID";

            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    list = Helper.DataReaderMapToList<WorkVO>(cmd.ExecuteReader());
                }
            }

            return list;
        }
    }
}