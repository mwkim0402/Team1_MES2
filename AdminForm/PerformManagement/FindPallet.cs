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
    public partial class FindPallet : Form
    {
        public FindPallet()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindPallet_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "팔레트번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "팔레트 등급", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "수량", "1", true, 100);
        }
    }
}
