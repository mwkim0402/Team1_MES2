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
    public class ProductDAC :IDisposable
    {
        string strconn = string.Empty;
        public ProductDAC()
        {
            strconn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;


        }
        public List<Product> GetList(int page,int pageSize,string category)
        {
            List<Product> list = new List<Product>();
            string sql ="GetWorkCenterList";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Page_No", page);
                    cmd.Parameters.AddWithValue("@Page_Size", pageSize);

                    //방법1
                    if (category == null)
                        cmd.Parameters.AddWithValue("@WC_Group", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@WC_Group", category);

                    //방법2
                //    cmd.Parameters.AddWithValue("@Category", (category == null) ? string.Empty : category);
               

                    list = Helper.DataReaderMapToList<Product>(cmd.ExecuteReader());
                }
            }
            
                return list;
        }
        public int GetProductTotalCount(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = "select count(*) totCount from WorkCenter_Master where (WC_Group = @WC_Group or isnull(@WC_Group,'')='')";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (category == null)
                        cmd.Parameters.AddWithValue("@WC_Group", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@WC_Group", category);

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }

        public int GetWorkCenterCount(string category)
        {
            int iTotCount = 0;
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                string sql = "select count(*) 작업장수 from WorkCenter_Master where Wc_group = @WC_Group group by Wc_Group";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (category == null)
                        cmd.Parameters.AddWithValue("@WC_Group", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@WC_Group", category);

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }


        public List<string> GetProductCategory()
        {
            List<string> list = new List<string>();
            string sql = "select distinct WC_Group From WorkCenter_Master order by WC_Group";
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }

                }
            }
            return list;
        }


        public Product GetProductInfo(string wcCode)
        {
            List<Product> list = null;
            string sql = "select Wc_Code, Wc_Name, Wc_Group, Process_Code, Wo_Status from WorkCenter_Master" +
                "Where Wc_Code = @Wc_Code"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);
                    list = Helper.DataReaderMapToList<Product>(cmd.ExecuteReader());
                }
            }
            return (list == null) ? null : list[0];
        }


        public void Dispose()
        {

        }
    }
}