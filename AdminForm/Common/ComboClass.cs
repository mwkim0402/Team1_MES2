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

        // 콤보에 선택된 데이터 key값
        //string value = comboBox1.SelectedValue.ToString();
        //string value = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
        public static void ComboBind(List<ComboItem> comboItem, ComboBox combo)
        {
            combo.DataSource = new BindingSource(comboItem, null);
            combo.DisplayMember = "comboText";
            combo.ValueMember = "comboValue";
            //combo.SelectedIndex = 1;
        }

        public static void DictionaryToComboBind(List<ComboItem> comboItem, ComboBox combo)
        {
            Dictionary<string, string> list = comboItem.ToDictionary(item => item.comboValue.ToString(), item => item.comboText);
            combo.DisplayMember = "Value";
            combo.ValueMember = "Key";
            combo.DataSource = new BindingSource(list, null);
        }
    }

    public class ComboItem
    {
        public string comboText { get; set; }
        public string comboValue { get; set; }
    }
}
