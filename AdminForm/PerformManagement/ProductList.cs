﻿using System;
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
    public partial class ProductList : dgvOne
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "팔레트번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "입고수량", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "마감시각", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "취소시각", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "ERP 업로드여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "1", true, 100);
        }
    }
}
