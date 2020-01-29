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
        public RegQuality()
        {
            InitializeComponent();
        }

        private void RegQuality_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllQuality();
        }

        private void GetData(object sender, EventArgs e)
        {
            dgvJob.DataSource = allList;
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "Workorderno", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "측정항목", "Inspect_name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "기준값", "SL", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Process_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Wc_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_Datetime", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Inspect_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "0", "Plan_Date", false, 100);

            CommonClass.AddNewColumnToDataGridView(dgvDetail, "측정항목", "Inspect_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDetail, "기준값", "SL", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "측정일시", "Inspect_Datetime", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDetaillist, "품목명", "Item_Name", true, 100);
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
            string itemName = dgvJob.Rows[e.RowIndex].Cells[4].Value.ToString();
            List<QualityDetailVO> list = (from item in allList
                                          select new QualityDetailVO 
                                          {
                                              Inspect_name = itemName,
                                              SL = item.SL
                                          }).ToList();
            dgvDetail.DataSource = list;
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemName = dgvDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<QualityDetailDeterVO> list = (from item in allList
                                               where item.Inspect_name == itemName
                                               select new QualityDetailDeterVO
                                               {
                                                   Inspect_Datetime = item.Inspect_Datetime,
                                                    Item_Code = item.Item_Code,
                                                    Item_Name = item.Item_Name
                                               }).ToList();
            dgvDetaillist.DataSource = list;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (StartDate != null && EndDate != null && fcFactory.SendCode != null && fcWorker.SendCode != null)
            {
                List<QualityVO> listLamda = allList.FindAll(x => x.Plan_Date >= StartDate.Date && (x.Plan_Date <= EndDate.Date) && x.Process_name == fcFactory.SendName && x.Wc_Name == fcWorker.SendName);
                dgvJob.DataSource = listLamda;
            }
            else
            {
                MessageBox.Show("모든 항목을 선택해주세요.");
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
    }
}
