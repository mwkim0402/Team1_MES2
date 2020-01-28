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
    }
}
