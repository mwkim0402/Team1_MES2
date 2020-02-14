using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class CreatePalette_Service
    {
        public List<CreatePalette_Vo> CreatePalette(CreatePalette_Vo item)
        {
            CreatePalette_Dac dac = new CreatePalette_Dac();
            return dac.CreatePalette(item);
        }

    }
}
