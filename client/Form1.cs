using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using System.Net;
using System.Net.Sockets;

using System.Xml;

using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace client
{
    public partial class Form1 : Form
    {
        #region 界面设置
        private bool isExit = false;    //检测是否正常退出
        private bool VideoIsOn = false; //检测视频通话是否退出
        #endregion

        #region 业务通信
        private TcpClient client;
        private BinaryReader br;
        private BinaryWriter bw;
        BackgroundWorker connectWork = new BackgroundWorker();
        #endregion

        #region 图像帧通信
        private Socket ImageSocket;
        private IPEndPoint IpServer = null;
        private Thread ImageSendThread=null;
        private Thread ImageRecThread=null;
        private byte draw;
        #endregion

        #region 事件处理
        private Socket EventSocket;
        private IPEndPoint IpClient = null;
        private EndPoint ServerPoint;
        private EndPoint ClinetPoint;
        private Thread EventThread;
        private string InfoType=string.Empty;
        private string Message = string.Empty;
        private string Answer = string.Empty;

        #endregion
        #region 音频处理
        #endregion




        #region 设置参数
        private string userName = string.Empty;//用户名
        private string serverIP = string.Empty;
        private string CameraName = string.Empty;
        private string Micro = string.Empty;
        private string Port = string.Empty;
        private string Size = string.Empty;
        private string SavePath = string.Empty;
        #endregion

        #region 录像参数
        public string audiodev;//麦克风名字
        public string Command;//录像指令
        public string Savepath;//录像保存路径
        Process p = new Process();//截屏进程
        Thread FullScreenVideo;//全屏录像线程
        #endregion


      
        public Form1()
        {
            InitializeComponent();

            StopToolStripMenuItem.Enabled = false;

            if(File.Exists("setting.xml"))
            {
                LoadSetting();
            }
            panel_video.Visible = false;
            this.Width = 659;
            
        }
  
        /// <summary>
        /// 读取设置参数
        /// </summary>
        private void LoadSetting()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("setting.xml");
                XmlNode xn = xmlDoc.SelectSingleNode("item");
                XmlNodeList xnl = xn.ChildNodes;

                XmlNode xn0 = xnl[0];
                XmlNode xn1 = xnl[1];
                XmlNode xn2 = xnl[2];
                XmlNode xn3 = xnl[3];
                XmlNode xn4 = xnl[4];
                XmlNode xn5 = xnl[4];
                XmlNode xn6 = xnl[4];
                userName = xn0.InnerText;
                serverIP = xn1.InnerText;
                Port = xn2.InnerText;
                CameraName = xn3.InnerText;
                Micro = xn4.InnerText;
                Size = xn3.InnerText;
                SavePath = xn4.InnerText;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// 运行摄像头
        /// </summary>
        private void RunCamera()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(CameraName);
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();

        }
        /// <summary>
        /// 停止摄像头
        /// </summary>
        private void StopCamera()
        {
            ImageSendThread.Abort();
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            ImageRecThread.Abort();
        }
        private void stop_Click(object sender, EventArgs e)
        {
           
     
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_Click_1(object sender,EventArgs e)
        {
            DateTime time = DateTime.Now;
            String InputInfo = string.Empty;
            InputInfo = time + "\r\n" + rtf_SendMessage.Text + "\r\n";
            rtf_MessageInfo.AppendText(InputInfo);

            SendMessage(InputInfo,ServerPoint);
        }
        private void SendMessage(string info, EndPoint Point)
        {
            JObject json = new JObject();
            json.Add("InfoType", "message");
            json.Add("Message", info);
            EventSocket.SendTo(Encoding.UTF8.GetBytes(json.ToString()), Point);
        }
        /// <summary>
        /// 呼出设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_set_Click(object sender, EventArgs e)
        {
            SettingForm settingform = new SettingForm();
            settingform.ShowDialog();
        }
        private FilterInfoCollection videoDevices;//摄像头设备
        private void loadCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                CameraName = device.MonikerString;
            }
        }
        /// <summary>
        /// 开始视频通话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_videoChat_Click(object sender, EventArgs e)
        {
        
        }
        /// <summary>
        /// 停止视频通话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            fuction(image);
        }
        /// <summary>
        /// 运行ffmpeg.exe
        /// </summary>
        /// <param name="ob"></param>
        public void RunFFMpeg(object ob)
        {
            p.StartInfo.FileName = "ffmpeg.exe"; //程序名
            p.StartInfo.Arguments = ob.ToString(); //执行参数
            //p.StartInfo.CreateNoWindow = false;
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();

        }

        private void toolStripButton1_video_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_stop_Click(object sender, EventArgs e)
        {
            Process[] localByName = Process.GetProcessesByName("ffmpeg");
            if (localByName.Length > 0)
            {
                try
                {
                    Stop();
                    for (int i = 0; i < localByName.Length; i++)
                    {
                        Process p = Process.GetProcessById(localByName[i].Id);
                        if (p != null)
                            p.Kill();
                    }

                    FullScreenVideo.Abort();
                }

                catch { }

            }
        }
        #region 模拟控制台信号需要使用的api

        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        #endregion
        /// <summary>
        /// 功能: 停止录制
        /// </summary>
        public void Stop()
        {
            AttachConsole(p.Id);
            SetConsoleCtrlHandler(IntPtr.Zero, true);
            GenerateConsoleCtrlEvent(0, 0);
            FreeConsole();
        }
        #region 事件处理
        private void SetEventUDP()
        {
            ClinetPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1001);
            EventSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EventSocket.Bind(ClinetPoint);

            IpServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            ServerPoint = (EndPoint)IpServer;
            JObject json = new JObject();
            json.Add("InfoType", "parameter");
            json.Add("IpClient", GetLocalIP());
            json.Add("UserName", userName);
            EventSocket.SendTo(Encoding.UTF8.GetBytes(json.ToString()), ServerPoint);


            EventThread = new Thread(Accepting);
            EventThread.IsBackground = true;
            EventThread.Start();
        }
        private void Accepting()
        {

            while (true)
            {
                EndPoint point = new IPEndPoint(IPAddress.Any, 0);
                byte[] RecvByte = new byte[256];
                EventSocket.Blocking = true;
                EventSocket.ReceiveFrom(RecvByte, ref point);


                JObject json = JObject.Parse(Encoding.UTF8.GetString(RecvByte));
                InfoType=json.SelectToken("InfoType").ToString();               
                if (InfoType == "parameter")
                {
                    Answer = json.SelectToken("Answer").ToString();
                    if (Answer == "yes")
                    {
                        MessageBox.Show("连接成功！");
                        SetImageTCP();
                    }
                    else
                    {
                        MessageBox.Show("服务器拒绝了您的连接，请稍后重连！");
                        EventSocket.Close();
                        EventThread.Abort();
                    }
                }
                else
                {
                    Message = json.SelectToken("Message").ToString();
                    // MessageBox.Show(Message);
                    ShowInformation(Message);
                }
            }
        }
        /// <summary>
        /// 显示文字
        /// </summary>
        /// <param name="info"></param>
        private void ShowInformation(string info)
        {
            Thread ShowText = new Thread(new ParameterizedThreadStart(Updatertf_MessageInfo));
            ShowText.Start(info);
        }
        private void Updatertf_MessageInfo(object str)
        {
            if (rtf_MessageInfo.InvokeRequired)
            {
                Action<string> actionDelegate = (x) => { this.rtf_MessageInfo.AppendText( x.ToString()); };
                this.rtf_MessageInfo.Invoke(actionDelegate, str);
            }
            else
            {
                this.rtf_MessageInfo.AppendText(str.ToString());
            }
        }
        #endregion
        #region 图片传输
        private void SetImageTCP()
        {
            IpServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1111);
            ImageSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ImageSocket.Connect(IpServer);
            ImageSocket.Send(Encoding.ASCII.GetBytes("hello"));
        }
        private string GetLocalIP()
        {
            string ipaddress = string.Empty;

            IPHostEntry myEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress Ip in myEntry.AddressList)
            {
                if (Ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipaddress = Ip.ToString();
                }
            }
            return ipaddress;

        }
        private void fuction(Bitmap bitmap)
        {
            byte[] data;
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Jpeg);
            data = new byte[ms.Length + 1];
            ms.Position = 0;
            data[0] = draw;
            ms.Read(data, 1, data.Length - 1);//读取数据流
            Send(data);//发送流
        }
        public void Send(byte[] data)//发送函数
        {
            int i, l;
            byte[] value, temp = data;
            l = temp.Length;
            value = new byte[l + 4];
            for (i = 0; i < l; i++)
                value[i + 4] = (byte)((temp[i] + i) % 256);
            for (i = 3; i >= 0; i--)
            {
                value[i] = (byte)(l % 256);
                l /= 256;
            }
            ImageSocket.Send(value);

        }
        private byte[] Receive()//接收函数
        {
            byte[] data = new byte[4];
            int i, size = 0;
            for (i = ImageSocket.Receive(data); i < 4; i = i + ImageSocket.Receive(data, i, 4 - i, SocketFlags.None)) Thread.Sleep(10);//获取四字节头
            for (i = 0; i < 4; i++) size = size * 256 + data[i];//计算分组大小
            data = new byte[size];
            for (i = 0; i < size; i = i + ImageSocket.Receive(data, i, size - i, SocketFlags.None)) Thread.Sleep(10);//读取流
            for (i = 0; i < size; i++) data[i] = (byte)((data[i] - i) % 256);//解密
            return data;
        }
        /// <summary>
        /// 接收图片帧
        /// </summary>
        private void getimg()
        {
            try
            {
                byte[] data;
                MemoryStream stream;
                while (true)
                {
                    data = Receive();
                    if (data.Length > 0 && data[0] == draw)
                    {
                        stream = new MemoryStream(data, 1, data.Length - 1);//还原图像的编码流                 
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString());
            }
        }
        #endregion


        private void start_Click(object sender, EventArgs e)
        {
            
        }

        private void 开始通话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCamera();

            //ImageSocket.Send(Encoding.UTF8.GetBytes("Start Camera"));

            this.Width = 1024;
            panel_video.Visible = true;
            VideoIsOn = false;
            ImageSendThread = new Thread(RunCamera);
            ImageSendThread.Start();

            ImageRecThread = new Thread(getimg);
            ImageRecThread.Start();
        }

        private void 结束通话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImageSocket.Send(Encoding.UTF8.GetBytes("Start Camera"));
            this.Width = 671;
            panel_video.Visible = false;
            MessageBox.Show("视频通话结束！");
            VideoIsOn = false;
            StopCamera();
        }

        private void 开始录象ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void 停止录像ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEventUDP();

        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
