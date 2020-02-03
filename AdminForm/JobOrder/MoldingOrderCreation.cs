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
        List<WorkReqVo> workReqList = null;
        List<MoldingOrderCreation_ReqVo> ListReq = null;
        List<MoldingOrderCreation_WoVo> ListWo = null;
        string selectedWoReq; //생산의뢰번호
        int req_Seq; //의뢰순번
        MainForm frm;

        public MoldingOrderCreation()
        {           
            InitializeComponent();
        }

        private void ProdReqList()
        {
            WorkOrderService service = new WorkOrderService();
            workReqList = service.GetAllWorkReq();
            dgvProductRequset.DataSource = workReqList;
        }
        private void WorkOrderList(string Wo_Req_No)
        {
            JobOrderService service = new JobOrderService();
            ListWo = service.MoldingOrderCreation_WO(Wo_Req_No);
        }

        private void FinishMoldReq(string wo_Req_No, int req_seq)
        {
            JobOrderService service = new JobOrderService();
            int result = service.FinishMoldReq(wo_Req_No, req_seq);
            if (result >= 1)
            {
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
            frm = (MainForm)this.MdiParent;
            dgvProductRequset.RowHeadersVisible = false;
            DataGridViewCheckBoxColumn chkboxCol = new DataGridViewCheckBoxColumn();
            chkboxCol.Width = 30;
            chkboxCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductRequset.Columns.Insert(0, chkboxCol);
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰번호", "Wo_Req_No", true, 110);
            AddNewColumnToDataGridView(dgvProductRequset, "의뢰순번", "Req_Seq", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "품목명", "Item_Name", true, 174);
            AddNewColumnToDataGridView(dgvProductRequset, "의뢰수량", "Req_Qty", true, 80);
            AddNewColumnToDataGridView(dgvProductRequset, "생산완료 요청일", "Prd_Plan_Date", true, 140);
            AddNewColumnToDataGridView(dgvProductRequset, "거래처명", "Cust_Name", true, 100);
            AddNewColumnToDataGridView(dgvProductRequset, "영업담당", "Sale_Emp", true, 100);
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰 상태", "Req_Status", true, 120);
      
            // 작업지시 dgv 컬럼 추가
            AddNewColumnToDataGridView(dgvJobOrder, "작업상태", "Wo_Status", true, 110);
            AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 150);
            AddNewColumnToDataGridView(dgvJobOrder, "공정명", "Process_name", true, 150);
            AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "Wc_Name", true, 110);
            AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 220);
            AddNewColumnToDataGridView(dgvJobOrder, "계획날짜", "Plan_Date", true, 140);
            AddNewColumnToDataGridView(dgvJobOrder, "시작시간", "Plan_Starttime", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "마감시간", "Plan_Endtime", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "계획수량", "Plan_Qty", true,140);
            AddNewColumnToDataGridView(dgvJobOrder, "작업상태", "Wo_Status", true,140);


            dgvJobOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvJobOrder.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJobOrder.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductRequset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductRequset.MultiSelect = false;
            dgvJobOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductRequset.CellContentClick += DgvProductRequset_CellClick;
            dgvProductRequset.CellDoubleClick += DgvProductRequset_CellDoubleClick;
            ProdReqList();
        }

        private void DgvProductRequset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                if (Convert.ToBoolean(dgvProductRequset.Rows[e.RowIndex].Cells[0].EditedFormattedValue))
                {
                    foreach(DataGridViewRow item in dgvProductRequset.Rows)
                    {
                        if(dgvProductRequset.SelectedRows[0] != item)
                        {
                            item.Cells[0].Value = false;
                        }
                    }
                }
            }
        }

        private void DgvProductRequset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            WorkOrderService service = new WorkOrderService();
            List<WorkOrder> workDetailList = service.GetAllWorkDetail(dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString());
            dgvJobOrder.DataSource = workDetailList;

        }

        private void BtnOrderCreationDeadline_Click(object sender, EventArgs e)
        {

            WorkReqVo test = new WorkReqVo();
            test = (WorkReqVo) dgvProductRequset.SelectedRows[0].DataBoundItem;
        }


        //검색
        private void Search(object sender, EventArgs e)
        {
            ProdReqList();
        }

        private void MoldingOrderCreation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.Search);
            ToolStripManager.Merge(this.toolStrip1,frm.ToolStrip);
        }

        private void MoldingOrderCreation_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ShowDialog("소성");
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            ShowDialog("건조");
        }

        private void btnSung_Click(object sender, EventArgs e)
        {
            ShowDialog("성형");
        }

        private void ShowDialog(string processName)
        {
            foreach (DataGridViewRow item in dgvProductRequset.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].EditedFormattedValue))
                {
                    CreateWorkOrder popUp = new CreateWorkOrder(processName, dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString());
                    popUp.ShowDialog();
                }               
            }
        }

        private void btnPo_Click(object sender, EventArgs e)
        {
            ShowDialog("포장");
        }
    }
}
