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
    public partial class EmptyTruck : Form
    {
        Main_P main;



        public EmptyTruck(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
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

            AddNewColumnToDataGridView(dataGridView1, "건조대차", "Title", true, 427);
            AddNewColumnToDataGridView(dataGridView1, "적재 시각", "Notice_Date", true, 330);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Notice_Date", true, 330);


            this.dataGridView1.Font = new Font("나눔고딕", 19, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 19, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }
    }
}
