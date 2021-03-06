﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MES_DTO;
using System.Web.Configuration;

namespace MES_API.DAC
{
    public class MoldingDac
    {
        string ConnectionString = string.Empty;
        public MoldingDac()
        {
            ConnectionString = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }
        public List<MoldingInfoVo> GetMoldingInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "Select Mold_Code,Mold_Name,Mold_Group,Mold_Status,Cum_Shot_Cnt,Cum_Prd_Qty,Cum_Time,Guar_Shot_Cnt,Purchase_Amt,In_Date,Last_Setup_Time,Remark,Use_YN from Mold_Master";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldingInfoVo> list = Helper.DataReaderMapToList<MoldingInfoVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }
        public List<MoldUseHistoryVo> MoldUseHistory()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConnectionString);
                cmd.CommandText = "MoldUseHistory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseHistoryVo> list = Helper.DataReaderMapToList<MoldUseHistoryVo>(reader);
                cmd.Connection.Close();
                return list;
            }
        }

    }
}
