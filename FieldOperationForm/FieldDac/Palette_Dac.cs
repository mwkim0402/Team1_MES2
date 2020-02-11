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
    public class Palette_Dac : ConnectionAccess
    {
        public List<Palette_Vo> PaletteList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "PaletteList";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Palette_Vo> list = Helper.DataReaderMapToList<Palette_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public List<PaletteDetail_Vo>GetPaletteDetail (string Pallet_No )
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetPaletteDetail";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Pallet_No", Pallet_No);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PaletteDetail_Vo> list = Helper.DataReaderMapToList<PaletteDetail_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }



                }
            }
}
