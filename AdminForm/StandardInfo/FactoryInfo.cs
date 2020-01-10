using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class FactoryInfo : AdminForm.dgvOne
    {
        public FactoryInfo()
        {
            InitializeComponent();
        }

        private void FactoryInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장 유형", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시 자동시작 여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정 코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시 자동 생성 유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "자동 비가동 여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "자동 비가동 시간", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "마지막 실적 시각", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Gas 사용 여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "실적등록유형", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "실적단위", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "팔레트생성유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형장착여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "투입수량자동처리여부", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시이니셜", "1", true, 100);
        }
    }
}
