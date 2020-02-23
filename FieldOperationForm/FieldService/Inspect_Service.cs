using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Inspect_Service
    {

     
        public List<Inspect_Vo> deleteVal(Inspect_Vo item)
        {
            Inspect_Dac dac = new Inspect_Dac();
            return dac.deleteVal(item);
        }
        public List<InspectMaster_Vo> GetInspetMaster(string WoNo)
        {
            Inspect_Dac dac = new Inspect_Dac();
            return dac.GetInspectMasetr(WoNo);
        }
        public void InspectVal(string workorderNo, decimal val, string InspectGroup)
        {
            InsertCon_Dac dac = new InsertCon_Dac();
            dac.InsertInsepctVal(workorderNo, val, InspectGroup);
        }

        public List<InspectHisVo> GetInspectHis(string workorder, string inspect_group)
        {
            InsertCon_Dac dac = new InsertCon_Dac();
            return dac.GetInsepctVal(workorder, inspect_group);
        }
     
    }
}
