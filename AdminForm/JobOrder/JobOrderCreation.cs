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
    public partial class JobOrderCreation : dgvOneWithInput
    {
        MainForm frm;
        string selectedWoReq; //생산의뢰번호
        int req_Seq; //의뢰순번
        List<JobOrderCreateVo> List = null;
        public JobOrderCreation()
        {
            frm = (MainForm)ActiveForm;
            InitializeComponent();
        }
        private void RoadList()
        {
            JobOrderService service = new JobOrderService();
            List = service.JobOrderCreation();
        }
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
         int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(col);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
        }

        private void JobOrderCreation_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "체크";
            checkBoxColumn.Name = "check";
            dgvSearchResult.Columns.Add(checkBoxColumn);
            AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 255);
            AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "Prd_Date", true, 140);
            AddNewColumnToDataGridView(dgvSearchResult, "생산시작시각", "Prd_Starttime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "생산종료시간", "Prd_Endtime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "In_Qty_Main", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "산출수량", "Out_Qty_Main", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Prd_Qty", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 번호", "Wo_Req_No", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 순번", "Req_Seq", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "프로젝트명", "Remark", true, 150);
            RoadList();
            dgvSearchResult.DataSource = List;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_CellClick);
            dgvSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FinishMoldReq(string wo_Req_No, int req_seq)
        {
            JobOrderService service = new JobOrderService();
            if (service.FinishMoldReq(wo_Req_No, req_seq) >= 1)
            {
                MessageBox.Show("생간의뢰가 마감되었습니다.");
            }
            else
            {
                MessageBox.Show("생산의뢰를 체크해주세요.");
            }

        }

        private void DgvProductRequset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedWoReq = dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString();
                req_Seq = int.Parse(dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString());
                if (dgvSearchResult.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dgvSearchResult.SelectedRows[0].Cells[0].Value = CheckState.Checked;
                }
                else if (dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    dgvSearchResult.SelectedRows[0].Cells[0].Value = CheckState.Unchecked;
                }
                else
                {
                    dgvSearchResult.SelectedRows[0].Cells[0].Value = CheckState.Checked;
                }
            }
        }
        private void BtnDeadline_Click(object sender, EventArgs e)
        {
            //체크표시한 모든 or 선택한 생산의뢰의 Wo_Status 를 '마감'으로 변경한다.
            for (int i = 0; i < dgvSearchResult.Rows.Count; i++)
            {
                if (dgvSearchResult.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    FinishMoldReq(selectedWoReq, req_Seq);

                }
            }

            //생산의뢰dgv 새로고침
            RefreshList();
            //작업지시dgv null
            List = null;
            dgvSearchResult.DataSource = List;

        }
        private void RefreshList()
        {
            JobOrderService service = new JobOrderService();
            List = service.JobOrderCreation();
            dgvSearchResult.DataSource = List;
        }

        public void Search_Click(object sender, EventArgs e)
        {
            JobOrderService service = new JobOrderService();
            List = service.JobOrderCreation();
            dgvSearchResult.DataSource = List;
        }

        // 저장
        private void Save()
        {
            //txtJobOrderCodeInput.Text;
            //txtPlanAmount.Text;
            //txtItemCode.Text;
            //txtItemName.Text;
            //cmbWorkPlace.Items.ToString();
            //nuPlanAmount.Value.ToString();
        }

        private void JobOrderCreation_Leave(object sender, EventArgs e)
        {

        }

        private void JobOrderCreation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(Search_Click);
        }

        private void JobOrderCreation_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(Search_Click);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int plan_qty = (int)nuPlanAmount.Value;
            string plan_unit = txtPlanAmount.Text;
            string plan_date = dtpPlanDate.Value.ToString().Substring(0, 10);
            string item_code;
        }
    }


   
}
