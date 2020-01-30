using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class QualityDAC : ConnectionAccess
    {
        public List<QualityInquiryVO> GetQulityInquiryForm()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select wk.Workorderno,wk.Plan_Date,P.Process_code, P.Process_name,sp.Inspect_code,sp.Inspect_name,sp.USL,sp.SL,sp.LSL,I.Inspect_datetime,M.Item_Code,M.Item_Name, I.Inspect_date , I.Inspect_measure_seq , I.Inspect_val,wk.Wc_Code,wm.Wc_Name
                                    from WorkOrder wk inner join Item_Master M on wk.Item_Code = M.Item_Code
                                    inner join Inspect_Spec_Master sp on sp.Item_Code = wk.Item_Code
                                    inner join Inspect_Measure_History I on I.WorkOrderNo = wk.Workorderno
                                    inner join Process_Master P on I.Process_Code = P.Process_code
                                    inner join WorkCenter_Master wm on wk.Wc_Code = wm.Wc_Code";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<QualityInquiryVO> list = Helper.DataReaderMapToList<QualityInquiryVO>(reader);

                cmd.Connection.Close();
                return list;

            }
        }
    }
}
