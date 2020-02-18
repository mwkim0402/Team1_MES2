using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class warehousing : Form
    {
        Main_P main;

        public warehousing(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetGood();
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

            AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "Workorderno", true, 417);
            AddNewColumnToDataGridView(dataGridView1, "팔레트번호", "Pallet_No", true, 230);
            AddNewColumnToDataGridView(dataGridView1, "제품", "Item_Name", true, 250);
            AddNewColumnToDataGridView(dataGridView1, "등급", "Grade_Code", true, 210);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Prd_Qty", true, 205);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Barcode_No", false, 130);




            this.dataGridView1.Font = new Font("나눔고딕", 18, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 18, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        private void warehousing_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }
        #region 시리얼 포트 연결
        private SerialPort _Port;
        /// <summary>
        /// 시리얼포트 컨트롤 객체
        /// </summary>
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM3";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;
                    _Port.DataReceived += Port_DataReceived;
                }
                return _Port;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);

            String msg = Port.ReadExisting();
            //"P002021400002/J9\r"
            this.Invoke(new EventHandler(delegate
            {
                Strings = msg;
            }));
        }

        #endregion
        /// <summary>
        /// 시리얼포트 상태 및 컨트롤 제어
        /// </summary>
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                    //Strings = "연결 됨";

                }
                else
                {
                    //Strings = "연결 해제됨";

                }
            }
        }
        /* 로그 제어 */
        private StringBuilder _Strings;
        /// <summary>
        /// 로그 객체
        /// </summary>
        private String Strings
        {
            set
            {
                if (_Strings == null)
                    _Strings = new StringBuilder(1024);
                // 로그 길이가 1024자가 되면 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                    _Strings.Clear();
                // 로그 추가 및 화면 표시
                _Strings.AppendLine(value);
                string str = _Strings.ToString();
                str = str.Replace("/J9\r\r\n", "");
                txt_PaletteNum.Text = str;
            }
        }


        private void SerialPortonnecting()
        {
            if (!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결.
                Port.PortName = "COM3";
                Port.BaudRate = 9600;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.Handshake = Handshake.None;

                try
                {
                    // 연결
                    Port.Open();
                }
                catch (Exception ex) { MessageBox.Show(String.Format("[ERR] {0}", ex.Message)); }
            }
            else
            {
                // 현재 시리얼이 연결 상태이면 연결 해제

            }

            // 상태 변경
            IsOpen = Port.IsOpen;
        }


        private void warehousing_Load(object sender, EventArgs e)
        {
            SerialPortonnecting();
        }

        private void btn_warehousing_Click(object sender, EventArgs e)
        {
            GoodHistory_Vo vo = new GoodHistory_Vo();
            vo.Barcode_No = txt_PaletteNum.Text;
            vo.Workorderno = txt_WorkNum.Text;

            GoodHistory_Service service = new GoodHistory_Service();
            service.UpdateGoodsHistory(vo);

            SetGood();
        }

        private void txt_PaletteNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_PaletteNum.Text.Length > 0)
            {
                //if (textBox1.Text.IndexOf('/') > 0)
                //{
                string barID = txt_PaletteNum.Text.Split('/')[0];
                txt_PaletteNum.Text = barID;//00094
                btn_Search.PerformClick();
                //}
            }
        }

        private void warehousing_Deactivate(object sender, EventArgs e)
        {
            Port.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //94에 해당하는 출고정보 조회해서 라벨에도 보여주고,
            //출고확인 메세지 처리
            //DB에서 재고를 떨구는 작업 하시고
            //버퍼를 비워준다.
            if (txt_PaletteNum.Text.Length > 0)
            {
                string barID = txt_PaletteNum.Text;


                string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
                DataSet ds = new DataSet();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = String.Format(@"select Barcode_No,g.Workorderno,Print_Date,I.Item_Name,w.Wc_Name,g.Prd_Qty,Grade_Code from Goods_In_History g ,WorkOrder o , WorkCenter_Master w ,Item_Master I
 where g.Workorderno=o.Workorderno and w.Wc_Code=o.Wc_Code and I.Item_Code=o.Item_Code and Barcode_No='{0}' ", txt_PaletteNum.Text);


                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(ds, "Goods_In_History");
                    conn.Close();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        txt_WorkNum.Text = dr["Workorderno"].ToString();
                        txt_WorkDate.Text = dr["Print_Date"].ToString();
                        txt_Item.Text = dr["Item_Name"].ToString();
                        txt_WorkPlace.Text = dr["Wc_Name"].ToString();
                        txt_PaletteQuantity.Text = dr["Prd_Qty"].ToString();
                        txt_Rating.Text = dr["Grade_Code"].ToString();

                        _Strings.Clear();
                    }

                }
            }
        }
        
        private void SetGood()
        {
            GoodHistory_Service service = new GoodHistory_Service();
            dataGridView1.DataSource= service.GetGoodHistory();
        }
    }
}
