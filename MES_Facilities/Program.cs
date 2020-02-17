using FieldOperationForm;
using MES_DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MES_Facilities
{
    public class Program
    {
        static List<WorkOrderCheckVo> processWorkList;
        static List<ItemVo> itemList;
        static string workOrderNo =string.Empty;
        static string workCenterNo = ConfigurationManager.AppSettings["Wc_Code"];
        static string processName = ConfigurationManager.AppSettings["Process_Name"];
        static int Balance =0;
        static System.Timers.Timer timer1;
        static bool isWorking = false;
        static bool isFull = false;
        static bool isFirst = true;
        static void Main(string[] args)
        {
            
            Console.WriteLine($"--- {workCenterNo} 작동---");
            SetLoad();
            while (true)
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
                            Console.WriteLine("------ 작업 시작 ------");
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
                        Console.WriteLine("------ 작업 마감 ------");
                    }
                }
            }
        }
        private static void SetLoad()
        {
            WorkOrderService service2 = new WorkOrderService();
            processWorkList = service2.GetPrcocess_Workorder(processName);
            ItemService service3 = new ItemService();
            itemList = service3.GetAllItemInfo();
        }
        async static Task AsyncEchoServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, Convert.ToInt32(ConfigurationManager.AppSettings["Port_Num"]));
            listener.Start();
            while (true)
            {
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }
        private static async void AsyncTcpProcess(object o)
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
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, nbytes));                    
                    await stream.WriteAsync(buffer, 0, nbytes).ConfigureAwait(false);
                }
            }
            stream.Close();
            tc.Close();
        }

        private static void SetTimer()
        {
            timer1 = new System.Timers.Timer(3000);
            timer1.Enabled = true;
            timer1.Elapsed += timer1_Elapse;
            timer1.AutoReset = true;
        }

        private static void timer1_Elapse(object sender, ElapsedEventArgs e)
        {
            string workWorderNo = workOrderNo;
            int UPHperSecond = (int)itemList.Find(x => x.Item_Code == processWorkList.Find(y=>y.Workorderno == workWorderNo).Item_Code).IronUPH / 60 / 20;
            Random rnd = new Random((int)DateTime.UtcNow.Ticks);
            int faultyQty = rnd.Next(0, 2);
            
            TcpClient tc = new TcpClient("127.0.0.2", 7000);
            NetworkStream stream = tc.GetStream();
            
            string msg;
            if (Balance-(UPHperSecond - faultyQty) > 0)
            {
                msg = $"{workWorderNo}/{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}/{workCenterNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}/{UPHperSecond - faultyQty}/{faultyQty}";
                Balance -= (UPHperSecond - faultyQty);
                Console.WriteLine($"잔여수량 : {Balance}, 생산수량 : {UPHperSecond - faultyQty}, 불량수량 : {faultyQty}");
            }
            else
            {
                msg = $"{workWorderNo}/{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}/{workCenterNo}/{processWorkList.Find(x => x.Workorderno == workWorderNo).Plan_Qty}/{Balance}/0";
                Console.WriteLine($"잔여수량 : {Balance}, 생산수량 : {Balance}, 불량수량 : {faultyQty}");
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
    }
}
