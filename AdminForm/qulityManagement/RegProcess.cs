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
    public partial class RegProcess : Form
    {
        MainForm frm;
        List<RegProcessVO> allList;
        public RegProcess()
        {
            InitializeComponent();
        }

        private void RegProcess_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllRegProcess();
        }

        private void GetData(object sender, EventArgs e)
        {
            dgvJob.DataSource = allList;
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "1", "Process_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "1", "Inspect_code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "1", "Inspect_name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "1", "Inspect_Val", false, 100);


            CommonClass.AddNewColumnToDataGridView(dgvList, "측정항목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList, "기준값", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvList2, "측정일시", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "품목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "품목명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvList2, "편차", "1", true, 100);
        }

        private void RegProcess_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void RegProcess_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }
    }
}
