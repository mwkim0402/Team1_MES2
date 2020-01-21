using MES_API.Models.Perform;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MES_API.DAC.Perform
{
    public class PerformDAC
    {
        string conn = string.Empty;

        public PerformDAC()
        {
            conn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }
        public List<ProductListVO> GetProductListform()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(conn);
                cmd.CommandText = "ProductListSearch";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductListVO> list = Helper.DataReaderMapToList<ProductListVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}