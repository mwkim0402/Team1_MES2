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
    public partial class WorkdiligenceStatusanalysis : dgvTwo
    {
        public WorkdiligenceStatusanalysis()
        {
            InitializeComponent();
        }

        private void WorkdiligenceStatusanalysis_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "근무일", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시작일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업종료일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "생산수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "할당작업자", "1", true, 100);
        }
    }
}
