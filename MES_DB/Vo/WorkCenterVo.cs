using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class WorkCenterVo
    {
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public string Wc_Group { get; set; }
        public string Process_Code { get; set; }   
        public string Wo_Status { get; set; }

        public string Prd_Req_Type { get; set; }
        public string Pallet_YN { get; set; }
        public string Prd_Unit { get; set; }
        public string Mold_Setup_YN { get; set; }
        public string Use_YN { get; set; }
        public string Remark { get; set; }
    }
}
