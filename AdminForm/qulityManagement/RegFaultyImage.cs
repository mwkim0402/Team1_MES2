using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class RegFaultyImage : AdminForm.dgvTwo
    {
        public RegFaultyImage()
        {
            InitializeComponent();
        }

        private void RegFaultyImage_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            
            tabPage4.Text = "작업지시목록";
            tabPage2.Text = "상세내역";
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시상태", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "생산일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "실적", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량이미지 건수", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량대분류", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량상세분류", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "발생일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량사진", "1", true, 100);
        }
    }
}
