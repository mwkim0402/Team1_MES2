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
        List<ItemCodeCB> comlist;
        string selectedWorkOrderNo; //작업지시번호
        List<JobOrderCreateVo> daycount= new List<JobOrderCreateVo>();

        List<JobOrderCreateVo> List = null;
        public JobOrderCreation()
        {
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
            DgvLoad();
            WorkplaceCB();
            ItemCodeCB();

            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_CellClick);
            dgvSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductRequset_DoubleClick);

            //기본값 설정
            dtpStart.Value = dtpEnd.Value.AddDays(-7);
            
            //foreach (JobOrderCreateVo item in List)
            //{
                
            //    JobOrderCreateVo ifitem = new JobOrderCreateVo();
            //    ifitem.Workorderno = item.Workorderno;
            //    if (ifitem.Workorderno.ToString().Substring(0,8) == DateTime.Today.Date.ToString())
            //    {
            //        daycount.Add(ifitem);
            //    }
            //}
                                               

            txtJobOrderCodeInput.Text = DateTime.Today.Date.ToShortDateString().Replace("-", "") + String.Format("{0:D4}", daycount.Count+ 1);
        }

        private void ItemCodeCB()
        {
            JobOrderService ser = new JobOrderService();
            comlist = ser.GetItemCodeCombo();

            List<ComboItem> comboList = (from value in comlist
                                         select new ComboItem
                                         {
                                             comboText = value.Item_Code,
                                             comboValue = value.Item_Name
                                         }).ToList();
            ComboClass.ComboBind(comboList, cmbItemCode, true);
            ComboClass.ComboBind(comboList, cmbItemCode_CH, true);
        }

        private void WorkplaceCB()
        {
            JobOrderService ser = new JobOrderService();
           List<WorkPlaceCB> comlist = ser.GetWorkPlaceCombo();

            List<ComboItem> comboList = (from value in comlist
                                         select new ComboItem
                                         {
                                             comboText = value.Wc_Name,
                                             comboValue = value.Wc_code
                                         }).ToList();
            ComboClass.ComboBind(comboList, cmbWorkPlace, true);
            ComboClass.ComboBind(comboList, cmbWorkPlace_CH, true);
        }

        private void DgvLoad()
        {
            frm = (MainForm)this.MdiParent;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "체크";
            checkBoxColumn.Name = "check";
            dgvSearchResult.Columns.Add(checkBoxColumn);
            AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "Wo_Status", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "계획일자", "Plan_Date", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "계획수량", "Plan_Qty", true, 120,DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvSearchResult, "계획수량단위", "Plan_Unit", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 180);
            AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "Prd_Date", true, 140);
            AddNewColumnToDataGridView(dgvSearchResult, "생산시작시각", "Prd_Starttime", true, 180);
            AddNewColumnToDataGridView(dgvSearchResult, "생산종료시간", "Prd_Endtime", true, 180);
            AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "In_Qty_Main", true, 120, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvSearchResult, "산출수량", "Out_Qty_Main", true, 120, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Prd_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 번호", "Wo_Req_No", true, 160);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 순번", "Req_Seq", true, 160);
            AddNewColumnToDataGridView(dgvSearchResult, "프로젝트명", "Remark", true, 150);
            RoadList();
            dgvSearchResult.DataSource = List;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        //수정으로 탭페이지 전환
        private void DgvProductRequset_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcParent2.SelectedIndex = 1;
            txtJobOrderNo_Ch.Text = dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString();
            dtpPlanDate_CH.Value = (DateTime)dgvSearchResult.SelectedRows[0].Cells[3].Value;
            nuPlanAmount_CH.Value = int.Parse(dgvSearchResult.SelectedRows[0].Cells[4].Value.ToString());
            txtPlanAmount_CH.Text = dgvSearchResult.SelectedRows[0].Cells[5].Value.ToString();
            txtItemName_CH.Text = dgvSearchResult.SelectedRows[0].Cells[7].Value.ToString();

            foreach (ComboItem item in cmbItemCode_CH.Items)
            {
                if(dgvSearchResult.SelectedRows[0].Cells[6].Value.ToString() == item.comboText.ToString())
                {
                    cmbItemCode_CH.SelectedItem = item;
                }
            }
            foreach (ComboItem item in cmbWorkPlace_CH.Items)
            {
                if (dgvSearchResult.SelectedRows[0].Cells[8].Value.ToString() == item.comboText.ToString())
                {
                    cmbWorkPlace_CH.SelectedItem = item;
                }
            }
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
                if (dgvSearchResult.Rows[i].Cells[0].FormattedValue.ToString() == "True")
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
            string strStart = dtpStart.Value.ToString().Substring(0, 10);
            string strEnd = dtpEnd.Value.ToString().Substring(0, 10);
            JobOrderService service = new JobOrderService();
            if (fcProcess.SendCode != "")
            {
                if(fcWorkPlace.SendCode != "")
                {
                    //카테고리 둘다 있을때
                    List = service.JobOrderSearch(strStart, strEnd, fcProcess.SendCode,fcWorkPlace.SendName);
                    dgvSearchResult.DataSource = List;
                }
                else
                {
                    //공정만 있을때
                    List = service.JobOrderSearch(strStart, strEnd, fcProcess.SendCode, "");
                    dgvSearchResult.DataSource = List;
                }
            }
            else
            {
                if (fcWorkPlace.SendCode != "")
                {
                    //작업장만 있을때
                    List = service.JobOrderSearch(strStart, strEnd, "", fcWorkPlace.SendCode);
                    dgvSearchResult.DataSource = List;
                }
                else
                {
                    //둘다 없을 때
                    List = service.JobOrderSearch(strStart, strEnd, "", "");
                    dgvSearchResult.DataSource = List;
                }
            }

        }

       

        private void JobOrderCreation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(Search_Click);
            frm.Search_Click += new System.EventHandler(ExportToExcel);
           
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
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (i = 0; i <= dgvSearchResult.RowCount - 2; i++)
                {
                    for (j = 0; j <= dgvSearchResult.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = dgvSearchResult[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
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

        private void JobOrderCreation_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(Search_Click);
            frm.Search_Click -= new System.EventHandler(ExportToExcel);
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
                ins.item_code = cmbItemCode.Text;
                ins.wc_code = cmbWorkPlace.SelectedValue.ToString();

                JobOrderService ser = new JobOrderService();
                if(ser.InsertJobOrder(ins) >= 1)
                {
                    MessageBox.Show("저장이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("저장이 실패되었습니다.");
                }
            }
           
               

        }

        private void BtnDeadlineCancel_Click(object sender, EventArgs e)
        {
            //체크표시한 모든 or 선택한 작업지시의 Wo_Status 를 '작업지시마감'으로 변경한다.
            for (int i = 0; i < dgvSearchResult.Rows.Count; i++)
            {
                if (dgvSearchResult.Rows[i].Cells[0].FormattedValue.ToString() == "True")
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

        private void CmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ItemCodeCB item in comlist)
            {
                if (item.Item_Code == cmbItemCode.Text)
                {
                   txtItemName.Text = item.Item_Name;
                }
            }
        }

        private void FcProcess_Load(object sender, EventArgs e)
        {

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            
                JobOrderCreateVo_Insert ins = new JobOrderCreateVo_Insert();
                ins.workorderno = txtJobOrderNo_Ch.Text;
                ins.plan_qty = (int)nuPlanAmount_CH.Value;
                ins.plan_unit = txtPlanAmount_CH.Text;
                ins.plan_date = dtpPlanDate_CH.Value.ToString().Substring(0, 10);
                ins.item_code = cmbItemCode_CH.Text;
                ins.wc_code = cmbWorkPlace_CH.SelectedValue.ToString();

                JobOrderService ser = new JobOrderService();
            if (ser.UpdateJobOrder(ins)>= 1)
            {
                MessageBox.Show("수정이 완료되었습니다.");

            }
            else
            {
                MessageBox.Show("수정이 실패했습니다.");

            }

            RefreshList();
        }
    }


   
}
