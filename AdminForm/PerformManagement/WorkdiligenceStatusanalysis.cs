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
        List<WorkdiligenceStatusanalysisVO> AllList;
        DateTime StartDate;
        DateTime EndDate;

        DateTime workdate;

        public WorkdiligenceStatusanalysis()
        {
            InitializeComponent();
        }

        private void WorkdiligenceStatusanalysis_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void DgvProductRequset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            workdate = Convert.ToDateTime(dgvProductRequset.Rows[e.RowIndex].Cells[1].Value); 
            string user = dgvProductRequset.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<WorkdiligenceStatusanalysisVO> Gdv2list = (from item in AllList
                                                            where item.User_ID == user && item.Work_Date == workdate.Date
                                                            select item).ToList();
            dgvJobOrder.DataSource = Gdv2list;
        }

        private void GetAllList(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            AllList = service.GetAllWorkStatus();
            List<WorkdiligenceStatusanalysisVOgridview1> list;
            //if (fcWorker.SendName == null)
            //{
            list = (from item in AllList
                    select new WorkdiligenceStatusanalysisVOgridview1
                    {
                        User_ID = item.User_ID,
                        Work_Date = item.Work_Date
                    }).ToList();
            dgvProductRequset.DataSource = list;
          
        }
        private void ShowDgv()
        {
            dgvProductRequset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dgvProductRequset.CellDoubleClick += DgvProductRequset_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업자", "User_ID", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "근무일", "Work_Date", true, 150, DataGridViewContentAlignment.MiddleCenter);

            dgvJobOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장코드", "Wc_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "Wc_Name", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시작일시", "Allocation_datetime", true, 200, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업종료일시", "Release_datetime", true, 200, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "생산수량", "Prd_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "할당작업자", "User_ID", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "근무일", "Work_Date", false, 150, DataGridViewContentAlignment.MiddleCenter);
        }

        private void WorkdiligenceStatusanalysis_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetAllList);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void WorkdiligenceStatusanalysis_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetAllList);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (AllList != null)
            {
                if (fcWorker.SendName != null && fcWorker.SendName != "")
                {
                    // AllList 에서 조회해서 데이터 그리드뷰에 넣는 부분
                    List<WorkdiligenceStatusanalysisVOgridview1> list = (from item in AllList
                                                                         select new WorkdiligenceStatusanalysisVOgridview1
                                                                         {
                                                                             User_ID = item.User_ID,
                                                                             Work_Date = item.Work_Date
                                                                             //Wc_Code = item.Wc_Code
                                                                         }).ToList();

                    List<WorkdiligenceStatusanalysisVOgridview1> Inslist = (from items in list
                                                                            where items.User_ID == fcWorker.SendCode && items.Work_Date >= StartDate.Date && items.Work_Date <= EndDate.Date
                                                                            select items).ToList();
                    dgvProductRequset.DataSource = Inslist;
                }
                else if(fcWorker.SendName == null || fcWorker.SendName == "")
                {
                    List<WorkdiligenceStatusanalysisVOgridview1> list = (from item in AllList
                                                                         select new WorkdiligenceStatusanalysisVOgridview1
                                                                         {
                                                                             User_ID = item.User_ID,
                                                                             Work_Date = item.Work_Date
                                                                         }).ToList();

                    List<WorkdiligenceStatusanalysisVOgridview1> Inslist = (from items in list
                                                                            where items.Work_Date >= StartDate.Date && items.Work_Date <= EndDate.Date
                                                                            select items).ToList();
                    dgvProductRequset.DataSource = Inslist;
                }
               

            }
            else
            {
                MessageBox.Show("전체조회를 눌러주세요.");
            }

        }
    }
}
