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
    public partial class Mold : Form
    {
        Main_P main;
  
        public Mold(Main_P main1)
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

            AddNewColumnToDataGridView(dataGridView1, "금형코드", "Title", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "금형명", "Title", true, 204);
            AddNewColumnToDataGridView(dataGridView1, "금형그룹", "Title", true, 200);



            this.dataGridView1.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 16, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AddNewColumnToDataGridView(dataGridView2, "금형코드", "Notice_Date", true, 130);
            AddNewColumnToDataGridView(dataGridView2, "금형명", "Notice_Date", true, 204);
            AddNewColumnToDataGridView(dataGridView2, "금형그룹", "Notice_Date", true, 200);


            this.dataGridView2.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 16, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
