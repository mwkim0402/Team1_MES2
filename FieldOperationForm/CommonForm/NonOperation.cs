using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class NonOperation : Form
    {
        Main_P main;
        string a;
        string b;
        string c;
        public NonOperation(Main_P main1)
        {

            InitializeComponent();
            main = main1;
            Setdgv();
            AllNon();

        }


        #region 그리드뷰 설정
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

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dgv_NonOperation, "작업장", "Wc_Name", true, 120);
            AddNewColumnToDataGridView(dgv_NonOperation, "주원인", "Nop_Ma_Name", true, 146);
            AddNewColumnToDataGridView(dgv_NonOperation, "상세원인", "Nop_Mi_Name", true, 250);
            AddNewColumnToDataGridView(dgv_NonOperation, "발생시각", "Nop_Happentime", true, 220);
            AddNewColumnToDataGridView(dgv_NonOperation, "해제시각", "Nop_Canceltime", true, 220);
            AddNewColumnToDataGridView(dgv_NonOperation, "비가동시간(분)", "Nop_time", true, 160);
            this.dgv_NonOperation.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dgv_NonOperation.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dgv_NonOperation.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #endregion 

        private void NonOperation_Load(object sender, EventArgs e)
        {

        }

        private void NonOperation_Shown(object sender, EventArgs e)
        {
            dgv_NonOperation.CurrentCell = null;
        }
        private void AllNon()
        {
            NonOperation_Service service = new NonOperation_Service();
            dgv_NonOperation.DataSource = service.AllNonOperation();
        }

        private void dgv_NonOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                a = dgv_NonOperation.Rows[e.RowIndex].Cells[0].Value.ToString();
                b = dgv_NonOperation.Rows[e.RowIndex].Cells[1].Value.ToString();
                c = dgv_NonOperation.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void btn_NonOperation_Click(object sender, EventArgs e)
        {
            UpdateNonOperation frm = new UpdateNonOperation(a,b,c);
            frm.Show();

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllNon();
        }
    }
}
