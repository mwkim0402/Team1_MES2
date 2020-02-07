using MES_DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AdminForm
{
    public partial class MoldUseStatus : dgvOne
    {
        List<MoldUseHistoryVo> list = null;
        MainForm frm;

        public MoldUseStatus()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            MoldingService service = new MoldingService();
            list = service.MoldUseHistory();
        }
        private void MoldUseStatus_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;

            //AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "???", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "금형코드", "Mold_Code", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형명", "Mold_Name", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "작업지시번호", "Workorderno", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "작업장코드", "Wc_Code", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "작업장명", "Wc_Name", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형타수", "Mold_Shot_Cnt", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형생산량", "Mold_Prd_Qty", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형사용시작시간", "Use_Starttime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형사용종료시간", "Use_Endtime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형사용시간", "UsingTime", true, 150);
            LoadList();
            dgvSearchResult.DataSource = list;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtpStart.Value = dtpEnd.Value.AddDays(-7);
        }
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
    int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleCenter)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(col);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
        }

        //검색
        private void Search(object sender, EventArgs e)
        {
            LoadList();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //frm.lblAlertTitle.Text = "";
            frm.lblAlert.Text = "<공지사항> Test 중 입니다.";
            timer1.Stop();
        }
    

        private void MoldUseStatus_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new EventHandler(Search);
        }

        private void MoldUseStatus_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new EventHandler(Search);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strStart = dtpStart.Value.ToString();
            string strEnd = dtpEnd.Value.ToString();

            MoldingService ser = new MoldingService();
            if (fcItem.SendCode == null)
            {
                if (fcWorkPlace.SendCode == null)
                {
                    list = ser.SearchMoldUse(strStart, strEnd, "", "");
                    dgvSearchResult.DataSource = list;
                }
                else
                {
                    list = ser.SearchMoldUse(strStart, strEnd, "", fcWorkPlace.SendCode);
                    dgvSearchResult.DataSource = list;
                }
            }
            else
            {
                if (fcWorkPlace.SendCode == null)
                {
                    list = ser.SearchMoldUse(strStart, strEnd, fcItem.SendCode, "");
                    dgvSearchResult.DataSource = list;
                }
                else
                {
                    list = ser.SearchMoldUse(strStart, strEnd, fcItem.SendCode, fcWorkPlace.SendCode);
                    dgvSearchResult.DataSource = list;
                }
            }
            if (list.Count < 1)
            {
                frm.lblAlert.Text = "[알람] 검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
            frm.lblAlert.Text = $"[알람] {list.Count} 건의 데이터가 조회되었습니다.";
            timer1.Start();
            dgvSearchResult.DataSource = list;
        }
    }
}
