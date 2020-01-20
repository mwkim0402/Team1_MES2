using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class workerAllocation : ConnectionAccess
    {

        List<WorkAllocation_Vo> WList = null;
        Main_P main;
        public workerAllocation(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetWorkerList();
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
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "작업자", "Title", true, 254);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Notice_Date", true, 280);


            this.dataGridView1.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     


            AddNewColumnToDataGridView(dataGridView2, "작업자", "User_Name", true, 253);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Wc_Name", true, 281);

            this.dataGridView2.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #endregion

        private void Set()
        {
            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                string sql = string.Format("select Wc_Name from WorkCenter_Master where Wc_Name = '{1}", main.lbl_Job.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                
            }
           
        
        }

        private void SetWorkerList()
        {

            WorkAllocation_Service service = new WorkAllocation_Service();

            WList = service.GetWorkerList(main.lbl_Job.Text);



        }

        private void workerAllocation_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = WList;
        }
    }
}
