using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class FindCategoryService
    {
        public List<FindCategoryVo> GetCategory(string catTable)
        {
            MenuTreeDac dac = new MenuTreeDac();
            return dac.GetCategory(catTable);
        }
    }
}
