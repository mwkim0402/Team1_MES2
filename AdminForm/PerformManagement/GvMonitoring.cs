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
    public partial class GVMonitoring : Form
    {
        public GVMonitoring()
        {
            InitializeComponent();
        }

        private void GvMonitoring_Load(object sender, EventArgs e)
        {
            CommonClass.AddNewColumnToDataGridView(dgvDry, "대차명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "상태", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "작업지시번호", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "수량", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "로딩시간", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "대차명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "상태", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "작업지시번호", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "수량", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "로딩시간", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "빈 대차", "1", true, 100);
        }
    }
}
