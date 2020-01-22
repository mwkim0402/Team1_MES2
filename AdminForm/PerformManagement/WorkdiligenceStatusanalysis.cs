using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MES_DB.Vo;

namespace AdminForm
{
    public partial class WorkdiligenceStatusanalysis : dgvTwo
    {
        MainForm frm;
        List<WorkdiligenceStatusanalysisVO> list;
        string StartDate;
        string EndDate;

        public WorkdiligenceStatusanalysis()
        {
            InitializeComponent();
        }

        private void WorkdiligenceStatusanalysis_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            MES_DB.PerformService service = new MES_DB.PerformService();
            list = service.GetAllWorkStatus();
            ShowDgv();

        }

        private void DgvProductRequset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = dgvProductRequset.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<WorkdiligenceStatusanalysisVO> Gdv2list = (from item in list
                                                            where item.User_ID == user
                                                            select item).ToList();
            dgvJobOrder.DataSource = Gdv2list;
        }

        private void GetAllList(object sender, EventArgs e)
        {
            List<WorkdiligenceStatusanalysisVOgridview1> list2;
            if (StartDate == null && EndDate == null && fcWorker.SendName == null)
            {
                list2 = (from item in list
                         select new WorkdiligenceStatusanalysisVOgridview1
                         {
                             User_ID = item.User_ID,
                             Work_Date = item.Work_Date
                         }).ToList();
                dgvProductRequset.DataSource = list2;
            }
            else
            {
                list2 = (from item in list
                         where item.Work_Date >= Convert.ToDateTime(StartDate.Substring(0, 10)) && item.Work_Date <= Convert.ToDateTime(EndDate.Substring(0, 10))
                                          && item.User_ID == fcWorker.SendCode
                         select new WorkdiligenceStatusanalysisVOgridview1
                         {
                             User_ID = item.User_ID,
                             Work_Date = item.Work_Date
                         }).ToList();
                dgvProductRequset.DataSource = list2;
            }
        }
        private void ShowDgv()
        {
            dgvProductRequset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dgvProductRequset.CellDoubleClick += DgvProductRequset_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업자", "User_ID", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "근무일", "Work_Date", true, 150);

            dgvJobOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장코드", "Wc_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시작일시", "Prd_Starttime", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업종료일시", "Prd_Endtime", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시간", "Work_Time", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "생산수량", "Prd_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "할당작업자", "User_ID", true, 100);
        }

        private void WorkdiligenceStatusanalysis_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetAllList);
        }

        private void WorkdiligenceStatusanalysis_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetAllList);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value.ToString();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value.ToString();
        }
    }
}
