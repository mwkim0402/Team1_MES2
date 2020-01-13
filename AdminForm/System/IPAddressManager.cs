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
    public partial class IPAddressManager : dgvOneWithInput
    {
        public IPAddressManager()
        {
            InitializeComponent();
        }

        private void IPAddressManager_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "IP Address", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "허용여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
        }
    }
}
