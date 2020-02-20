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
    public partial class NoticeRegister : dgvOne
    {
        MainForm main;
        public NoticeRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NoticeSettings ntFrm = new NoticeSettings();
            ntFrm.ShowDialog();
            NoticeSearch();
        }

        private void NoticeRegister_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(this.toolStrip1, main.ToolStrip);
        }

        private void NoticeRegister_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(main.ToolStrip);
        }

        private void NoticeRegister_Load(object sender, EventArgs e)
        {
            main = (MainForm)this.MdiParent;
            NoticeSearch();


        }
        private void NoticeSearch()
        {
            dgvSearchResult.RowHeadersVisible = false;
            DataGridViewCheckBoxColumn chkboxCol = new DataGridViewCheckBoxColumn();
            chkboxCol.Width = 30;
            chkboxCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns.Insert(0, chkboxCol);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "번호", "Seq", false, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공지 날짜", "Notice_Date", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "제목", "Title", true, 500);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공지 내용", "Description", true, 1500);
            NoticeService noticeService = new NoticeService();
            dgvSearchResult.DataSource = noticeService.GetAllNotice();
        }
    }
}
