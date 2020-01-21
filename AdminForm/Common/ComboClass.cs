using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public class ComboClass
    {
        public void ComboBind(List<ComboItem> t, ComboBox combo)
        {
            Dictionary<string, string> comboList = new Dictionary<string, string>();
            foreach (var list in t)
            {
                comboList.Add(list.comboText, list.comboValue);
            }
            combo.DataSource = new BindingSource(comboList, null);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";                  
        }

    }

    public class ComboItem
    {
        public string comboText { get; set; }
        public string comboValue { get; set; }
    }
}
