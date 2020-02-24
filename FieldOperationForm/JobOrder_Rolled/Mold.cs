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

        string a;
        string b;
        public Mold(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetMold();
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
            dgv.RowTemplate.Height = 50;
            col.DefaultCellStyle.Padding = new Padding(3);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Ivory;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "금형코드", "Mold_Code", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "금형명", "Mold_Name", true, 204);
            AddNewColumnToDataGridView(dataGridView1, "금형그룹", "Mold_Group", true, 200);



            this.dataGridView1.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 16, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AddNewColumnToDataGridView(dataGridView2, "금형코드", "Mold_Code", true, 130);
            AddNewColumnToDataGridView(dataGridView2, "금형명", "Mold_Name", true, 204);
            AddNewColumnToDataGridView(dataGridView2, "금형그룹", "Mold_Group", true, 200);


            this.dataGridView2.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 16, FontStyle.Bold);



            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Mold_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView2.CurrentCell = null;
        }

        private void SetMold()
        {
            Mold_Service service = new Mold_Service();
            dataGridView2.DataSource= service.GetYMold();
            dataGridView1.DataSource = service.GetNMold();
        }

        private void btn_Reissue_Click(object sender, EventArgs e)
        {
            Mold_Service service = new Mold_Service();
            service.UpdateUseMold(a);
            SetMold();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView2.CurrentCell = null;
                a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                button1.Enabled = false;
                btn_Reissue.Enabled = true;
            }
            catch { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = null;
                b = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                button1.Enabled = true;
                btn_Reissue.Enabled = false;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mold_Service service = new Mold_Service();
            service.DesorptionMold(b);
            SetMold();
        }
    }
}
