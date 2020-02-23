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
    public class InsertCon_Dac: ConnectionAccess
    {
        public List<InsertCon_Vo>InsertInspect (InsertCon_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "InsertInspect";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
                cmd.Parameters.AddWithValue("@Condition_Val", item.Condition_Val);
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                cmd.Parameters.AddWithValue("@Condition_Group", item.Condition_Group);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InsertCon_Vo> list = Helper.DataReaderMapToList<InsertCon_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }

        }
        public List<InsertCon_Vo>GetConditionVal(InsertCon_Vo item)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "GetConditionVal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);
               
                cmd.Parameters.AddWithValue("@Wc_Name", item.Wc_Name);
                cmd.Parameters.AddWithValue("@Condition_Group", item.Condition_Group);
            

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InsertCon_Vo> list = Helper.DataReaderMapToList<InsertCon_Vo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }
        public List<InspectHisVo> GetInsepctVal(string workOrderNo, string Insepct_Group)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select Inspect_Group, Inspect_Datetime, Inspect_Val
                                                from Inspect_Measure_History
                                                    where inspect_Group = @Inpsect_Group
                                                    and WorkOrderNo = @WorkOrderNo";

                cmd.Parameters.AddWithValue("@Inpsect_Group", Insepct_Group);

                cmd.Parameters.AddWithValue("@WorkOrderNo", workOrderNo);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InspectHisVo> list = Helper.DataReaderMapToList<InspectHisVo>(reader);
                cmd.Connection.Close();

                return list;


            }
        }

        public void InsertInsepctVal(string Workorderno, decimal val, string inspect_group)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"insert into Inspect_Measure_History(Item_Code, Process_Code, Inspect_Val, WorkOrderNo, Inspect_Group, Inspect_Datetime)
                values((select Item_Code from WorkOrder where Workorderno = @WorkOrderNo), 
                (select Process_Code
                 from WorkCenter_Master wc inner join WorkOrder wo on wc.Wc_Code = wo.Wc_Code
                  where wo.Workorderno = @WorkOrderNo), @Inspect_Val, @WorkOrderNo, @Inspect_Group, @Date)";
                cmd.Parameters.AddWithValue("@WorkOrderNo", Workorderno);
                cmd.Parameters.AddWithValue("@Inspect_Val", val );
                cmd.Parameters.AddWithValue("@Inspect_Group", inspect_group);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();


            }
        }
    }
}
