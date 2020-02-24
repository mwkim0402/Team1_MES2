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
        DateTime StartDate;
        DateTime EndDate;
        string Workorderno;
        decimal value = 0;
        int primary = 0;
        string check;
        string proName = string.Empty;
        public RegProcess()
        {
            InitializeComponent();
        }

        private void RegProcess_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
        }

        private void GetData(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllRegProcess();

            List<SubRegProcessVO> AList = (from aa in allList
                                           select new SubRegProcessVO
                                           {
                                               Workorderno = aa.Workorderno,
                                               Wc_Name = aa.Wc_Name,
                                               Process_name = aa.Process_name,
                                               Condition_measure_seq = aa.Condition_measure_seq
                                           }).ToList();


            List<SubRegProcessVO> RList = new List<SubRegProcessVO>();
            List<SubRegProcessVO> QList = new List<SubRegProcessVO>();
            SubRegProcessVO subvo = new SubRegProcessVO();
            foreach (var it in AList)
            {
                if (it.Process_name == subvo.Process_name)
                {
                    continue;
                }
                else
                {
                    subvo = it;
                    RList.Add(it);
                }
            }



            dgvJob.DataSource = RList;


        }
        private void ShowDgv()
        {
            //dgvJob.AutoGenerateColumns = false;
            //dgvJob.AllowUserToAddRows = false;
            dgvJob.CellDoubleClick += dgvJob_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업지시번호", "Workorderno", true, 160);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "생산일자", "Plan_Date", false, 120, DataGridViewContentAlignment.MiddleCenter); ;
            CommonClass.AddNewColumnToDataGridView(dgvJob, "공정", "Process_name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목코드", "Item_Code", false, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "품목명", "Item_Name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Condition_Name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "SL", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Condition_Val", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Wc_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Condition_measure_seq", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJob, "x", "Condition_Group", false, 100);

            MakeDgv();

        }

        private void MakeDgv()
        {
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvList, "측정항목", "Condition_Name", false, 130);
            CommonClass.AddNewColumnToDataGridView(dgvList, "측정항목", "Condition_Group", true, 130);
            CommonClass.AddNewColumnToDataGridView(dgvList, "기준값", "SL", true, 100);

            dgvListDetail.CellDoubleClick += DgvListDetail_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvListDetail, "측정값", "Condition_Val", true, 100);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (allList != null)
            {
                if ((fcWork.SendCode != null && fcWork.SendName != "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<RegProcessVO> list = (from item in allList
                                               where item.Process_code == fcFactory.SendCode && item.Wc_Code == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                               select item).ToList();
                    dgvJob.DataSource = list;
                    dgvList.DataSource = null;
                    dgvListDetail.DataSource = null;

                }
                else if ((fcWork.SendCode != null && fcWork.SendCode != "") && (fcFactory.SendCode == null || fcFactory.SendCode == ""))
                {
                    List<RegProcessVO> list = (from item in allList
                                               where item.Wc_Code == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                               select item).ToList();
                    dgvJob.DataSource = list;

                }
                else if ((fcWork.SendCode == null || fcWork.SendCode == "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<RegProcessVO> list = (from item in allList
                                               where item.Process_code == fcFactory.SendCode && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                               select item).ToList();
                    dgvJob.DataSource = list;

                }
                else if ((fcFactory.SendCode == null || fcFactory.SendCode == "") && (fcWork.SendCode == null || fcWork.SendCode == ""))
                {
                    List<RegProcessVO> list = (from item in allList
                                               where item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                               select item).ToList();
                    dgvJob.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("전체조회를 눌러주세요.");
            }


            if (dgvList.Columns.Count < 1 && dgvListDetail.Columns.Count < 1)
            {
                MakeDgv();
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_TabStopChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void dgvJob_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            primary = Convert.ToInt32(dgvJob.Rows[e.RowIndex].Cells[10].Value);
            Workorderno = dgvJob.Rows[e.RowIndex].Cells[7].Value.ToString();
            proName = dgvJob.Rows[e.RowIndex].Cells[11].Value.ToString();
            List<RegProcessListVO> list = (from item in allList
                                           where item.Workorderno == dgvJob.Rows[e.RowIndex].Cells[7].Value.ToString() && item.Process_name == dgvJob.Rows[e.RowIndex].Cells[11].Value.ToString()
                                           select new RegProcessListVO
                                           {
                                               Condition_Name = item.Condition_Name,
                                               SL = item.SL,
                                               Condition_Group = item.Condition_Group
                                           }).ToList();
            dgvList.DataSource = list;
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<RegProcessListMeaVO> list = (from item in allList
                                              where item.Workorderno == Workorderno && item.Condition_Name == dgvList.Rows[e.RowIndex].Cells[0].Value.ToString() && item.Process_name == proName
                                              select new RegProcessListMeaVO
                                              {
                                                  Condition_Val = item.Condition_Val
                                              }).ToList();
            dgvListDetail.DataSource = list;

            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void DgvListDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            check = dgvListDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
            value = Convert.ToInt64(nuNum.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check != null && check != "")
            {
                MES_DB.PerformService service = new MES_DB.PerformService();
                service.UpdateRegProcess(value, primary);

                MessageBox.Show("수정되었습니다.");
                dgvJob.DataSource = null;
                dgvList.DataSource = null;
                dgvListDetail.DataSource = null;
                ShowDgv();
            }
            else
            {
                MessageBox.Show("수정할 셀을 선택해주세요.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (check != null && check != "")
            {
                MES_DB.PerformService service = new MES_DB.PerformService();
                service.DeleteRegProcess(primary);
                MessageBox.Show("삭제되었습니다.");
                dgvJob.DataSource = null;
                dgvList.DataSource = null;
                dgvListDetail.DataSource = null;
                ShowDgv();
            }
            else
            {
                MessageBox.Show("삭제할 셀을 선택해주세요.");
            }
        }
    }
}
