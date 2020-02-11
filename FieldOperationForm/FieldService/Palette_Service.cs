using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
   public class Palette_Service
    {

        public List<Palette_Vo> PaletteList( )
        {
            Palette_Dac dac = new Palette_Dac();
            return dac.PaletteList();
        }

        public List<PaletteDetail_Vo> GetPaletteDetail(string Pallet_No)
        {
            Palette_Dac dac = new Palette_Dac();
            return dac.GetPaletteDetail(Pallet_No);
        }
    }
}
