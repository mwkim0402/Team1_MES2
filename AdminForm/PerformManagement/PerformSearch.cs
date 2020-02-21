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
    public partial class PerformSearch : dgvOne
    {
        MainForm frm;
        DateTime StartDate;
        DateTime EndDate;
        List<PerformSearchVO> allList;
        PerformSearchVO edit;
        string status;
        public PerformSearch()
        {
            InitializeComponent();
        }

        // 실적 보정 , 실적 나누기 버튼
        private void PerformSearch_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
            
        }


        private void GetData(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllPerformSearch();
            dgvSearchResult.DataSource = allList;

        }

        private void ShowDgv()
        {
            dgvSearchResult.CellDoubleClick += DgvSearchResult_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시상태", "Wo_Status", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 150, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "In_Qty_Main", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량수량", "Bad_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Prd_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량률(%)", "Faulty", true, 140, DataGridViewContentAlignment.MiddleRight);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Plan_Date", false, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Process_code", false, 120);
        }

        private void DgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = (PerformSearchVO)dgvSearchResult.Rows[e.RowIndex].DataBoundItem;
            status = dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void PerformSearch_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }
        private void PerformSearch_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (edit != null && status != "작업종료")
            {
                PerformSearchEdit frm1 = new PerformSearchEdit(edit);
                frm1.ShowDialog();
                frm.btnS.PerformClick();
            }
            else
            {
                MessageBox.Show("변경할 셀을 선택해주세요.");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (allList != null)
            {
                if (fcFactory.SendCode != null && fcWork.SendCode != null)
                {
                    List<PerformSearchVO> list = (from item in allList
                                                  where item.Process_code == fcFactory.SendCode && item.Wc_Code == fcWork.SendCode
                                                  select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
                else if (fcFactory.SendCode != null && fcWork.SendCode == null)
                {
                    List<PerformSearchVO> list = (from item in allList
                                                  where item.Process_code == fcFactory.SendCode
                                                  select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
                else if (fcWork.SendCode != null && fcFactory.SendCode == null)
                {
                    List<PerformSearchVO> list = (from item in allList
                                                  where item.Wc_Code == fcWork.SendCode
                                                  select item).ToList();
                    dgvSearchResult.DataSource = list;
                }
                else
                {
                    frm.lblAlert.Text = "조건을 선택해주세요.";
                }
            }
            else
            {
                MessageBox.Show("전체 검색을 먼저 선택해주세요.");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }
    }
}
