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
    public partial class JobOrderStatus_Package : Form
    {
        Main_P main;
        string no;
        string start;
        string wc;
        string itemname;
        string sd;
        string qty;
        string unit;

        
        public JobOrderStatus_Package(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
        }

        #region 그리드뷰설정
        // DataGridView 컬럼 설정
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
            col.DefaultCellStyle.Padding = new Padding(3);
            dgv.Columns.Add(col);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dgv.RowTemplate.Height = 50;

        }
        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "상태", "Wo_Status", true, 120);
            AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "Workorderno", true, 200);
            AddNewColumnToDataGridView(dataGridView1, "할당작업장", "Wc_Name", true, 175);
            AddNewColumnToDataGridView(dataGridView1, "품목명", "Item_Name", true, 230);
            AddNewColumnToDataGridView(dataGridView1, "단위", "Plan_Unit", true, 100);
            AddNewColumnToDataGridView(dataGridView1, "실적수량", "Plan_Qty", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "생산시작시간", "Plan_Starttime", true, 280);
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Plan_Endtime", true, 280);
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Plan_Qty", false, 175);
            this.dataGridView1.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Regular);


            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        #endregion

        private void SetLoad()
        {
            WorkOrder_Service service = new WorkOrder_Service();

            dataGridView1.DataSource = service.GetWorkOrder(main.lbl_Job.Text);


        }

        private void JobOrderStatus_Package_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "포장";
            main.lblChange.Text = "작업지시 현황";
            SetLoad();
        }

 

        private void btn_Quality_Click(object sender, EventArgs e)
        {
            QualityMeasurement frm = new QualityMeasurement(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "품질 측정값 등록";
        }

        private void btn_Worker_Click(object sender, EventArgs e)
        {
            workerAllocation frm = new workerAllocation(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업자할당";
        }

        private void btn_JobOrder_Click(object sender, EventArgs e)
        {
            JobOrder frm = new JobOrder(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업지시 생성";
        }

        private void btn_CreatePalette_Click(object sender, EventArgs e)
        {
            CreatePalette frm = new CreatePalette(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "팔레트 생성";


        }

        private void btn_BarCode_Click(object sender, EventArgs e)
        {
            PaletteBarCode frm = new PaletteBarCode(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "팔레트 바코드 재발행";
        }

        private void btn_warehousing_Click(object sender, EventArgs e)
        {
            warehousing frm = new warehousing(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "포장 입고 등록";
        }

        private void btn_Unloading_Click(object sender, EventArgs e)
        {
            Unloading frm = new Unloading(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "포장 언로딩";
        }

        private void JobOrderStatus_Package_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                no = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                start = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();



            }
            catch { }
        }

        private void btn_StartEnd_Click(object sender, EventArgs e)
        {
            if (start == "대기")
            {
                WorkOrder_Service service = new WorkOrder_Service();

                service.StartWork(no);

                SetLoad();
            }

            else if (start == "작업시작")
            {
                WorkOrder_Service service = new WorkOrder_Service();

                service.EndWork(no);

                SetLoad();
            }
        }
    }
}
