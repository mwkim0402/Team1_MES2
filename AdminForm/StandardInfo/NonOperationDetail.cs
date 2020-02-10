using MES_DB;
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
    public partial class NonOperationDetail : dgvTwoWithInput
    {
        MainForm frm;
        List<NonOperationVO> nonOpMaList;
        List<NonOpMiVo> nonOpMiList;
        List<ComboItem> comboList;
        public NonOperationDetail()
        {
            InitializeComponent();
        }

        private void NonOperationDetail_Load(object sender, EventArgs e)
        {
            ShowDgv();
            Search();
            frm = (MainForm)this.MdiParent;
            ComboBind();
        }
        private void Search()
        {
            NonOperationMaService service = new NonOperationMaService();
            nonOpMaList = service.GettNonOperationMa();
            nonOpMiList = service.GetNonOpMi();
            dgvSelect.DataSource = nonOpMaList;
        }
        private void ComboBind()
        {
            comboList = (from item in nonOpMaList
                         select new ComboItem
                         {
                             comboText = item.Nop_Ma_Name,
                             comboValue = item.Nop_Ma_Code
                         }).ToList();
            ComboClass.ComboBind(comboList, cmbNonOpMa, false);
        }
        private void ShowDgv()
        {
            tabPage3.Text = "비가동 대분류 목록";
            tabPage4.Text = "비가동 상세분류 조회";

            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비가동 대분류 코드", "Nop_Ma_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "비가동 대분류 명", "Nop_Ma_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용유무", "Use_YN", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 상세분류 코드", "Nop_Mi_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 상세분류 명", "Nop_Mi_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 100);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string searchCode = dgvSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<NonOpMiVo> searchList = nonOpMiList.FindAll(x => x.Nop_Ma_Code == searchCode);
            dgvSearchResult.DataSource = searchList;
        }

        private void NonOperationDetail_Activated(object sender, EventArgs e)
        {
            dgvSelect.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void NonOperationDetail_Deactivate(object sender, EventArgs e)
        {
            dgvSelect.CellDoubleClick -= dataGridView1_CellDoubleClick;
        }

        private void cmbNonOpMa_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int count = nonOpMiList.FindAll(x => x.Nop_Ma_Code == cmbNonOpMa.SelectedValue.ToString()).Count+1;
            if (cmbNonOpMa.Text == "기계오작동")
            {
                txtNonOperationDetailCode.Text = "Malfunction_"+ string.Format("{0:D3}", count);
            }
            else if (cmbNonOpMa.Text == "기계교체")
            {       
                txtNonOperationDetailCode.Text = "MacReplacement_" + string.Format("{0:D3}", count);
            }
            else if (cmbNonOpMa.Text == "작업 대기 시간")
            {               
                txtNonOperationDetailCode.Text = "DummyPass_" + string.Format("{0:D3}", count);
            }
            else if (cmbNonOpMa.Text == "청소")
            {
                txtNonOperationDetailCode.Text = "MacCleaning _" + string.Format("{0:D3}", count);
            }
            else
            {
                txtNonOperationDetailCode.Text = "ETC_" + string.Format("{0:D3}", count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NonOperationMaService service = new NonOperationMaService();
            service.InsertNonOpMi(new NonOpMiVo
            {
                Nop_Ma_Code = cmbNonOpMa.SelectedValue.ToString(),
                Nop_Mi_Code = txtNonOperationDetailCode.Text,
                Nop_Mi_Name = txtNonOperationDetailName.Text,
                Remark = txtNote.Text,
                Use_YN = "Y"
            });
            CommonClass.InitControl(panel1);
            Search();
        }
    }
}
