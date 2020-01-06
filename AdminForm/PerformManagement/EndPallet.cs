using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm.PerformManagement
{
    public partial class EndPallet : dgvTwo
    {
        public EndPallet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDetail udform = new UpdateDetail();
            if(udform.ShowDialog() == DialogResult.Yes)
            {

            }
        }
    }
}
