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
    public partial class GVMonitoring : Form
    {
        MainForm frm;
        List<GVMonitoringVO> Alllist;
        public GVMonitoring()
        {
            InitializeComponent();
            

        }

        private void GvMonitoring_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            MES_DB.PerformService service = new MES_DB.PerformService();
            Alllist = service.GetAllMonitoring();
        }
        private void GetDryGridView(object sender, EventArgs e)
        {
            List<GVMonitoringVO> GvList = (from item in Alllist
                                           where item.GV_Group == "건조"
                                           select item).ToList();
            dgvDry.DataSource = GvList;
        }

        private void GetFireGridView(object sender, EventArgs e)
        {
            List<GVMonitoringVO> GvList = (from item in Alllist
                                           where item.GV_Group == "소성"
                                           select item).ToList();
            dgvPlasticity.DataSource = GvList;
        }
        private void GetEmptyGridView(object sender, EventArgs e)
        {
            List<GVMonitoringVO> GvList = (from item in Alllist
                                           where item.GV_Status == "빈대차"
                                           select item).ToList();
            dgvGvWait.DataSource = GvList;
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvDry, "대차명", "GV_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "상태", "GV_Status", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "그룹명", "GV_Group", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "수량", "GV_Qty", true, 80);
            CommonClass.AddNewColumnToDataGridView(dgvDry, "로딩시간", "Loading_time", true, 120);
           
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "대차명", "GV_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "상태", "GV_Status", true, 80);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "그룹명", "GV_Group", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "수량", "GV_Qty", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvPlasticity, "로딩시간", "Loading_time", true, 120);

            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "대차명", "GV_Name", true, 70);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "빈 대차", "GV_Status", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "상태", "GV_Group", false, 70);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "작업지시번호", "Workorderno", false, 150);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "품목코드", "Item_Code", false, 120);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "품목명", "Item_Name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "수량", "GV_Qty", false, 70);
            CommonClass.AddNewColumnToDataGridView(dgvGvWait, "로딩시간", "Loading_time", false, 120);
        }

        private void GVMonitoring_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetDryGridView);
            frm.Search_Click += new System.EventHandler(this.GetFireGridView);
            frm.Search_Click += new System.EventHandler(this.GetEmptyGridView);
        }

        private void GVMonitoring_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetDryGridView);
            frm.Search_Click -= new System.EventHandler(this.GetFireGridView);
            frm.Search_Click -= new System.EventHandler(this.GetEmptyGridView);
        }
    }
}
