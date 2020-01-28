using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class PerformSearchVO
    {
        public string Wo_Status { get; set; }
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Wc_Code { get; set; }
        public int In_Qty_Main { get; set; }
        public int Out_Qty_Main { get; set; }
        public int Prd_Qty { get; set; }
        public DateTime Plan_Date { get; set; }
        public string Process_code { get; set; }
    }

    public class GVMonitoringVO
    {
        public string GV_Name { get; set; }
        public string GV_Group { get; set; }
        public string GV_Status { get; set; }
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public int GV_Qty { get; set; }
        public DateTime Loading_time { get; set; }
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
    }
}
