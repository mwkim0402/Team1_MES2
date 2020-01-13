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
    public partial class MoldInformationRegister : dgvOneWithInput
    {

        List<MoldingInfoVo> List = null;


        public MoldInformationRegister()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            MoldingService service = new MoldingService();
            List = service.GetMoldingInfo();
        }
        private void MoldInformationRegister_Load(object sender, EventArgs e)
        {
            AddNewColumnToDataGridView(dgvSearchResult, "금형코드", "Mold_Code", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형명", "Mold_Name", true, 200);
            AddNewColumnToDataGridView(dgvSearchResult, "금형그룹", "Mold_Group", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형상태", "Mold_Status", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적타수", "Cum_Shot_Cnt", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적생산량", "Cum_Prd_Qty", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적사용시간", "Cum_Time", true, 145);
            AddNewColumnToDataGridView(dgvSearchResult, "보장타수", "Guar_Shot_Cnt", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "구입금액", "Purchase_Amt", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "입고일자", "In_Date", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "최종장착일시", "Last_Setup_Time", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 80);
            AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 80);
            LoadList();
            dgvSearchResult.DataSource = List;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
    }
}
