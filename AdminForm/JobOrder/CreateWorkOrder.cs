using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class CreateWorkOrder : Form
    {
        string pType;
        public CreateWorkOrder(string processType)
        {
            InitializeComponent();
            pType = processType;
            lblProcessName.Text = pType + "계획생성";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
