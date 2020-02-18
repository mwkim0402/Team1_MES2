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
    public partial class workerAllocation : Form
    {
        List<WorkCenter_Vo> CList = null;
        List<WorkCenter_Vo> QList = null;
        List<WorkAllocation_Vo> WList = null;
        List<WorkAllocation_Vo> MList = null;
        Main_P main;
        string a;
        string b;

        public workerAllocation(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetWorkerList();
            SetWorker();
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
            col.DefaultCellStyle.Padding = new Padding(3);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dgv.RowTemplate.Height = 60;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "작업자", "User_Name", true, 254);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Allocation_datetime", true, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Wc_Code ", false, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "User_ID ", false, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Release_datetime", false, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Wc_Name", false, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Wc_Group", false, 280);
            AddNewColumnToDataGridView(dataGridView1, "할당시각", "Process_Code", false, 280);
  
       


            this.dataGridView1.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     


            AddNewColumnToDataGridView(dataGridView2, "작업자", "User_Name", true, 253);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Wc_Name", true, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Wc_Code ", false, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "User_ID ", false, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Release_datetime", false, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Wc_Group", false, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Process_Code", false, 281);
            AddNewColumnToDataGridView(dataGridView2, "현재작업장", "Allocation_datetime", false, 281);


            this.dataGridView2.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #endregion

        private void SetWorker()
        {
            WorkAllocation_Service service = new WorkAllocation_Service();

            MList = service.GetWorker(cb_Wc_Name.Text);
            dataGridView1.DataSource = MList;

        }

        private void SetWorkerList()
        {

            WorkAllocation_Service service = new WorkAllocation_Service();

            WList = service.GetWorkerList(cb_Wc_Name.Text);

            dataGridView2.DataSource = WList;

        }

        private void workerAllocation_Load(object sender, EventArgs e)
        {

            initComboBox();




        }

        private void btn_WorkerOn_Click(object sender, EventArgs e)
        {
            try
            {
                WorkAssignment_Vo wa = new WorkAssignment_Vo();
                wa.User_Name = a;
                wa.Wc_Name = cb_Wc_Name.Text;
                WorkAllocation_Service service = new WorkAllocation_Service();
                service.WorkAssignment(wa);
                SetWorkerList();
                SetWorker();
                a = "";
            }
            catch { }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell = null;
            try
            {
                a = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                label8.Text = a;
            }
            catch { }
        }

        private void btn_WorkerOff_Click(object sender, EventArgs e)
        {
            try
            {
                WorkAllocation_Service service = new WorkAllocation_Service();

                service.deleteWorker(b);

                SetWorkerList();
                SetWorker();
                b = "";
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView2.CurrentCell = null;
            try
            {
                b = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                label8.Text = b;
            }
            catch { }
        }

        private void workerAllocation_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView2.CurrentCell = null;
        }

        private void btn_WorkerFullOff_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("전체 해제 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                WorkAllocation_Service service = new WorkAllocation_Service();
                service.deleteAllWorker(cb_Wc_Name.Text);
         

            }

            SetWorkerList();
            SetWorker();


        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            txt_WorkerNum.Text = dataGridView1.RowCount.ToString();
        }


        private void initComboBox()
        {
          

                WorkCenter_Service service = new WorkCenter_Service();
                WorkCenter_Vo vo = new WorkCenter_Vo();
                CList = service.GetWorkCenter(main.lbl_Job.Text);
                if (CList.Count > 0)
                {
                    List<string> NonList = (from item in CList
                                            select item.Wc_Name).ToList();
                    CommonUtil.ComboBinding(cb_Wc_Name, NonList);
                }
            
        }
 

        private void cb_Wc_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWorker();
            SetWorkerList();
        }
    }
}
