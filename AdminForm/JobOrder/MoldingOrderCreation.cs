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
    public partial class MoldingOrderCreation : dgvTwo
    {

        List<MoldingOrderCreation_ReqVo> ListReq = null;
        List<MoldingOrderCreation_WoVo> ListWo = null;
        string selectedWoReq; //생산의뢰번호
        int req_Seq; //의뢰순번

        public MoldingOrderCreation()
        {
            InitializeComponent();
        }

        private void ProdReqList()
        {
            JobOrderService service = new JobOrderService();
            ListReq = service.MoldingOrderCreation_Req();
            dgvProductRequset.DataSource = ListReq;
        }
        private void WorkOrderList(string Wo_Req_No)
        {
            JobOrderService service = new JobOrderService();
            ListWo = service.MoldingOrderCreation_WO(Wo_Req_No);
        }

        private void FinishMoldReq(string wo_Req_No, int req_seq)
        {
            JobOrderService service = new JobOrderService();
            if(service.FinishMoldReq(wo_Req_No, req_seq) >= 1)
            {
                MessageBox.Show("생간의뢰가 마감되었습니다.");
            }
            else
            {
                MessageBox.Show("생산의뢰를 체크해주세요.");
            }

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

        private void MoldingOrderCreation_Load(object sender, EventArgs e)
        {
            // 생산의뢰 dgv 컬럼 추가

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "체크";
            checkBoxColumn.Name = "check";
            dgvProductRequset.Columns.Add(checkBoxColumn);
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰번호", "Wo_Req_No", true, 110);
            AddNewColumnToDataGridView(dgvProductRequset, "의뢰순번", "Req_Seq", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "품목코드", "Item_Code", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "품목명", "Item_Name", true, 174);
            AddNewColumnToDataGridView(dgvProductRequset, "의뢰수량", "Req_Qty", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "의뢰단위", "Prd_Unit", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "생산완료 요청일", "Prd_Plan_Date", true, 140);
            AddNewColumnToDataGridView(dgvProductRequset, "프로젝트명", "Remark", true, 110);
            AddNewColumnToDataGridView(dgvProductRequset, "거래처명", "Cust_Name", true, 100);
            AddNewColumnToDataGridView(dgvProductRequset, "영업담당", "Sale_Emp", true, 100);
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰 상태", "Req_Status", true, 120);
            AddNewColumnToDataGridView(dgvProductRequset, "생성된 작업 지시 수", "Out_Qty_Main", true, 180);
            AddNewColumnToDataGridView(dgvProductRequset, "작업지시 생산수량", "Prd_Qty", true, 150);
            AddNewColumnToDataGridView(dgvProductRequset, "작업지시 계획수량", "Plan_Qty", true, 150);
            ProdReqList();

            dgvProductRequset.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductRequset.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductRequset.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductRequset.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductRequset.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // 작업지시 dgv 컬럼 추가
            AddNewColumnToDataGridView(dgvJobOrder, "작업상태", "Wo_Status", true, 110);
            AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 150);
            AddNewColumnToDataGridView(dgvJobOrder, "작업지시일", "Prd_Date", true, 150);
            AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 110);
            AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 220);
            AddNewColumnToDataGridView(dgvJobOrder, "작업장", "Wc_Name", true, 140);
            AddNewColumnToDataGridView(dgvJobOrder, "계획수량", "Plan_Qty", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "투입수량", "In_Qty_Main", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "산출수량", "Out_Qty_Main", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "생산수량", "Prd_Qty", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "전달사항", "Remark", true, 208);
            //WorkOrderList();
            //dgvJobOrder.DataSource = ListWo;

            dgvJobOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvJobOrder.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //이벤트추가
            this.dgvProductRequset.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_CellDoubleClick);
            this.dgvProductRequset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_CellClick);
            dgvProductRequset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void DgvProductRequset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                selectedWoReq = dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString();
                req_Seq = int.Parse(dgvProductRequset.SelectedRows[0].Cells[2].Value.ToString());
                if (dgvProductRequset.Rows[e.RowIndex].Cells[0].Value ==null)
                {
                    dgvProductRequset.SelectedRows[0].Cells[0].Value = CheckState.Checked;
                }
                else if (dgvProductRequset.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    dgvProductRequset.SelectedRows[0].Cells[0].Value = CheckState.Unchecked;
                }
                else
                {
                    dgvProductRequset.SelectedRows[0].Cells[0].Value = CheckState.Checked;
                }
            }
        }

        private void DgvProductRequset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //생산의뢰에 해당되는 작업지시를 작업지시dgv에 띄운다.
            //workorder-> Wo_Req_No
            selectedWoReq = dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString();
            req_Seq = int.Parse( dgvProductRequset.SelectedRows[0].Cells[2].Value.ToString());
            WorkOrderList(selectedWoReq);
            dgvJobOrder.DataSource = ListWo;
        }

        private void BtnOrderCreationDeadline_Click(object sender, EventArgs e)
        {

            //체크표시한 모든 or 선택한 생산의뢰의 Wo_Status 를 '작업지시마감'으로 변경한다.
            for (int i = 0; i < dgvProductRequset.Rows.Count; i++)
            {
                if(dgvProductRequset.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    FinishMoldReq(selectedWoReq, req_Seq);

                }
            }

            //생산의뢰dgv 새로고침
            ProdReqList();
            //작업지시dgv null
            ListWo = null;
            dgvJobOrder.DataSource = ListWo;


        }

        //검색-생산의뢰날짜
        private void Search_date(object sender, EventArgs e)
        {
            JobOrderService ser = new JobOrderService();
            ListReq = ser.SearchMoldReq_date(dtpStart.Value, dtpEnd.Value);
            dgvProductRequset.DataSource = ListReq;

        }

    }
}
