using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
        List<WorkOrderCheckVo> processWorkList;
        List<ItemVo> itemList;
        List<WorkCenterPort> wcPortList;

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
            dgv.RowTemplate.Height = 60;

        }
        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "상태", "Wo_Status", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "Workorderno", true, 370);
            AddNewColumnToDataGridView(dataGridView1, "할당작업장", "Wc_Name", true, 200);
            AddNewColumnToDataGridView(dataGridView1, "품목명", "Item_Name", true, 230);

            AddNewColumnToDataGridView(dataGridView1, "생산수량", "Plan_Qty", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "생산일자", "Plan_Date", true, 200);
            AddNewColumnToDataGridView(dataGridView1, "생산시작시간", "Plan_Starttime", true, 280);
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Plan_Endtime", true, 279);
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

 

     

        private void btn_Worker_Click(object sender, EventArgs e)
        {
            workerAllocation frm = new workerAllocation(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "작업자할당";
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
        private void Start_Factory()
        {
            string workWorderNo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                int UPHperSecond = (int)itemList.Find(x => x.Item_Name == (dataGridView1.SelectedRows[0].Cells[3].Value.ToString())).IronUPH / 60 / 20;
                Random rnd = new Random((int)DateTime.UtcNow.Ticks);
                int faultyQty = rnd.Next(0, 2);
                TcpClient tc = new TcpClient("127.0.0.1", wcPortList.Find(x => x.Wc_Code == processWorkList.Find(y => y.Workorderno == workWorderNo).Wc_Code).Port_Num);
                NetworkStream stream = tc.GetStream();
                string msg = $"{workWorderNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Wc_Code}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}";
                byte[] buff = Encoding.UTF8.GetBytes(msg);
                stream.Write(buff, 0, buff.Length);
                byte[] outBuff = new byte[2048];
                int nbytes = stream.Read(outBuff, 0, outBuff.Length);
                string outMsg = Encoding.UTF8.GetString(outBuff, 0, nbytes);
                stream.Close();
                tc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show($"{processWorkList.Find(y => y.Workorderno == workWorderNo).Wc_Code} 작업장이 비가동 중 입니다.");
            }
        }

        private void btn_FieldClose_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReadBarcode_Click(object sender, EventArgs e)
        {
            ReadBarcode frm = new ReadBarcode();
            frm.ShowDialog();
        }
    }
}
