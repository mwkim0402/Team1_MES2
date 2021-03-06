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
        public List<ProductListVO> GetProductListform()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "ProductListSearch";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductListVO> list = Helper.DataReaderMapToList<ProductListVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

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
                cmd.CommandText = "GetAllPerformSearch ";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PerformSearchVO> list = Helper.DataReaderMapToList<PerformSearchVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public List<WorkCenterVO> GetAllWorkCenter()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select m.Wc_Code,m.Wc_Name,m.Wc_Group,m.Wo_Status,Max(w.Prd_Starttime)as Prd_Starttime,Max(w.Prd_Endtime) as Prd_Endtime
                                    from WorkCenter_Master m inner join WorkOrder w on m.Wc_Code = w.Wc_Code group by m.Wc_Code ,m.Wc_Name,m.Wc_Group,m.Wo_Status ";
                cmd.CommandType = CommandType.Text;


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);
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

        public List<RegFaultyVO> GetImage(int seq)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "select Def_Image from Def_History where Def_Seq = @Def_Seq";
                cmd.CommandType = CommandType.Text;


                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@Def_Seq", seq);
                SqlDataReader reader = cmd.ExecuteReader();
                List<RegFaultyVO> list = Helper.DataReaderMapToList<RegFaultyVO>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

        public void InsFaltyImage(string fileName, byte[] img, string WorkOderNo, int faultyNum)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "InsertFaultyImage";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@WorkOderNo", WorkOderNo);
                cmd.Parameters.AddWithValue("@fileName", fileName);
                cmd.Parameters.AddWithValue("@Def_Image", img);
                cmd.Parameters.AddWithValue("@Def_Qty", faultyNum);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

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

        public void UpdateRegQulityForm(int num, int seq)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update Inspect_Measure_History set Inspect_Val = @Inspect_Val where Inspect_Measure_seq = @Inspect_Measure_seq";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Inspect_Val", num);
                cmd.Parameters.AddWithValue("@Inspect_Measure_seq", seq);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public void DeleteRegUqlityForm(int num)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "delete from Inspect_Measure_History where Inspect_Measure_seq = @InspInspect_Measure_seq ";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@InspInspect_Measure_seq", num);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
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


        public void UpdateRegProcess(decimal value, int pk)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "update Condition_Measure_History set Condition_Val = @Condition_Val where Condition_measure_seq = @Condition_measure_seq";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Condition_Val", value);
                cmd.Parameters.AddWithValue("@Condition_measure_seq", pk);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        public void DeleteRegProcess(int pk)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "delete from Condition_Measure_History where Condition_measure_seq = @Condition_measure_seq";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Condition_measure_seq", pk);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public List<ProcessInquiryVO> GetAllProcessInquiry()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = @"select w.Workorderno,w.Plan_Date,p.Process_name,wm.Wc_Name,c.Condition_Name,c.USL,c.SL,c.LSL,ch.Condition_Date,ch.Condition_Datetime,ch.Condition_Val,i.Item_Code,i.Item_Name from WorkOrder w 
                                    inner join Condition_Measure_History ch on ch.Workorderno = w.Workorderno
                                    inner join Condition_Spec_Master c on c.Condition_Code = ch.Condition_Code
                                    inner join WorkCenter_Master wm on wm.Wc_Code = w.Wc_Code
                                    inner join Process_Master p on wm.Process_Code = p.Process_code
                                    inner join Item_Master i on i.Item_Code = w.Item_Code ";
                cmd.CommandType = CommandType.Text;


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
                cmd.Parameters.AddWithValue("@Bad_Qty", edit.Bad_Qty);
                cmd.Parameters.AddWithValue("@Prd_Qty", edit.Prd_Qty);
                cmd.Parameters.AddWithValue("@Plan_Date", edit.Plan_Date);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }
    }
}
