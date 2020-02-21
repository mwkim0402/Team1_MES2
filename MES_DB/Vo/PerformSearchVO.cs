using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ProductListVO
    {
        public DateTime In_Date { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Pallet_No { get; set; }
        public int Prd_Qty { get; set; }
        //public DateTime Closed_Time { get; set; }
        //public DateTime Cancel_Time { get; set; }
        public string Upload_Flag { get; set; }
        public string Workorderno { get; set; }
        public string Wo_Status { get; set; }
    }
    public class PerformSearchVO
    {
        public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Wc_Code { get; set; }
        public int In_Qty_Main { get; set; }
        public int Bad_Qty { get; set; }
        public int Prd_Qty { get; set; }
        public DateTime Plan_Date { get; set; }
        public string Process_code { get; set; }
        public string Faulty { get; set; }
    }

    public class WorkCenterVO
    {
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public string Wc_Group { get; set; }
        public string Wo_Status { get; set; }
        public DateTime Prd_Starttime { get; set; }
        public DateTime Prd_Endtime { get; set; }
    }

    public class MaterialManage
    {
        public string YYYY { get; set; }
        public string Level_Code { get; set; }
        public string Level_Name { get; set; }
        public int Prd_Order { get; set; }
        public string Mat_LotNo { get; set; }
    }

    public class RegFaultyVO
    {
        public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Wc_Name { get; set; }
        public DateTime Plan_Date { get; set; }
        public int Prd_Qty { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Def_Ma_Code { get; set; }
        public string Def_Mi_Code { get; set; }
        public DateTime Def_Date { get; set; }
        public int Def_Qty { get; set; }
        public string Def_Image_Name { get; set; }
        public string Process_name { get; set;}
        public int workImageCount { get; set; }
        public byte[] Def_Image { get; set; }
        public int Def_Seq { get; set; }
    }

    public class RegFaultyVODetail
    {
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Def_Ma_Code { get; set; }
        public string Def_Mi_Code { get; set; }
        public DateTime Def_Date { get; set; }
        public int Def_Qty { get; set; }
        public string Def_Image_Name { get; set; }
        public byte[] Def_Image { get; set; }
    }
}
