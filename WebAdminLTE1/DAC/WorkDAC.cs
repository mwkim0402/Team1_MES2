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
            string sql = @"select TOP 5 work_time, USER_NAME,a.Work_Date  from(
                            Select User_ID,DATEPART(mm, Work_Date) as Work_Date, sum(work_time) as work_time From Work_History
                            where Work_Date between '2020-02-01' and '2020-02-29'
                            group by User_ID,DATEPART(mm, Work_Date)) a, User_Master u
                            where a.User_ID = u.User_ID 
							order by work_time desc ";

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

        public List<ProceessCodeWorkVO> GetProcessList()
        {
            List<ProceessCodeWorkVO> list = new List<ProceessCodeWorkVO>();
            string sql = @"select Top 4 Process_Code,avg(work_time) as work_time from Work_History
                            group by Process_Code
                            order by work_time desc ";

            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    list = Helper.DataReaderMapToList<ProceessCodeWorkVO>(cmd.ExecuteReader());
                }
            }

            return list;
        }
    }
}