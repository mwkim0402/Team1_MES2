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
    public partial class SystemCodeCategory : dgvOneWithInput
    {
        public SystemCodeCategory()
        {
            InitializeComponent();
        }

        private void SystemCodeCategory_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "시스템 대분류 코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "시스템 대분류 명", "1", true, 180);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 200);
        }
    }
}
