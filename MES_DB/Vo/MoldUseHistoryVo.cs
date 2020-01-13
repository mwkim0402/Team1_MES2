using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class MoldUseHistoryVo
    {
         public string  Mold_Code      {get;set;}
         public string  Mold_Name      {get;set;}
         public string  Workorderno    {get;set;}
         public string  Item_Code      {get;set;}
         public string  Item_Name      {get;set;}
         public string  Wc_Code        {get;set;}
         public string  Wc_Name        {get;set;}
         public int  Mold_Shot_Cnt  {get;set;}
         public int Mold_Prd_Qty   {get;set;}
         public DateTime  Use_Starttime  {get;set;}
         public DateTime Use_Endtime    {get;set;}
         public DateTime UsingTime { get; set; }
    }
}
