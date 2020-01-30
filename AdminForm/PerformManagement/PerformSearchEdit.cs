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
    public partial class PerformSearchEdit : Form
    {
        string workNo;
        public PerformSearchEdit()
        {
            InitializeComponent();
        }
        public PerformSearchEdit(string WorkNum)
        {
            workNo = WorkNum;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //수정하기
        }
    }
}
