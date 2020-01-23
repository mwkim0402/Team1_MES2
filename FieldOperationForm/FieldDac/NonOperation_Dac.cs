using FieldOperationForm.FieldVo;
using MES_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
  public  class NonOperation_Dac: ConnectionAccess
    {
        public List<NonOperation_Vo>AllNonOperation()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "AllNonOperation";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<NonOperation_Vo> list = Helper.DataReaderMapToList<NonOperation_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<NonOperation_Vo>GetMa_NameList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetMa_NameList";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<NonOperation_Vo> list = Helper.DataReaderMapToList<NonOperation_Vo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

    }
}
