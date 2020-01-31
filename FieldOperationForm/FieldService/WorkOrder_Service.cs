using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class WorkOrder_Service
    {

        public List<WorkOrder_Vo> InsertWorkOrder(WorkOrder_Vo item)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.InsertWorkOrder(item);
        }

        public List<WorkOrder_Vo> GetWorkOrder(string Wc_Name)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.GetWorkOrder(Wc_Name);
        }
        public List<WorkOrder_Vo> StartWork(string Workorderno)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.StartWork(Workorderno);
        }
        public List<WorkOrder_Vo> EndWork(string Workorderno)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.EndWork(Workorderno);
        }

        public List<WorkOrder_Vo>GetTextWorkOrder(string Workorderno)
        {
            WorkOrder_Dac dac = new WorkOrder_Dac();
            return dac.GetTextWorkOrder(Workorderno);
        }
    }
}
