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
            string user = dgvProductRequset.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<WorkdiligenceStatusanalysisVO> Gdv2list = (from item in AllList
                                                            where item.User_ID == user
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
            //}
            //else
            //{
            //    list2 = (from item in list
            //             where item.User_ID == fcWorker.SendCode
            //             select new WorkdiligenceStatusanalysisVOgridview1
            //             {
            //                 User_ID = item.User_ID,
            //                 Work_Date = item.Work_Date
            //             }).ToList();
            //    dgvProductRequset.DataSource = list2;
            //}
        }
        private void ShowDgv()
        {
            dgvProductRequset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dgvProductRequset.CellDoubleClick += DgvProductRequset_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업자", "User_ID", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "근무일", "Work_Date", true, 150,DataGridViewContentAlignment.MiddleCenter);

            dgvJobOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장코드", "Wc_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업장명", "Wc_Name", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시작일시", "Prd_Starttime", true, 200,DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업종료일시", "Prd_Endtime", true, 200,DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업시간", "Work_Time", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "생산수량", "Prd_Qty", true, 120,DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "할당작업자", "User_ID", true, 150);
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
            List<WorkdiligenceStatusanalysisVOgridview1> list = (from item in AllList
                                                                 where item.User_ID == fcWorker.SendCode
                                                                 select new WorkdiligenceStatusanalysisVOgridview1
                                                                 {
                                                                     User_ID = item.User_ID,
                                                                     Work_Date = item.Work_Date
                                                                 }).ToList();
            dgvProductRequset.DataSource = list;
        }
    }
}
