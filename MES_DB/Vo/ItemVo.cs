using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ItemGroupVo
    {
        public string Level_Code { get; set; }
        public string Level_Name { get; set; }
        public string Level { get; set; }
        public int PCS_Qty { get; set; }
        public decimal Mat_Qty { get; set; }
        public string Use_YN { get; set; }
    }
    public class ItemGroupCombo
    {
        public string Level_Code { get; set; }
        public string Level_Name { get; set; }
        public string Level { get; set; }
    }
    public class ItemVo
    {
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Item_Name_Eng { get; set; }
        public string Item_Name_Eng_Alias { get; set; }
        public string Item_Type { get; set; }
        public string Item_Spec { get; set; }
        public string Item_Unit { get; set; }
        public string Level_1 { get; set; }
        public string Level_2 { get; set; }
        public string Level_3 { get; set; }
        public string Level_4 { get; set; }
        public string Level_5 { get; set; }
        public decimal Item_Stock { get; set; }
        public decimal LotSize { get; set; }
        public decimal PrdQty_Per_Hour { get; set; }
        public decimal PrdQTy_Per_Batch { get; set; }
        public int Cavity { get; set; }
        public int Line_Per_Qty { get; set; }
        public int Shot_Per_Qty { get; set; }
        public int Dry_GV_Qty { get; set; }
        public int Heat_GV_Qty { get; set; }
        public string Remark { get; set; }
    }
}
