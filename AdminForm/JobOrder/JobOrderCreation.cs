using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class JobOrderCreation : dgvOneWithInput
    {
        MainForm frm;
        string selectedWorkOrderNo; //작업지시번호
        List<Wo_Req> woReqList = new List<Wo_Req>();
        
        List<JobOrderCreateVo> List = null;
        public JobOrderCreation()
        {
            InitializeComponent();
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
            RefreshList();
            ComboBind();
            CreateWoReqNo();
        }
        private void ComboBind()
        {
            ItemService service = new ItemService();
            List<ComboItem> cbItem = (from item in service.GetAllItemInfo()
                                      where item.Item_Type =="완제품"
                                      select new ComboItem
                                      {
                                          comboText = item.Item_Name,
                                          comboValue = item.Item_Code
                                      }).ToList();
            ComboClass.ComboBind(cbItem, cmbItemName, false);
        }
        private void DgvLoad()
        {
            frm = (MainForm)this.MdiParent;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "체크";
            checkBoxColumn.Name = "check";
            dgvSearchResult.Columns.Add(checkBoxColumn);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰번호", "Wo_Req_No", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "우선순위", "Req_Seq", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "고객사", "Cust_Name", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "프로젝트명", "Project_Name", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "의뢰제품명", "Item_Code", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "의뢰수량", "Req_Qty", true, 150, DataGridViewContentAlignment.MiddleRight);
            AddNewColumnToDataGridView(dgvSearchResult, "의뢰등록날짜", "Ins_Date", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "마감날짜", "Prd_Plan_Date", true, 150);
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
                if (dgvSearchResult.SelectedRows[0].Cells[6].Value.ToString() == item.comboText.ToString())
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

       
        private void RefreshList()
        {
            WoReqService service = new WoReqService();
            woReqList = service.GetAllWoReq();
            dgvSearchResult.DataSource = woReqList;
        }

        public void Search_Click(object sender, EventArgs e)
        {
            RefreshList();
        }



        private void JobOrderCreation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(Search_Click);
            frm.Insert_Click += new System.EventHandler(ExportToExcel);
            ToolStripManager.Merge(this.toolStrip1, frm.ToolStrip);
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
            frm.Insert_Click -= new System.EventHandler(ExportToExcel);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            WoReqService service = new WoReqService();
            int req_Num= (woReqList.FindAll(x => x.Prd_Plan_Date.Date == dtpPlanDate.Value.Date).Count) + 1;
            service.InsertWoReq(new Wo_Req
            {
                Wo_Req_No = txtJobOrderCodeInput.Text,
                Cust_Name = txtCustName.Text,
                Project_Name = txtProjectName.Text,
                Req_Qty = Convert.ToInt32(nuPlanAmount.Text),
                Prd_Plan_Date = dtpPlanDate.Value.Date,
                Item_Code = cmbItemName.SelectedValue.ToString(),
                Req_Seq = req_Num,
                Ins_Date = DateTime.Now.Date
            });
            CommonClass.InitControl(pnlParent1);
            RefreshList();
            CreateWoReqNo();
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

        private void CreateWoReqNo()
        {
            txtJobOrderCodeInput.Text = string.Format($"{DateTime.Now.ToShortDateString().Replace("-","")}_{woReqList.FindAll(x => x.Ins_Date.Date == DateTime.Now.Date).Count+1}");
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnSung_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open($"{openFileDialog1.FileName}");
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorkSheet.UsedRange;

                txtCustName.Text = Convert.ToString(xlWorkSheet.Cells[12, 10].Value2);
                txtProjectName.Text = Convert.ToString(xlWorkSheet.Cells[14, 7].Value2);
                cmbItemName.Text = Convert.ToString(xlWorkSheet.Cells[16, 9].Value2);
                nuPlanAmount.Value = Convert.ToInt32(xlWorkSheet.Cells[17, 9].Value2);
                dtpPlanDate.Value = Convert.ToDateTime(xlWorkSheet.Cells[22, 9].Value2.ToString());


                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorkSheet);
                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);

            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
