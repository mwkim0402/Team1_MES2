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
    public partial class EndPallet : dgvTwo
    {
        public EndPallet()
        {
            InitializeComponent();
        }
        private void EndPallet_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            tabPage4.Text = "";
            tabPage2.Text = "팔레트";
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업상태", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시번호", "2", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목코드", "3", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목명", "4", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업장", "5", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "투입수량", "6", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "산출수량", "7", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "생산수량", "8", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "팔렛트번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "등급", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "등급상세 코드", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "등급상세 명", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "수량", "1", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "ERP 업로드 여부", "1", true, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDetail udform = new UpdateDetail();
            if(udform.ShowDialog() == DialogResult.Yes)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindPallet frm = new FindPallet();
            frm.ShowDialog();
        }
    }
}
