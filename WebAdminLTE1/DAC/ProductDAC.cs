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
        public List<Product> GetProducts(int page,int pageSize,string category)
        {
            List<Product> list = new List<Product>();
            string sql ="GetProductList";
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
                        cmd.Parameters.AddWithValue("@Category", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Category", category);

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
                string sql = "select count(*) totCount from Products where (Category = @Category or isnull(@Category,'')='')";

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (category == null)
                        cmd.Parameters.AddWithValue("@Category", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Category", category);

                    iTotCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iTotCount;
        }


        public List<string> GetProductCategory()
        {
            List<string> list = new List<string>();
            string sql = "select distinct Category From Products order by Category";
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


        public Product GetProductInfo(int productID)
        {
            List<Product> list = null;
            string sql = "select ProductID ,Name, Price,Description,Category" +
                " From Products Where ProductID = @ProductID"; 
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
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