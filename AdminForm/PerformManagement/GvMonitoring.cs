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
        List<WorkCenterVO> Alllist;
        public GVMonitoring()
        {
            InitializeComponent();
            

        }

        private void GvMonitoring_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            MES_DB.PerformService service = new MES_DB.PerformService();
            Alllist = service.GetAllWorkCenter();
        }
        private void GetDryGridView(object sender, EventArgs e)
        {
           
        }

        private void GetFireGridView(object sender, EventArgs e)
        {
           
        }
       

        private void ShowDgv()
        {
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "대차명", "GV_Name", true, 100);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "상태", "GV_Status", true, 70);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "그룹명", "GV_Group", true, 100);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "작업지시번호", "Workorderno", true, 150);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "품목코드", "Item_Code", true, 120);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "품목명", "Item_Name", true, 100);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "수량", "GV_Qty", true, 80,DataGridViewContentAlignment.MiddleRight);
            //CommonClass.AddNewColumnToDataGridView(dgvDry, "로딩시간", "Loading_time", true, 120);
           
            

           
        }

        private void GVMonitoring_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetDryGridView);
            frm.Search_Click += new System.EventHandler(this.GetFireGridView);
        }

        private void GVMonitoring_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetDryGridView);
            frm.Search_Click -= new System.EventHandler(this.GetFireGridView);
            
        }
    }
}
