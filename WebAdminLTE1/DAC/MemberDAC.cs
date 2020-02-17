using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using WebApplication0106.Models;

namespace WebApplication0106.DAC
{
    public class MemberDAC : IDisposable
    {
        string strconn = string.Empty;
        public MemberDAC()
        {
            strconn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;


        }
        public List<MemberPermi> GetWorkerCount()
        {
            List<MemberPermi> list = new List<MemberPermi>();
            string sql = @"select  ug.UserGroup_Name,count(*) UserCnt
                            from User_Master u,UserGroup_Mapping map, UserGroup_Master ug
                            where u.User_ID = map.User_ID
                            and map.UserGroup_Code = ug.UserGroup_Code
                            group by ug.UserGroup_Name"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    list = Helper.DataReaderMapToList<MemberPermi>(cmd.ExecuteReader());
                }
            }

            return list;
        }
        public int GetWorkTimeAVG()
        {
            int iTotCount = 0;
            string sql = @"select AVG(Work_Time) from Work_History";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return iTotCount;
        }
        public void Dispose()
        {

        }
    }
}