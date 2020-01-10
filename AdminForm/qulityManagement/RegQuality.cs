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
    public partial class RegQuality : Form
    {
        public RegQuality()
        {
            InitializeComponent();
        }

        private void RegQuality_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvList, "측정항목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList, "기준값", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvList2, "측정일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "편차", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "1", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "2", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "3", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "4", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "5", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "6", "1", true, 100);
        }
    }
}
