using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class ItemService
    {
        public List<ItemGroupVo> GetAllItem()
        {
            ItemDAC dac = new ItemDAC();
            return dac.GetAllItemGroup();
        } 
        public List<ItemVo> GetAllItemInfo()
        {
            ItemDAC dac = new ItemDAC();
            return dac.GetAllItemIfno();
        }
        public List<ItemGroupCombo> GetItemGroupCombo()
        {
            ItemDAC dac = new ItemDAC();
            return dac.GetItemGroupCB();
        }

        public bool InsertItemInfo(ItemVo vo)
        {
            ItemDAC dac = new ItemDAC();
            return dac.InsertItemIfno(vo);
        }

        public bool DeleteItemInfo(string id)
        {
            ItemDAC dac = new ItemDAC();
            return dac.DeleteItemInfo(id);
        }
        public List<ItemUPH> ItemUph(string itemName)
        {
            ItemDAC dac = new ItemDAC();
            return dac.ItemUph(itemName);
        }
    }
}
