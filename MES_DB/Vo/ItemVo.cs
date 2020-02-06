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
        public decimal RollingUPH { get; set; }
        public decimal SteelUPH { get; set; }
        public decimal IronUPH { get; set; }
        public decimal PackageUPH { get; set; }
        public decimal Item_Stock { get; set; }

        public string Remark { get; set; }
    }
    public class ItemUPH
    {
        public decimal RollingUPH { get; set; }
        public decimal SteelUPH { get; set; }
        public decimal IronUPH { get; set; }
        public decimal PackageUPH { get; set; }
    }
}
