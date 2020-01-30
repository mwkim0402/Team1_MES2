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
    public partial class QualityMeasurement : Form
    {
        Main_P main;
        string a;
        string b;
        string c;
        string d;
        string g;

        string f;
        public QualityMeasurement(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            GetCon();
          
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

            AddNewColumnToDataGridView(dataGridView1, "측정항목", "Item_Name", true, 240);
            AddNewColumnToDataGridView(dataGridView1, "USL", "USL", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "SL", "SL", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "LSL", "LSL", true, 150);
            
            this.dataGridView1.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            AddNewColumnToDataGridView(dataGridView2, "측정값", "Inspect_Val", true, 302);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Inspect_Datetime", true, 290);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Item_Name", false, 290);
        
            this.dataGridView2.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #endregion

        private void GetCon()
        {
            Condition_Service service = new Condition_Service();
            dataGridView1.DataSource=service.GetCondition(main.lbl_Job.Text);
        }

        private void QualityMeasurement_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                a = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                b = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                d = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               
              
                txt_MeasuredValue.Text = ((Convert.ToDecimal( a)+ Convert.ToDecimal(b) + Convert.ToDecimal(c))/3).ToString();
                f = txt_MeasuredValue.Text;

                SetVal();

            }
            catch { }
        }
        private void SetVal()
        {
            Inspect_Service service = new Inspect_Service();
            Inspect_Vo vo = new Inspect_Vo();
            vo.Item_Name = d;
            vo.Inspect_Val = Convert.ToDecimal(f);
            dataGridView2.DataSource= service.GetVal(vo);

        }
        private void btn_Write_Click(object sender, EventArgs e)
        {
            Inspect_Service service = new Inspect_Service();
            Inspect_Vo vo = new Inspect_Vo();
            vo.Item_Name = d;
            vo.Inspect_Val = Convert.ToDecimal( txt_MeasuredValue.Text);

            service.InsertInspect(vo);

            MessageBox.Show("입력 완료");

            SetVal();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Inspect_Service service = new Inspect_Service();
                Inspect_Vo vo = new Inspect_Vo();
                vo.Item_Name = d;
                vo.Inspect_Val = Convert.ToDecimal(g.ToString());

                service.deleteVal(vo);

                SetVal();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                g = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
