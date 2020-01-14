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
    public partial class GASUsingRegister : dgvOne
    {
        public GASUsingRegister()
        {
            InitializeComponent();
        }

        private void GASUsingRegister_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기준일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "GAS사용량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기숙사GAS사용량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }
    }
}
