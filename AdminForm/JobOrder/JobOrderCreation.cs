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
        string selectedWorkOrderNo; //작업지시번호
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
            this.dgvSearchResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_DoubleClick);
            dgvSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //수정으로 탭페이지 전환
        private void DgvProductRequset_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcParent2.SelectedIndex = 1;
            btnSave.Text = "수정";
        }

        private void FinishJobOrder(string Workorderno)
        {
            JobOrderService service = new JobOrderService();
            if (service.FinishJobOrder(Workorderno) >= 1)
            {
                MessageBox.Show("작업지시가 마감되었습니다.");
            }
            else
            {
                MessageBox.Show("작업지시를 체크해주세요.");
            }

        }

        private void DgvProductRequset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                selectedWorkOrderNo = dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString();
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
            //체크표시한 모든 or 선택한 작업지시의 Wo_Status 를 '작업지시마감'으로 변경한다.
            for (int i = 0; i < dgvSearchResult.Rows.Count + 1; i++)
            {
                if (dgvSearchResult.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    FinishJobOrder(selectedWorkOrderNo);

                }
            }

            //작업지시dgv 새로고침
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
            if(btnSave.Text == "저장") //저장
            {
                JobOrderCreateVo_Insert ins = new JobOrderCreateVo_Insert();
                ins.workorderno = txtJobOrderCodeInput.Text;
                ins.plan_qty = (int)nuPlanAmount.Value;
                ins.plan_unit = txtPlanAmount.Text;
                ins.plan_date = dtpPlanDate.Value.ToString().Substring(0, 10);
                ins.item_code = txtItemCode.Text;
                ins.wc_name = cmbWorkPlace.Text;

                JobOrderService ser = new JobOrderService();
                ser.InsertJobOrder(ins);
            }
            else // 수정
            {
                JobOrderCreateVo_Insert ins = new JobOrderCreateVo_Insert();
                ins.workorderno = txtJobOrderCodeInput.Text;
                ins.plan_qty = (int)nuPlanAmount.Value;
                ins.plan_unit = txtPlanAmount.Text;
                ins.plan_date = dtpPlanDate.Value.ToString().Substring(0, 10);
                ins.item_code = txtItemCode.Text;
                ins.wc_name = cmbWorkPlace.Text;

                JobOrderService ser = new JobOrderService();
                ser.UpdateJobOrder(ins);
            }
           
        }

        private void BtnDeadlineCancel_Click(object sender, EventArgs e)
        {
            //체크표시한 모든 or 선택한 작업지시의 Wo_Status 를 '작업지시마감'으로 변경한다.
            for (int i = 0; i < dgvSearchResult.Rows.Count; i++)
            {
                if (dgvSearchResult.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    RerollMoldReq(selectedWorkOrderNo);

                }
            }

            //작업지시dgv 새로고침
            RefreshList();
            //작업지시dgv null
            List = null;
            dgvSearchResult.DataSource = List;
        }

        private void RerollMoldReq(string Workorderno)
        {
            JobOrderService service = new JobOrderService();
            if (service.UndoJobOrder(Workorderno) >= 1)
            {
                MessageBox.Show("작업지시가 마감취소되었습니다.");
            }
            else
            {
                MessageBox.Show("작업지시를 체크해주세요.");
            }
        }
    }


   
}
