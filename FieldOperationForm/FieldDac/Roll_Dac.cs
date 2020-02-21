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
    public class Roll_Dac : ConnectionAccess
    {
    

        public List<Roll_Vo>getRollWork()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "getRollWork";
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Roll_Vo> list = Helper.DataReaderMapToList<Roll_Vo>(reader);
                cmd.Connection.Close();

                foreach (var item in list)
                {
                    if (item.Wo_Status == "현장마감")
                    {
                        item.Mold_Name = null;
                    }
                }


                return list;


            }

        }

    }
}
