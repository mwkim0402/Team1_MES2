using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm 
{
   public class PackageEnd_Service
    {
        public int EndPackage(string Workorderno)
        {
            PackageEnd_Dac dac = new PackageEnd_Dac();
            return dac.EndPackage(Workorderno);
        }
    }
}
