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
    public partial class ERPInterfaceLog : dgvOne
    {
        public ERPInterfaceLog()
        {
            InitializeComponent();
        }

        private void ERPInterfaceLog_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "순번", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "유형", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "성공여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "실행프로시저", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Target 정보", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Source 정보", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Message", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "인터페이스 시각", "1", true, 100);
        }
    }
}
