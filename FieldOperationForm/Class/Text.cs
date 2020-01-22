using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace FieldOperationForm
{
    public partial class Text:TextBox
    {
        [DefaultValue(false)]
        [Browsable(true)]

        public override bool AutoSize
        {
            get { return base.AutoSize;}
            set { base.AutoSize = value; }

        }

        public Text()
        {
            this.AutoSize = false;
        }
    }
}
