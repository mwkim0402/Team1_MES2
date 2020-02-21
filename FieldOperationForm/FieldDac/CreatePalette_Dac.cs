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
  public  class CreatePalette_Dac : ConnectionAccess
    {
        public List<CreatePalette_Vo> CreatePalette(CreatePalette_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "CreatePalette";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Workorderno ", item.Workorderno);
                cmd.Parameters.AddWithValue("@Pallet_No", item.Pallet_No);
                cmd.Parameters.AddWithValue("@Prd_Qty", item.Prd_Qty);
             //   cmd.Parameters.AddWithValue("@Pallet_Qty", item.Pallet_Qty);
                cmd.Parameters.AddWithValue("@Grade_Code", item.Grade_Code);
                cmd.Parameters.AddWithValue("@Size_Code", item.Size_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", item.Grade_Detail_Code);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<CreatePalette_Vo> list = Helper.DataReaderMapToList<CreatePalette_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }



        public void CreatePalette_each(int num, string gradecode, CreatePalette_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = $"select Top {num} Pallet_No from Palette_Master where Grade_Code=@Grade_Code";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Grade_Code", gradecode);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                cmd.Connection.Close();
                

                foreach (var item1 in list)
                {
                    using (SqlCommand cmd1 = new SqlCommand())
                    {
                        cmd1.Connection = new SqlConnection(this.ConnectionString);
                        cmd1.CommandText = $@"INSERT INTO Goods_In_History (Workorderno,Pallet_No,Barcode_No,Print_Date,Grade_Code,Size_Code,Grade_Detail_Code,Prd_Qty,In_YN) values
                                                            (@Workorderno, @Pallet_No, (select RIGHT('0000' + cast(Pallet_No as varchar(4)) + Right(Convert(varchar(50), Getdate(), 112), 4) +
                                                            (select right('00000' + Convert(varchar(5), COUNT(*) + 1), 5) from Goods_In_History ), '13')
                                                            from Palette_Master p,WorkOrder w where Workorderno = @Workorderno and Pallet_No = @Pallet_No),GETDATE(),@Grade_Code1,@Size_Code,@Grade_Detail_Code,@Prd_Qty,'N')";
                        cmd1.CommandType = CommandType.Text;
                        cmd1.Parameters.AddWithValue("@Workorderno ", item.Workorderno);
                        cmd1.Parameters.AddWithValue("@Pallet_No", item1.Pallet_No);
                        cmd1.Parameters.AddWithValue("@Prd_Qty", item.Prd_Qty);
                        cmd1.Parameters.AddWithValue("@Grade_Code1", item.Grade_Code);
                        cmd1.Parameters.AddWithValue("@Size_Code", item.Size_Code);
                        cmd1.Parameters.AddWithValue("@Grade_Detail_Code", item.Grade_Detail_Code);
                        cmd1.Connection.Open();
                        cmd1.ExecuteNonQuery();
                      
                        cmd1.Connection.Close();
                    }
                }
                

                
            }

        }
    }
}
