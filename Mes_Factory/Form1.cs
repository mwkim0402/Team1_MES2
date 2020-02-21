using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Mes_Factory
{
    public partial class Form1 : Form
    {
        delegate void List_Invoke(ListBox invokeList, string txtValue);
        delegate void Text_Invoke(TextBox textList, string txtValue);
        delegate void Label_Invoke(Label textList, string txtValue);
        delegate void Bar_Invoke(ProgressBar textList, int Value);
        WorkOrderService service = new WorkOrderService();
        WorkCenterService wcService = new WorkCenterService();
        List<WorkOrderCheckVo> processWorkList;
        List<ItemVo> itemList;
        List<WorkOrder> wcList = new List<WorkOrder>();
        string workOrderNo = string.Empty;
        string workCenterNo = ConfigurationManager.AppSettings["Wc_Code"];
        string processName = ConfigurationManager.AppSettings["Process_Name"];
        int Balance = 0;
        int PrdQty = 0;
        System.Timers.Timer timer1;
        System.Timers.Timer mainTimer;
        bool isWorking = false;
        bool isFull = false;
        bool isFirst = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void initControl()
        {
            lblBadQty.Text = "0";
            lblInQty.Text = "0";
            lblBadQty.Text = "0";
            listBox1.Items.Clear();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBadQty.Text = "0";
            lblInQty.Text = "0";
            lblBadQty.Text = "0";
            label9.Text = DateTime.Now.ToString("tt hh:mm:ss");
            //Console.WriteLine($"--- {workCenterNo} 작동---");
            SetLoad();
           // label5.Text = workCenterNo;
            label10.Text = processName+ " -";
           //AsyncEchoServer();
            mainTimer = new System.Timers.Timer(1000);
            mainTimer.Enabled = true;
            mainTimer.Elapsed += mainTimer_Elapse;
            mainTimer.AutoReset = true;
        }

        private void SetLoad()
        {
            WorkOrderService service2 = new WorkOrderService();
            processWorkList = service2.GetPrcocess_Workorder(processName);
            ItemService service3 = new ItemService();
            itemList = service3.GetAllItemInfo();
            WorkCenterService workService = new WorkCenterService();
            label5.Text = workService.GetAllWorkCenter().Find(x => x.Wc_Code == workCenterNo).Wc_Name;
        }


        private void SetTimer()
        {
            timer1 = new System.Timers.Timer(3000);
            timer1.Enabled = true;
            timer1.Elapsed += timer1_Elapse;
            timer1.AutoReset = true;
        }

        private void timer1_Elapse(object sender, ElapsedEventArgs e)
        {
            string workWorderNo = workOrderNo;
            int UPHperSecond = (int)itemList.Find(x => x.Item_Code == processWorkList.Find(y => y.Workorderno == workWorderNo).Item_Code).IronUPH / 60 / 20;
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            int faultyQty = rnd.Next(0, 3);
            int randomProd = rnd.Next(0, 5);
            int randSum = rnd.Next(0, 2);
            TcpClient tc = new TcpClient("127.0.0.2", 7000);
            NetworkStream stream = tc.GetStream();

            if (randSum == 0)
            {
                UPHperSecond += randomProd;
            }
            else
            {
                if (UPHperSecond > randomProd)
                {
                    UPHperSecond -= randomProd;
                }
            }
            string msg;
            if (Balance - (UPHperSecond - faultyQty) > 0)
            {
                msg = $"{workWorderNo}/{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}/{workCenterNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}/{UPHperSecond - faultyQty}/{faultyQty}";
                Balance -= (UPHperSecond - faultyQty);
                // Console.WriteLine($"잔여수량 : {Balance}, 생산수량 : {UPHperSecond - faultyQty}, 불량수량 : {faultyQty}");
                setText_ListBox(listBox1, $"잔여수량 : {Balance}, 생산수량 : {UPHperSecond - faultyQty}, 불량수량 : {faultyQty}");
                setText_Label(lblInQty, (int.Parse(lblInQty.Text) + UPHperSecond).ToString());
                setText_Label(lblPrdQty, (int.Parse(lblPrdQty.Text) + UPHperSecond - faultyQty).ToString());
                setText_Label(lblBadQty, (int.Parse(lblBadQty.Text) + faultyQty).ToString());
                setText_Label(label4, String.Format("{0:0.##}", (double.Parse(lblPrdQty.Text) / PrdQty)*100));
               // setText_ProgressBar(progressBar1,(int.Parse(lblPrdQty.Text) / PrdQty)*100);
            }
            else
            {
                msg = $"{workWorderNo}/{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}/{workCenterNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}/{Balance}/0";
                //Console.WriteLine($"잔여수량 : 0, 생산수량 : {Balance}, 불량수량 : {faultyQty}");
                setText_ListBox(listBox1, $"잔여수량 : 0, 생산수량 : {Balance}, 불량수량 : {faultyQty}");
                setText_Label(lblInQty, (int.Parse(lblInQty.Text) + Balance + faultyQty).ToString());
                setText_Label(lblPrdQty, (int.Parse(lblPrdQty.Text) + Balance).ToString());
                setText_Label(lblBadQty, (int.Parse(lblBadQty.Text) + faultyQty).ToString());
                setText_Label(label4, String.Format("{0:0.##}", (double.Parse(lblPrdQty.Text) / PrdQty)*100));
               // setText_ProgressBar(progressBar1, (int.Parse(lblPrdQty.Text) / PrdQty)*100);
                Balance = 0;
                isFull = true;
            }

            byte[] buff = Encoding.UTF8.GetBytes(msg);
            stream.Write(buff, 0, buff.Length);
            byte[] outBuff = new byte[1024];
            int nbytes = stream.Read(outBuff, 0, outBuff.Length);
            string outMsg = Encoding.UTF8.GetString(outBuff, 0, nbytes);
            stream.Close();
            tc.Close();
        }

        public void setText_ListBox(ListBox list, string txtValue)
        {
            if (list.InvokeRequired)
            {
                List_Invoke listInvoke = new List_Invoke(setText_ListBox);
                list.Invoke(listInvoke, list, txtValue);
            }
            else
            {
                list.Items.Add(txtValue);
                list.TopIndex = list.Items.Count - 1;
            }
        }
        public void setText_ProgressBar(ProgressBar list, int txtValue)
        {
            if (list.InvokeRequired)
            {
                Bar_Invoke listInvoke = new Bar_Invoke(setText_ProgressBar);
                list.Invoke(listInvoke, list, txtValue);
            }
            else
            {
                list.Value = txtValue;
            }
        }
        public void setText_Label(Label list, string txtValue)
        {
            if (list.InvokeRequired)
            {
                Label_Invoke listInvoke = new Label_Invoke(setText_Label);
                list.Invoke(listInvoke, list, txtValue);
            }
            else
            {
                list.Text = txtValue;
            }
        }

        public void setText_TextBox(TextBox list, string txtValue)
            {
                if (list.InvokeRequired)
                {
                    Text_Invoke listInvoke = new Text_Invoke(setText_TextBox);
                    list.Invoke(listInvoke, list, txtValue);
                }
                else
                {
                    list.Text = txtValue;
                }
            }

            async Task AsyncEchoServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, Convert.ToInt32(ConfigurationManager.AppSettings["Port_Num"]));
            listener.Start();
            while (true)
            {
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }

        private async void AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            NetworkStream stream = tc.GetStream();
            byte[] buffer = new byte[1024];
            var readTask = stream.ReadAsync(buffer, 0, buffer.Length);
            //10초간 기다리는 쓰레드 풀
            var timeoutTask = Task.Delay(10000);
            var doneTask = await Task.WhenAny(timeoutTask, readTask);
            if (doneTask == timeoutTask)
            {
                byte[] bytes = Encoding.UTF8.GetBytes("Read Timeout");
                //Program.Log.WriteError("Read Timeout");
                await stream.WriteAsync(bytes, 0, bytes.Length);
            }
            else
            {
                int nbytes = readTask.Result;
                if (nbytes > 0)
                {
                    string[] arrData = Encoding.UTF8.GetString(buffer, 0, nbytes).Split('/');
                    if (arrData.Length == 3)
                    {
                        // 0번째 작업지시 번호, 1번째 작업장코드, 2번째 계획량
                        workOrderNo = arrData[0].ToString();                        
                        Balance = Convert.ToInt32(arrData[2]);
                        PrdQty = Balance;
                        setText_TextBox(textBox3, arrData[2]);
                        setText_TextBox(textBox2, itemList.Find(x => x.Item_Code == processWorkList.Find(y => y.Workorderno == workOrderNo).Item_Code).Item_Name);
                        setText_TextBox(textBox4, DateTime.Now.ToString("tt hh:mm:ss"));
                        isWorking = true;
                        //Console.WriteLine($"{workOrderNo}/{planQty}");
                    }
                    setText_ListBox(listBox1, Encoding.UTF8.GetString(buffer, 0, nbytes));
                    //Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, nbytes));
                    await stream.WriteAsync(buffer, 0, nbytes).ConfigureAwait(false);
                }
            }
            stream.Close();
            tc.Close();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void mainTimer_Elapse(object sender, ElapsedEventArgs e)
        {
            if (!isWorking)
            {
                //initControl();
                setText_Label(label4, "0");
                setText_ProgressBar(progressBar1, 0);
                setText_Label(lblBadQty, "0");
                setText_Label(lblPrdQty, "0");
                setText_Label(lblInQty, "0");
                setText_TextBox(textBox1, "");
                setText_TextBox(textBox2, "");
                setText_TextBox(textBox3, "");
                setText_TextBox(textBox4, "");
                AsyncEchoServer();
            }
            else
            {
                if (!isFull)
                {
                    if (isFirst)
                    {
                        setText_ListBox(listBox1, "--------------작업시작---------------");
                        service.UpdateWorkStatus(workOrderNo, "작업중");
                        setText_TextBox(textBox1, workOrderNo);
                        wcService.WcStatusUpdate(ConfigurationManager.AppSettings["Wc_Code"], "RUN");
                        SetTimer();
                        isFirst = false;
                    }
                }
                else
                {
                    timer1.Stop();
                    timer1.Dispose();
                    isFull = false;
                    isWorking = false;
                    isFirst = true;
                    service.UpdateWorkStatus(workOrderNo, "작업종료");
                    wcService.WcStatusUpdate(ConfigurationManager.AppSettings["Wc_Code"], "STOP");
                    setText_ListBox(listBox1, "--------------생산완료---------------");
                    setText_ListBox(listBox1, $"총 투입 개수 : {lblInQty.Text}/ 양품 개수 : {lblPrdQty.Text}/ 불량 개수 : {lblBadQty.Text}");
                    setText_ListBox(listBox1, "--------------작업종료---------------");
                    setText_ListBox(listBox1, " ");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((int)(double.Parse(label4.Text)) == 100)
            {
                progressBar1.Value = 99;
            }
            else
            {
                progressBar1.Value = (int)(double.Parse(label4.Text));
            }
            timer3.Stop();
        }

        private void lblInQty_Click(object sender, EventArgs e)
        {

        }

        private void lblPrdQty_Click(object sender, EventArgs e)
        {

        }
    }
}

