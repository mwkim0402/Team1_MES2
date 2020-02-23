using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class JobOrderStatus_Load : Form
    {
        Main_P main;

        string no;
        string start;
        string work;
        string A;
        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
        List<WorkOrderCheckVo> processWorkList;
        List<ItemVo> itemList;
        List<WorkCenterPort> wcPortList;
        List<MoldStart_Vo> MList = null;

        public List<MoldStart_Vo> DataGridViewComboBoxCell { get; private set; }

        public JobOrderStatus_Load(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
       




        }
        #region 그리드뷰 설정
        // DataGridView 컬럼 설정
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
           int colWidth = 150, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
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

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "금형선택";
            comboBoxColumn.Width = 200;

            comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            dataGridView1.Columns.Add(comboBoxColumn);
            


            AddNewColumnToDataGridView(dataGridView1, "장착중인금형", "Mold_Name", true, 200);
            AddNewColumnToDataGridView(dataGridView1, "상태", "Wo_Status", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "Workorderno", true, 350);
            AddNewColumnToDataGridView(dataGridView1, "할당작업장", "Wc_Name", true, 230);
            AddNewColumnToDataGridView(dataGridView1, "품목명", "Item_Name", true, 200);

            AddNewColumnToDataGridView(dataGridView1, "계획수량", "Plan_Qty", true, 140);
            AddNewColumnToDataGridView(dataGridView1, "생산일자", "Plan_date", true, 150);
            AddNewColumnToDataGridView(dataGridView1, "계획시작시간", "Plan_Starttime", true, 180);
            AddNewColumnToDataGridView(dataGridView1, "생산시작시간", "Prd_Starttime", true, 180);
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Prd_Endtime", true, 180);
            AddNewColumnToDataGridView(dataGridView1, "생산종료시간", "Plan_Unit", false, 180);
            this.dataGridView1.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Regular);

          
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = String.Format(@"select Mold_Name from Mold_Master where Mold_Status = 'Y'");


                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "Mold_Master");
                conn.Close();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    comboBoxColumn.Items.Add(dr["Mold_Name"]);

                }


            }

        }
        #endregion

        private void SetLoad()
        {
            Roll_Service service = new Roll_Service();
            dataGridView1.DataSource = service.getRollWork() ;      
            
            WorkOrderService service2 = new WorkOrderService();
            processWorkList = service2.GetPrcocess_Workorder(main.lbl_Job.Text);
            ItemService service3 = new ItemService();
            itemList = service3.GetAllItemInfo();
            WorkCenterService wcService = new WorkCenterService();
            wcPortList = wcService.WorkCenterPortNum();

           // MoldStart_Service service6 = new MoldStart_Service();
           //DataGridViewComboBoxCell = service6.GetMoldName(work);
        

        }


        private void JobOrderStatus_Load_Load(object sender, EventArgs e)
        {
            main.lbl_Job.Text = "압연";
      

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

        private void btn_Process_Click(object sender, EventArgs e)
        {
            ProcessCondition frm = new ProcessCondition(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "공정조건 등록";
        }
        private void JobOrderStatus_Load_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void btn_StartEnd_Click(object sender, EventArgs e)
        {
            
            if (no==null && start=="작업대기")
            {
                MessageBox.Show("금형을 선택해주세요.");
               main.btn_Home.PerformClick();
            }
            else if(start=="작업중" || start=="작업종료" || start=="현장마감")
            {
                MessageBox.Show("대기중인 작업지시를 선택해주세요.");
                main.btn_Home.PerformClick();
            }

            else
            {
                if (start == "작업대기")
                {

                    WorkCenterService service = new WorkCenterService();
                    if (service.wcStatusChecked(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) == "RUN")
                    {
                        MessageBox.Show("작업장에 실행중인 작업이 존재하여 실행할 수 없습니다.");
                        return;
                    }
                    else 
                    {
                        Start_Factory();
                        SetLoad();


                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //작업상태
                start = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //   no = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          
                //작업지시번호
                work = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                MoldStart_Service service6 = new MoldStart_Service();
                //DataGridViewComboBoxCell = service6.GetMoldName(work);
                comboBoxColumn.DataSource = service6.GetMoldName(work);
                //선택금형
                no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //장착된금형
                A = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                
            }
            catch { }
        }

        private void Start_Factory()
        {
            string workWorderNo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            try
            {
                int UPHperSecond = (int)itemList.Find(x => x.Item_Name == (dataGridView1.SelectedRows[0].Cells[5].Value.ToString())).IronUPH / 60 / 20;
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

                MoldStart_Vo vo = new MoldStart_Vo();
                vo.Mold_Name = A;
                vo.Workorderno = work;
                MoldStart_Service service5 = new MoldStart_Service();
                service5.MoldStartHistory(vo);
            }
            catch (Exception err)
            {
                MessageBox.Show($"{processWorkList.Find(y => y.Workorderno == workWorderNo).Wc_Code} 작업장이 비가동 중 입니다.");
            }
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

        //private void initComboBox()
        //{
        //    MoldStart_Service service = new MoldStart_Service();
        //    MList = service.GetMoldName(work);
        //    if (MList.Count > 0)
        //    {
        //        List<string> NonList = (from item in MList
        //                                select item.Mold_Name).ToList();
        //        CommonUtil.ComboBinding(comboBoxColu, NonList);
        //    }

        //}

        private void btn_FieldClose_Click(object sender, EventArgs e)
        {
            if(start=="작업종료")
            {
            
                WorkOrder_Service service = new WorkOrder_Service();
                service.deadlineWork(work);

                MoldStart_Vo vo = new MoldStart_Vo();
                vo.Workorderno = work;
                vo.Mold_Name = A;
                MoldStart_Service service1 = new MoldStart_Service();
                service1.MoldEndHistory(vo);
                SetLoad();
            
            }
            else
            {
                MessageBox.Show("종료된 작업지시를 선택해주세요.");
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            InspectForm frm = new InspectForm(main);
            frm.BringToFront();
            frm.MdiParent = main;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            main.lblChange.Text = "품질 규격 측정";
        }
    }
}
