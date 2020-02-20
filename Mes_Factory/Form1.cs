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
        WorkOrderService service = new WorkOrderService();
        WorkCenterService wcService = new WorkCenterService();
        List<WorkOrderCheckVo> processWorkList;
        List<ItemVo> itemList;
        string workOrderNo = string.Empty;
        string workCenterNo = ConfigurationManager.AppSettings["Wc_Code"];
        string processName = ConfigurationManager.AppSettings["Process_Name"];
        int Balance = 0;
        System.Timers.Timer timer1;
        System.Timers.Timer mainTimer;
        bool isWorking = false;
        bool isFull = false;
        bool isFirst = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine($"--- {workCenterNo} 작동---");
            SetLoad();
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
            int randomProd = rnd.Next(0, 10);
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
            }
            else
            {
                msg = $"{workWorderNo}/{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}/{workCenterNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}/{Balance}/0";
                //Console.WriteLine($"잔여수량 : 0, 생산수량 : {Balance}, 불량수량 : {faultyQty}");
                setText_ListBox(listBox1, $"잔여수량 : 0, 생산수량 : {Balance}, 불량수량 : {faultyQty}");
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
                AsyncEchoServer();
            }
            else
            {
                if (!isFull)
                {
                    if (isFirst)
                    {
                        setText_ListBox(listBox1, " ");
                        setText_ListBox(listBox1, "------ 작업 시작 ------");
                        service.UpdateWorkStatus(workOrderNo, "작업중");
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
                    setText_ListBox(listBox1, "------ 작업 종료 ------");
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("hh-MM-ss");
        }
    }
}

