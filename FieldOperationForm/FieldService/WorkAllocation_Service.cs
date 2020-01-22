﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public  class WorkAllocation_Service
    {
        public List<WorkAllocation_Vo> GetWorkerList(string Wc_Name)
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.GetWorkerList(Wc_Name);
        }


        public List<WorkAllocation_Vo> GetWorker(string Wc_Name)
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.GetWorker(Wc_Name);
        }

        public List<WorkAssignment_Vo> WorkAssignment(WorkAssignment_Vo item)
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.WorkAssignment(item);
        }


        public List<WorkAssignment_Vo> deleteWorker(string User_Name)
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.deleteWorker(User_Name);
        }
        public List<WorkAssignment_Vo> deleteAllWorker()
        {
            WorkAllocation_Dac dac = new WorkAllocation_Dac();
            return dac.deleteAllWorker();
        }
    }
}
