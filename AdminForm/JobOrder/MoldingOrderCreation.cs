﻿                     using MES_DB;
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
        private delegate void SafeCallDelegate(List<WorkOrder> list);
        List<WorkReq_OrderVo> workReqList = null;
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
            workReqList = service.GetAllWorkReqQty();
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


        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
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

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgv.EnableHeadersVisualStyles = false;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            // dgv.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            // dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DimGray;

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
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰번호", "Wo_Req_No", true, 200);
            AddNewColumnToDataGridView(dgvProductRequset, "품목명", "item_Name", true, 150, DataGridViewContentAlignment.MiddleCenter);          
            AddNewColumnToDataGridView(dgvProductRequset, "제선잔여수량", "IronP", true, 180, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvProductRequset, "제강잔여수량", "SteelP", true, 180, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvProductRequset, "압연잔여수량", "RollingP", true, 180, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvProductRequset, "포장잔여수량", "PackageP", true, 180, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvProductRequset, "마감날짜", "Prd_Plan_Date", true, 150, DataGridViewContentAlignment.MiddleCenter);
            AddNewColumnToDataGridView(dgvProductRequset, "고객사", "Cust_Name", true, 120);
            AddNewColumnToDataGridView(dgvProductRequset, "영업담당", "Sale_Emp", true, 120);
            AddNewColumnToDataGridView(dgvProductRequset, "생산의뢰 상태", "Req_Status", true, 160);
      
            // 작업지시 dgv 컬럼 추가
            AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 230);
            AddNewColumnToDataGridView(dgvJobOrder, "공정명", "Process_name", true, 200);
            AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "Wc_Name", true, 170);
            AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 200);
            AddNewColumnToDataGridView(dgvJobOrder, "계획날짜", "Plan_Date", true, 170);
            AddNewColumnToDataGridView(dgvJobOrder, "시작시간", "Plan_Starttime", true,170);
            AddNewColumnToDataGridView(dgvJobOrder, "마감시간", "Plan_Endtime", true,170);
            AddNewColumnToDataGridView(dgvJobOrder, "계획수량", "Plan_Qty", true,170, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvJobOrder, "작업상태", "Wo_Status", true,170);


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
            using (FrmWaitForm frm = new FrmWaitForm(setAction))
            {
                frm.ShowDialog(this);
            }
        }
        private void setAction()
        {            
            WorkOrderService service = new WorkOrderService();
            List<WorkOrder> workDetailList = service.GetAllWorkDetail(dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString());
            WorkOrderDetailView(workDetailList);
        }
        private void WorkOrderDetailView(List<WorkOrder> list)
        {
            if (dgvJobOrder.InvokeRequired)
            {
                var d = new SafeCallDelegate(WorkOrderDetailView);
                Invoke(d, new object[] { list });
            }
            else
            {
                dgvJobOrder.DataSource = list;
            }    
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
            frm.Insert_Click += new System.EventHandler(this.ExportToExcel);
            frm.Search_Click += new System.EventHandler(this.Search);
            frm.btnSave.Enabled = false;
            ToolStripManager.Merge(this.toolStrip1,frm.ToolStrip);
        }

        private void MoldingOrderCreation_Deactivate(object sender, EventArgs e)
        {
            frm.Insert_Click -= new System.EventHandler(this.ExportToExcel);
            frm.Search_Click -= new System.EventHandler(this.Search);
            frm.btnSave.Enabled = true;
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }
        private void ExportToExcel(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add();
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    for (i = 0; i < dgvProductRequset.Columns.Count; i++)
                    {
                        xlWorkSheet.Cells[1, i + 1] = dgvProductRequset.Columns[i].HeaderText;
                    }

                    for (i = 0; i < dgvProductRequset.RowCount; i++)
                    {
                        for (j = 0; j < dgvProductRequset.ColumnCount; j++)
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = dgvProductRequset[j, i].Value.ToString();
                        }
                    }

                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    xlWorkBook.Close(true);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("저장 완료되었습니다.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ShowDialog("압연");
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            ShowDialog("제강");
        }

        private void btnSung_Click(object sender, EventArgs e)
        {
            ShowDialog("제선");
        }

        private void ShowDialog(string processName)
        {
            foreach (DataGridViewRow item in dgvProductRequset.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].EditedFormattedValue))
                {
                    if(processName == "압연")
                    {
                        if (Convert.ToInt32(item.Cells[5].Value) > 0)
                        {
                            MessageBox.Show("제강의 잔여량이 존재합니다. 먼저 제강 작업 계획을 모두 생성하세요");
                            return;
                        }
                        if (Convert.ToInt32(item.Cells[3].Value) == 0)
                        {
                            MessageBox.Show("잔여수량이 존재하지 않아 작업계획을 할 수 없습니다.");
                            return;
                        }
                    }
                    else if(processName == "제선")
                    {
                        if (Convert.ToInt32(item.Cells[4].Value) == 0)
                        {
                            MessageBox.Show("잔여수량이 존재하지 않아 작업계획을 할 수 없습니다.");
                            return;
                        }
                    }
                    else if (processName == "제강")
                    {
                        if (Convert.ToInt32(item.Cells[4].Value) > 0)
                        {
                            MessageBox.Show("제선의 잔여량이 존재합니다. 먼저 제선 작업 계획을 모두 생성하세요");
                            return;
                        }
                        if (Convert.ToInt32(item.Cells[5].Value) == 0)
                        {
                            
                            MessageBox.Show("잔여수량이 존재하지 않아 작업계획을 할 수 없습니다.");
                            return;
                        }
                    }
                    else if (processName == "포장")
                    {
                        if (Convert.ToInt32(item.Cells[3].Value) > 0)
                        {
                            MessageBox.Show("압연의 잔여량이 존재합니다. 먼저 압연 작업 계획을 모두 생성하세요");
                            return;
                        }
                        if (Convert.ToInt32(item.Cells[6].Value) == 0)
                        {
                            MessageBox.Show("잔여수량이 존재하지 않아 작업계획을 할 수 없습니다.");
                            return;
                        }
                    }
                    CreateWorkOrder popUp = new CreateWorkOrder(processName, dgvProductRequset.SelectedRows[0].Cells[1].Value.ToString());
                    popUp.ShowDialog();
                }               
            }
            frm.btnS.PerformClick();
        }

        private void btnPo_Click(object sender, EventArgs e)
        {
            ShowDialog("포장");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
