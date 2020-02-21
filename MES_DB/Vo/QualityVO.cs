using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class InsQualityVO
    {
        public string Item_Code { get; set; }
        public string Process_Code { get; set; }
        public string Inspect_Code { get; set; }
        public decimal Inspect_Val { get; set; }
        public string WorkOrderNo { get; set; }
    }
    public class QualityVO
    {
       public string Workorderno { get; set; }
       public string Process_code { get; set; }
       public string Process_name { get; set; }
       public string Inspect_code { get; set; }
       public string Inspect_name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
       public DateTime Inspect_Datetime { get; set; }
       public decimal SL { get; set; }
       public DateTime Plan_Date { get; set; }
       public string Wc_Code { get; set; }
       public string Wc_Name { get; set; }
        public decimal deviation { get; set; }
        public long Inspect_Measure_seq { set; get; }
        public decimal Inspect_Val { get; set; }
    }

    public class QualityDetailVO
    {
        public string Inspect_name { get; set; }
        public decimal SL { get; set; }
    }
    public class QualityDetailDeterVO
    {
        public DateTime Inspect_Datetime { get; set; }
        public string Item_Name { get; set; }
        public string Item_Code { get; set; }
        public decimal deviation { get; set; }
        public decimal Inspect_Val { get; set; }
    }

    public class RegProcessVO
    {
        public string Workorderno { get; set; }
        public DateTime Plan_Date { get; set; }
        public string Process_code { get; set; }
        public string Process_name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Condition_Name { get; set; }
        public decimal SL { get; set; }
        //public DateTime Condition_Datetime { get; set; }
        public decimal Condition_Val { get; set; }
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public long Condition_measure_seq { get; set; }


    }
    public class RegProcessListVO
    {
        public string Condition_Name { get; set; }
        public decimal SL { get; set; }
    }
    public class RegProcessListMeaVO
    {
        public decimal Condition_Val { get; set; }
    }



    public class ProcessInquiryVO
    {
       public string Workorderno { get; set; }
       public DateTime Plan_Date { get; set; }
        public string Process_name { get; set; }
        public string Wc_Name { get; set; }
        public string Condition_Name { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
        public DateTime Condition_Date { get; set; }
        public DateTime Condition_Datetime { get; set; }
        public decimal Condition_Val { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
    }

    public class QualityInquiryVO
    {
       public string Workorderno { get; set; }
       public DateTime Plan_Date { get; set; }
        public string Process_code { get; set; }
        public string Process_name { get; set; }
        public string Inspect_code { get; set; }
        public string Inspect_name { get; set; }
        public decimal USL { get; set; }
        public decimal SL { get; set; }
        public decimal LSL { get; set; }
        public DateTime Inspect_datetime { get; set; }
        public string Item_Code{ get; set; }
       public string Item_Name { get; set; }
        public DateTime Inspect_date { get; set; }
        public long Inspect_measure_seq { get; set; }
        public decimal Inspect_val { get; set; }
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
    }

    public class ItemCodeListVO
    {
        public string Item_Code { get; set; }
        public string type { get; set; }

    }

    public class ProCodeVo
    {
       public string Process_name { get; set; }
    }
        

}
