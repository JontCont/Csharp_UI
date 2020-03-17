using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;//匯入網路通訊協定相關函數
using System.Net.Sockets;//匯入網路插座功能函數
using System.Threading;//匯入多執行緒功能函數
using Microsoft.VisualBasic.PowerPacks;

namespace TCP_games
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //------------------------------------------//
        ShapeContainer CVS;
        byte[,] S;//對應棋盤狀態的陣列：0為空格，1為黑子，2為白子
                  //公用變數
        Socket T;//通訊物件
        Thread Th;//網路監聽執行緒
        string User;//使用者

        //------------------------------------------//
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bg = new Bitmap(570, 570); //棋盤影像物件
            Graphics g = Graphics.FromImage(bg); //棋盤影像繪圖物件
            g.Clear(Color.White); //設白色為背景色
            for (int i = 15; i <= 555; i += 30)
            { g.DrawLine(Pens.Black, i, 15, i, 555); } //畫19條垂直線
            for (int j = 15; j <= 555; j += 30)
            { g.DrawLine(Pens.Black, 15, j, 555, j); } //畫19條垂直線
            panel2.BackgroundImage = bg; //貼上棋盤影像為Panel1的背景
            CVS = new ShapeContainer(); //宣告畫布物件
            panel2.Controls.Add(CVS); //畫布物件加入Panel1
            S = new byte[19, 19];//宣告棋盤資訊陣列
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒操作的錯誤
            User = textBox3.Text;  //使用者名稱
            string IP = textBox1.Text;//伺服器IP
            int Port = int.Parse(textBox2.Text);  //伺服器Port
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);//建立伺服器端點資訊
                //建立TCP通訊物件
                T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                T.Connect(EP); //連上Server的EP端點(類似撥號連線)
                Th = new Thread(Listen); //建立監聽執行緒
                Th.IsBackground = true; //設定為背景執行緒
                Th.Start(); //開始監聽
                textBox4.Text = "已連線伺服器！" + "\r\n";
                Send("0" + User); //隨即傳送自己的 UserName 給 Server
                button1.Enabled = false; //讓連線按鍵失效，避免重複連線
            }
            catch
            {
                textBox4.Text = "無法連上伺服器！" + "\r\n";  //連線失敗時顯示訊息
            }
        }
        //送出訊息
        private void Send(string Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str); //翻譯文字成Byte陣列
            T.Send(B, 0, B.Length, SocketFlags.None); //傳送訊息給伺服器
        }

        //監聽 Server 訊息 (Listening to the Server)
        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint; //Server 的 EndPoint
            byte[] B = new byte[1023]; //接收用的 Byte 陣列
            int inLen = 0; //接收的位元組數目
            string Msg; //接收到的完整訊息
            string St; //命令碼
            string Str; //訊息內容(不含命令碼)
            while (true)//無限次監聽迴圈
            {
                try
                {
                    inLen = T.ReceiveFrom(B, ref ServerEP);//收聽資訊並取得位元組數
                }
                catch (Exception)
                {
                    T.Close();//關閉通訊器
                    listBox1.Items.Clear();//清除線上名單
                    MessageBox.Show("伺服器斷線了！");//顯示斷線
                    button1.Enabled = true;//連線按鍵恢復可用
                    Th.Abort();//刪除執行緒
                }
                Msg = Encoding.Default.GetString(B, 0, inLen); //解讀完整訊息
                St = Msg.Substring(0, 1); //取出命令碼 (第一個字)
                Str = Msg.Substring(1); //取出命令碼之後的訊息   
                switch (St)//依命令碼執行功能
                {
                    case "L"://接收線上名單
                        listBox1.Items.Clear(); //清除名單
                        string[] M = Str.Split(','); //拆解名單成陣列
                        for (int i = 0; i < M.Length; i++)
                        {
                            listBox1.Items.Add(M[i]); //逐一加入名單
                        }
                        break;
                }
            }
        }
    }
}
