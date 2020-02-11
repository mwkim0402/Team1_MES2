using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Item_Service
    {
        public List<Item_Vo> GetItemName()
        {
            Item_Dac dac = new Item_Dac();
            return dac.GetItemName();
        }

    }
}
