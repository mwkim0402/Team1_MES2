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
    public partial class CreatePalette : Form
    {
        Main_P main;
        string p;
        List<WorkOrder_Vo> list = null;

        public CreatePalette(Main_P main1,string no)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            p = no;
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

         
            AddNewColumnToDataGridView(dataGridView1, "팔레트번호", "Title", true, 255);
            AddNewColumnToDataGridView(dataGridView1, "제품", "Title", true, 172);
            AddNewColumnToDataGridView(dataGridView1, "등급", "Title", true, 160);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Title", true, 160);




            this.dataGridView1.Font = new Font("나눔고딕", 15, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        private void SetWork()
        {
            WorkOrder_Vo vo = new WorkOrder_Vo();
            WorkOrder_Service service = new WorkOrder_Service();

            
            list = service.GetTextWorkOrder(p);

           
            txt_WorkNum.Text = list[0].ToString();
          //  txt_WorkNum.Text = vo.Workorderno;
            txt_Item.Text = vo.Item_Name;
            txt_WorkPlace.Text = vo.Wc_Name;
            txt_WorkDate.Text = vo.Prd_Starttime.ToString();
            txt_ResultNum.Text = vo.Prd_Qty.ToString();
            txt_unit.Text = vo.Prd_Unit;
        }

        private void CreatePalette_Load(object sender, EventArgs e)
        {
            SetWork();
        }
    }
}
