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
    public partial class JobOrderCreation : dgvOneWithInput
    {
        List<JobOrderCreateVo> List = null;
        public JobOrderCreation()
        {
            InitializeComponent();
        }
        private void RoadList()
        {
            JobOrderService service = new JobOrderService();
            List = service.JobOrderCreation();
        }
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
         int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
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

        private void JobOrderCreation_Load(object sender, EventArgs e)
        {
            AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 120);
            AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 255);
            AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Name", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "생산일자", "Prd_Date", true, 140);
            AddNewColumnToDataGridView(dgvSearchResult, "생산시작시각", "Prd_Starttime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "생산종료시간", "Prd_Endtime", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "투입수량", "In_Qty_Main", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "산출수량", "Out_Qty_Main", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "생산수량", "Prd_Qty", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 번호", "Wo_Req_No", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "생산의뢰 순번", "Req_Seq", true, 130);
            AddNewColumnToDataGridView(dgvSearchResult, "프로젝트명", "Remark", true, 150);
            RoadList();
            dgvSearchResult.DataSource = List;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


    }


   
}
