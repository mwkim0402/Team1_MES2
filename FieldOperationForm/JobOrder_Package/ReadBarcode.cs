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
    public partial class ReadBarcode : Form
    {
        bool TagMove;
        int MValX, MValY;
        public ReadBarcode()
        {
            InitializeComponent();
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
                    _Port.PortName = "COM4";
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
                textBox1.Text = str;
            }
        }
    
        private void SerialPortonnecting()
        {
            if (!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결.
                Port.PortName = "COM4";
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

        private void Form4_Deactivate(object sender, EventArgs e)
        {
            Port.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                //if (textBox1.Text.IndexOf('/') > 0)
                //{
                string barID = textBox1.Text.Split('/')[0];
                textBox1.Text = barID;//00094
                button1.PerformClick();

                //}
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //94에 해당하는 출고정보 조회해서 라벨에도 보여주고,
            //출고확인 메세지 처리
            //DB에서 재고를 떨구는 작업 하시고
            //버퍼를 비워준다.
            if (textBox1.Text.Length > 0)
            {
                string barID = textBox1.Text;


                string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
                DataSet ds = new DataSet();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = String.Format(@"select Workorderno,Pallet_No,Print_Date,Grade_Code,Grade_Detail_Code,Size_Code,Prd_Qty from 
 Goods_In_History where Barcode_No= '{0}' ", textBox1.Text);


                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(ds, "Goods_In_History");
                    conn.Close();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        label1.Text = dr["Workorderno"].ToString();
                        label2.Text = dr["Pallet_No"].ToString();
                        label3.Text = dr["Print_Date"].ToString();
                        label4.Text = dr["Grade_Code"].ToString();
                        label5.Text = dr["Grade_Detail_Code"].ToString();
                        label6.Text = dr["Size_Code"].ToString();
                        label7.Text = dr["Prd_Qty"].ToString();

                        // textBox1.Text = "";
                        _Strings.Clear();
                    }


                }

            }
        }

        private void ReadBarcode_Load(object sender, EventArgs e)
        {
            SerialPortonnecting();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadBarcode_FormClosing(object sender, FormClosingEventArgs e)
        {
            Port.Close();
        }

        private void ReadBarcode_Deactivate(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}