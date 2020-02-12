﻿using MES_DB.Vo;
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
        public List<ProductListVO> GetProductListform(DateTime Start,DateTime End)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "ProductListSearch";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Startdate", Start);
                cmd.Parameters.AddWithValue("@Enddate", End);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductListVO> list = Helper.DataReaderMapToList<ProductListVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<WorkdiligenceStatusanalysisVO> AllWorkStatuseList(DateTime Start, DateTime End)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllWorkStatus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", Start);
                cmd.Parameters.AddWithValue("@Enddate", End);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkdiligenceStatusanalysisVO> list = Helper.DataReaderMapToList<WorkdiligenceStatusanalysisVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<PerformSearchVO> GetAllPerformSearch(DateTime Start,DateTime End)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select w.Wo_Status,w.Workorderno,w.Plan_Date,i.Item_Code,i.Item_Name,w.Wc_Code,w.In_Qty_Main,w.Out_Qty_Main,w.Prd_Qty,w.Wc_Code,p.Process_code
                     from WorkOrder w inner join Item_Master i on i.Item_Code = w.Item_Code inner join WorkCenter_Master wc on w.Wc_Code = wc.Wc_Code
                    inner join Process_Master p on wc.Process_Code = p.Process_code 
                    where w.Plan_Date between @Startdate and DateAdd(dd,1,@Enddate) ";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Startdate", Start);
                cmd.Parameters.AddWithValue("@Enddate", End);
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

        public List<RegFaultyVO> GetAllRegFaultyImage(DateTime start, DateTime end)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "AllRegFaultyForm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", start);
                cmd.Parameters.AddWithValue("@EndDate", end);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<RegFaultyVO> list = Helper.DataReaderMapToList<RegFaultyVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public void InsFaltyImage(string fileName, string filePath, string WorkOderNo, int faultyNum)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsertFaultyImage";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@WorkOderNo", WorkOderNo);
                cmd.Parameters.AddWithValue("@fileName", fileName);
                cmd.Parameters.AddWithValue("@filePath", filePath);
                cmd.Parameters.AddWithValue("@Def_Qty", faultyNum);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

            }
        }

        public List<QualityVO> GetAllQuality(DateTime start, DateTime end)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "GetAllQuality";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", start);
                cmd.Parameters.AddWithValue("@EndDate", end);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<QualityVO> list = Helper.DataReaderMapToList<QualityVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<RegProcessVO> GetAllRegProcess(DateTime start, DateTime end)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "AllRegProcessForm";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StartDate", start);
                cmd.Parameters.AddWithValue("@EndDate", end);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<RegProcessVO> list = Helper.DataReaderMapToList<RegProcessVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<ProcessInquiryVO> GetAllProcessInquiry(DateTime Start,DateTime End)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select w.Workorderno,w.Plan_Date,p.Process_name,wm.Wc_Name,c.Condition_Name,c.USL,c.SL,c.LSL,ch.Condition_Date,ch.Condition_Datetime,ch.Condition_Val,i.Item_Code,i.Item_Name from WorkOrder w 
                                    inner join Condition_Measure_History ch on ch.Workorderno = w.Workorderno
                                    inner join Condition_Spec_Master c on c.Condition_Code = ch.Condition_Code
                                    inner join WorkCenter_Master wm on wm.Wc_Code = w.Wc_Code
                                    inner join Process_Master p on wm.Process_Code = p.Process_code
                                    inner join Item_Master i on i.Item_Code = w.Item_Code 
                                    where w.Plan_Date between @Startdate and DateAdd(dd,1,@Enddate)";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Startdate", Start);
                cmd.Parameters.AddWithValue("@Enddate", End);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessInquiryVO> list = Helper.DataReaderMapToList<ProcessInquiryVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public void EditPerformSearch(PerformSearchVO edit)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"update WorkOrder 
                                    set Wo_Status = @Wo_Status, Workorderno = @Workorderno, Item_Code = @Item_Code,
                                    Wc_Code=@Wc_Code, In_Qty_Main=@In_Qty_Main,
                                    Out_Qty_Main=@Out_Qty_Main, Prd_Qty=@Prd_Qty, Plan_Date=Convert(date,@Plan_Date)
                                    from WorkOrder w
                                         inner join Item_Master i 
                                    	 on w.Item_Code = i.Item_Code
                                    where Workorderno = @Workorderno ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Wo_Status", edit.Wo_Status);
                cmd.Parameters.AddWithValue("@Workorderno", edit.Workorderno);
                cmd.Parameters.AddWithValue("@Item_Code", edit.Item_Code);
                cmd.Parameters.AddWithValue("@Wc_Code", edit.Wc_Code);
                cmd.Parameters.AddWithValue("@In_Qty_Main", edit.In_Qty_Main);
                cmd.Parameters.AddWithValue("@Out_Qty_Main", edit.Out_Qty_Main);
                cmd.Parameters.AddWithValue("@Prd_Qty", edit.Prd_Qty);
                cmd.Parameters.AddWithValue("@Plan_Date", edit.Plan_Date);
                
                
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                
            }
        }
    }
}
