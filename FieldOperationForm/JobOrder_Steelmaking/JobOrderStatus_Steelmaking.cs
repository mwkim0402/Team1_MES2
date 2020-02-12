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
    public partial class JobOrderStatus_Steelmaking : Form
    {
        Main_P main;
        string no;
        string start;

        public JobOrderStatus_Steelmaking(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            main.btn_Max.Click += Sizeup;
            main.btn_Min.Click += SizeDown;
        }

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
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Plan_Date", false, 175);

            this.dataGridView1.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Regular);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void SetLoad()
        {
            WorkOrder_Service service = new WorkOrder_Service();

            dataGridView1.DataSource = service.IronWork();


        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            ProcessCondition frm = new ProcessCondition(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "공정조건 등록";
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


        private void btn_mold_Click(object sender, EventArgs e)
        {
            Mold frm = new Mold(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "금형 장착 / 탈착 등록";
        }

        private void JobOrderStatus_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void btn_StartEnd_Click(object sender, EventArgs e)
        {
            if (start == "작업대기")
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                start = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //   no = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                no = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            }
            catch { }
        }

        private void btn_FieldClose_Click(object sender, EventArgs e)
        {
      
        }

        private void JobOrderStatus_Steelmaking_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "제강";
            main.lblChange.Text = "작업지시 현황";
            SetLoad();
        }
        private void Sizeup(object sender, EventArgs e)
        {
          //if(  this.WindowState == FormWindowState.Normal)
          //  btn_FieldClose.Location = new Point(100, 100);
        }
        private void SizeDown(object sender, EventArgs e)
        {
            //btn_FieldClose.Location = new Point(425, 432);
        }

    }
}