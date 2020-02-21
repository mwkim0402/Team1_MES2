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
    public partial class RegQuality : Form
    {
        List<QualityVO> allList;
        MainForm frm;
        DateTime StartDate;
        DateTime EndDate;
        string workOrderNo;
        int primary = 0;
        string check;
        InsQualityVO InsVO = new InsQualityVO();
        public RegQuality()
        {
            InitializeComponent();
        }

        private void RegQuality_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void GetData(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllQuality();
            dgvJob.DataSource = allList;
        }
        private void ShowDgv()
        {
            dgvJob.CellDoubleClick += dgvJob_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "Plan_Date", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "측정항목", "Inspect_name", false, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "기준값", "SL", false, 100, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Process_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Wc_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_Datetime", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Plan_Date", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "deviation", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_Measure_seq", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_Val", false, 100);
            



            dgvDetail.CellDoubleClick += dgvDetail_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvDetail, "측정항목", "Inspect_name", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvDetail, "기준값", "SL", true, 100);

            dgvDetaillist.CellDoubleClick += DgvDetaillist_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "측정일시", "Inspect_Datetime", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "편차", "deviation", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "측정값", "Inspect_Val", true, 100);
        }



        private void RegQuality_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void RegQuality_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void dgvJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InsVO.WorkOrderNo = dgvJob.Rows[e.RowIndex].Cells[0].Value.ToString();
            InsVO.Item_Code = dgvJob.Rows[e.RowIndex].Cells[5].Value.ToString();
            InsVO.Process_Code = dgvJob.Rows[e.RowIndex].Cells[1].Value.ToString();
            InsVO.Inspect_Code = dgvJob.Rows[e.RowIndex].Cells[3].Value.ToString();
            string Name = dgvJob.Rows[e.RowIndex].Cells[3].Value.ToString();
            workOrderNo = dgvJob.Rows[e.RowIndex].Cells[0].Value.ToString();
            primary = Convert.ToInt32(dgvJob.Rows[e.RowIndex].Cells[13].Value);
            List<QualityDetailVO> list = (from item in allList
                                          where item.Workorderno == dgvJob.Rows[e.RowIndex].Cells[0].Value.ToString()
                                          select new QualityDetailVO
                                          {
                                              Inspect_name = Name,
                                              SL = item.SL
                                          }).ToList();
            dgvDetail.DataSource = list;
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Name = dgvDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<QualityDetailDeterVO> list = (from item in allList
                                               where item.Inspect_code == Name && item.Workorderno == workOrderNo
                                               select new QualityDetailDeterVO
                                               {
                                                   Inspect_Datetime = item.Inspect_Datetime,
                                                   Item_Code = item.Item_Code,
                                                   Item_Name = item.Item_Name,
                                                   deviation = item.deviation,
                                                   Inspect_Val = item.Inspect_Val
                                               }).ToList();
            dgvDetaillist.DataSource = list;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            txtNum.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //if (StartDate != null && EndDate != null && fcFactory.SendCode != null && fcWorker.SendCode != null)
            //{
            //    List<QualityVO> listLamda = allList.FindAll(x => x.Plan_Date >= StartDate.Date && (x.Plan_Date <= EndDate.Date) && x.Process_name == fcFactory.SendName && x.Wc_Name == fcWorker.SendName);
            //    dgvJob.DataSource = listLamda;
            //}
            //else
            //{
            //    MessageBox.Show("모든 항목을 선택해주세요.");
            //}
            if (allList != null)
            {
                if ((fcWorker.SendCode != null && fcWorker.SendName != "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<QualityVO> list = (from item in allList
                                            where item.Process_code == fcFactory.SendCode && item.Wc_Name == fcWorker.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                            select item).ToList();
                    dgvJob.DataSource = list;
                }
                else if ((fcWorker.SendCode != null && fcWorker.SendCode != "") && (fcFactory.SendCode == null || fcFactory.SendCode == ""))
                {
                    List<QualityVO> list = (from item in allList
                                            where item.Wc_Name == fcWorker.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                            select item).ToList();
                    dgvJob.DataSource = list;
                }
                else if ((fcWorker.SendCode == null || fcWorker.SendCode == "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<QualityVO> list = (from item in allList
                                            where item.Process_code == fcFactory.SendCode && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                            select item).ToList();
                    dgvJob.DataSource = list;
                }
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 등록으로 바꿔야 함
            if (check != "" && check != null)
            {

                QulityRegisterForm frm = new QulityRegisterForm(InsVO);
                frm.ShowDialog();

                //    MES_DB.PerformService service = new MES_DB.PerformService();
                //    service.UpdateRegQulityForm(Convert.ToInt32(txtNum.Text), workOrderNo);
                //    MessageBox.Show("수정되었습니다.");
                //    dgvJob.DataSource = null;
                //    dgvDetail.DataSource = null;
                //    dgvDetaillist.DataSource = null;
                //    ShowDgv();

            }
            else
            {

                MessageBox.Show("변경 해야 할 셀을 선택해주세요.");
            }

        }
        private void DgvDetaillist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            check = dgvDetaillist.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MES_DB.PerformService service = new MES_DB.PerformService();
                service.DeleteRegUqlityForm(primary);

                MessageBox.Show("삭제되었습니다.");
                dgvJob.DataSource = null;
                dgvDetail.DataSource = null;
                dgvDetaillist.DataSource = null;
                ShowDgv();

            }
            else
            {
                MessageBox.Show("취소되었습니다.");
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("숫자를 입력해주세요.");
                e.Handled = true;
            }

        }
    }
}
