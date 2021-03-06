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
    public partial class PackGradeDetail : dgvTwoWithInput
    {
        public PackGradeDetail()
        {
            InitializeComponent();
        }

        private void PackGradeDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();
            CommonClass.Userauthority(btnSave);
        }

        private void ShowDgv()
        {
            tabPage3.Text = "포장등급 목록";
            tabPage4.Text = "포장등급 상세목록";
            dgvSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "포장 등급", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "포장등급 상세코드", "1", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "포장등급 상세 명", "1", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상세명 수동 입력 여부", "1", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
