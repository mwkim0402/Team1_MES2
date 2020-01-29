using MES_DB.Vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class PerformDAC : ConnectionAccess
    {
        public List<WorkdiligenceStatusanalysisVO> AllWorkStatuseList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllWorkStatus";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkdiligenceStatusanalysisVO> list = Helper.DataReaderMapToList<WorkdiligenceStatusanalysisVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<PerformSearchVO> GetAllPerformSearch()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select w.Wo_Status,w.Workorderno,w.Plan_Date,i.Item_Code,i.Item_Name,w.Wc_Code,w.In_Qty_Main,w.Out_Qty_Main,w.Prd_Qty,w.Wc_Code,p.Process_code" +
                    " from WorkOrder w inner join Item_Master i on i.Item_Code = w.Item_Code inner join WorkCenter_Master wc on w.Wc_Code = wc.Wc_Code " +
                    "inner join Process_Master p on wc.Process_Code = p.Process_code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PerformSearchVO> list = Helper.DataReaderMapToList<PerformSearchVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<GVMonitoringVO> GetAllMonitoring()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select m.GV_Name,m.GV_Group,m.GV_Status, w.Workorderno , it.Item_Code, it.Item_Name , s.GV_Qty , s.Loading_time " +
                    "from WorkOrder w inner join Item_Master it on w.Item_Code = it.Item_Code inner join GV_Current_Status s on s.Workorderno = w.Workorderno inner join GV_Master m on m.GV_Code = s.GV_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<GVMonitoringVO> list = Helper.DataReaderMapToList<GVMonitoringVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<MaterialManage> GetAllMaterial()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select M.YYYY, M.Level_Code , I.Level_Name, M.Prd_Order ,M. Mat_LotNo from Mat_Lot_Master M inner " +
                    "join Item_Level_Master I on M.Level_Code = I.Level_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialManage> list = Helper.DataReaderMapToList<MaterialManage>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<RegFaultyVO> GetAllRegFaultyImage()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "AllRegFaultyForm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<RegFaultyVO> list = Helper.DataReaderMapToList<RegFaultyVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<QualityVO> GetAllQuality()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllQuality";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<QualityVO> list = Helper.DataReaderMapToList<QualityVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<RegProcessVO> GetAllRegProcess()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "AllRegProcessForm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<RegProcessVO> list = Helper.DataReaderMapToList<RegProcessVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<QulityInquiryVO> GetAllProcessInquiry()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select wk.Workorderno,wk.Plan_Date, P.Process_code, P.Process_name ,sp.Inspect_code,sp.Inspect_name 
                                    ,M.Item_Name, sp.USL, sp.SL,sp.LSL,I.Inspect_datetime ,I.Inspect_date, I.Inspect_val,wk.Wc_Code,wm.Wc_Name,wk.Item_Code
                                    from WorkOrder wk inner join Item_Master M on wk.Item_Code = M.Item_Code
                                    inner join Inspect_Measure_History I on I.Item_Code = M.Item_Code
                                    inner join Inspect_Spec_Master sp on sp.Item_Code = M.Item_Code
                                    inner join Process_Master p on sp.Process_Code = p.Process_code
                                    inner join WorkCenter_Master wm on wk.Wc_Code = wm.Wc_Code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<QulityInquiryVO> list = Helper.DataReaderMapToList<QulityInquiryVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
    }
}
