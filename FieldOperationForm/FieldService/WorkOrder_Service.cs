using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class WorkOrder_Service
    {

    

        public List<WorkOrder_Vo> GetWorkOrder(string Wc_Name)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.GetWorkOrder(Wc_Name);
        }
  

        public List<WorkOrder_Vo>GetTextWorkOrder(string Workorderno)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.GetTextWorkOrder(Workorderno);
        }

        public List<WorkOrder_Vo> IronWork()
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.IronWork();
        }
        public List<WorkOrder_Vo>deadlineWork(string Workorderno)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.deadlineWork(Workorderno);
        }
    }
}
