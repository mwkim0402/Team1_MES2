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
        public NonOperation(Main_P main1)
        {
     
            InitializeComponent();
            main = main1;
         
        }

        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
             int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft )
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

            AddNewColumnToDataGridView(dgv_NonOperation, "작업장", "Title", true,180);
            AddNewColumnToDataGridView(dgv_NonOperation, "주원인", "Notice_Date", true, 136);
            AddNewColumnToDataGridView(dgv_NonOperation, "상세원인", "Ins_Emp", true, 350);
            AddNewColumnToDataGridView(dgv_NonOperation, "발생시각", "Description", true, 140);
            AddNewColumnToDataGridView(dgv_NonOperation, "해제시각", "Description", true, 140);
            AddNewColumnToDataGridView(dgv_NonOperation, "비가동시간(분)", "Description", true, 170);
            this.dgv_NonOperation.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dgv_NonOperation.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);
   


            dgv_NonOperation.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void NonOperation_Load(object sender, EventArgs e)
        {
            Setdgv();
        }
    }
}
