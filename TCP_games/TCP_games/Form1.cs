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
        //ShapeContainer CVS;
        //byte[,] S;//對應棋盤狀態的陣列：0為空格，1為黑子，2為白子
        //公用變數
        Socket T;//通訊物件
        Thread Th;//網路監聽執行緒
        string User;//使用者

        //------------------Sub------------------------//
        //送出訊息給server
        private void Send(string Str)
        {
            try { 
                byte[] B = Encoding.Default.GetBytes(Str); //翻譯文字成Byte陣列
                T.Send(B, 0, B.Length, SocketFlags.None); //傳送訊息給伺服器
            } 
            catch { }
            
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
                    MessageBox.Show("伺服器斷線了！","注意", MessageBoxButtons.OK, MessageBoxIcon.Information);//顯示斷線
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
                    //接收廣播訊息
                    case "1":
                        TextBox5.AppendText("(公開)" + Str + "\r\n");
                        break;
                    case "2":
                        if (Str == "123")
                        {
                            TextBox7.AppendText(User + ": Hit"  + "\r\n");//顯示訊息並換行
                            TextBox8.ReadOnly=true;
                            metroButton2.Enabled = false;
                        }
                        else
                        {
                            TextBox7.AppendText(User + ":" + Str + "\r\n");//顯示訊息並換行
                        }
                        break;
                    case "3"://接收私密訊息
                        TextBox5.AppendText("(私密)" + Str + "\r\n");//顯示訊息並換行游標移到最後
                        break;
                    case "5":
                        PointShape(Str);
                        break;  
                }
            }
        }
        //---------------------------------------------//
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new ShapeContainer();//建立畫布(本機繪圖用)
            metroPanel2.Controls.Add(C);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒操作的錯誤
            User = textBox3.Text;  //使用者名稱
            string IP = textBox1.Text;//伺服器IP
            int Port = int.Parse(textBox2.Text);  //伺服器Port
            try
            {
                //button1.Enabled = false; //讓連線按鍵失效，避免重複連線
                if (button1.Text.Equals("Sign in"))
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
                    button1.Text = "Sign out";
                }
                else if(button1.Text.Equals("Sign out")) 
                {
                    Send("9" + User);
                    T.Close(); //關閉網路通訊器
                    button1.Text = "Sign in";
                }
            }
            catch
            {
                textBox4.Text = "無法連上伺服器！" + "\r\n";  //連線失敗時顯示訊息
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Send("9" + User); //傳送自己的離線訊息給伺服器
                T.Close(); //關閉網路通訊器  
            }
            catch { }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "") return; //未輸入訊息不傳送資料
            if (listBox1.SelectedIndex < 0)//未選取傳送對象(廣播)，命令碼：1
            {
                Send("1" + User + "：" + TextBox6.Text);
            }
            else//有選取傳送對象(私密訊息)，命令碼：2
            {
                Send("3" + "來自" + User + ": " + TextBox6.Text + "|" + listBox1.SelectedItem);
                TextBox5.Text += "私密" + listBox1.SelectedItem + "： " + TextBox6.Text + "\r\n";
            }
            TextBox6.Text = ""; //清除發言框
        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (TextBox6.Text == "") return; //未輸入訊息不傳送資料
                if (listBox1.SelectedIndex < 0)//未選取傳送對象(廣播)，命令碼：1
                {
                    Send("1" + User + "：" + TextBox6.Text);
                }
                else//有選取傳送對象(私密訊息)，命令碼：2
                {
                    Send("3" + "來自" + User + ": " + TextBox6.Text + "|" + listBox1.SelectedItem);
                    TextBox5.Text += "告訴" + listBox1.SelectedItem + "： " + TextBox6.Text + "\r\n";
                }
                TextBox6.Text = ""; //清除發言框
                e.SuppressKeyPress = true; //SuppressKeyPress和Hanld都可以设置
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text == "") return; //未輸入訊息不傳送資料
            if (listBox1.SelectedIndex < 0)//未選取傳送對象(廣播)，命令碼：1
            {
                Send("2" + TextBox8.Text);
            }
            else
            {
                TextBox8.Enabled = false;
            }
            TextBox8.Text = ""; //清除發言框
        }

        private void TextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBox8.Text == "") return; //未輸入訊息不傳送資料
                if (listBox1.SelectedIndex < 0)//未選取傳送對象(廣播)，命令碼：1
                {
                    Send("2" + TextBox8.Text);
                }
                else//有選取傳送對象(私密訊息)，命令碼：2
                {
                    TextBox8.Enabled = false;
                }
                TextBox8.Text = ""; //清除發言框
                e.SuppressKeyPress = true; //SuppressKeyPress和Hanld都可以设置
            }
        }
        //------------------VB power pack-----------------------------//
        //繪圖相關變數宣告
        ShapeContainer C;//畫布物件(本機繪圖用)
        Point stP;//繪圖起點
        string p;//筆畫座標字串
        //本機端繪圖中
        private void metroPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                LineShape Line = new LineShape();//建立線段物件
                Line.StartPoint = stP;//線段起點
                Line.EndPoint = e.Location;//線段終點
                if (RadioButton1.Checked) { Line.BorderColor = Color.Red; }//紅筆
                if (RadioButton2.Checked) { Line.BorderColor = Color.Lime; }//亮綠色筆
                if (RadioButton3.Checked) { Line.BorderColor = Color.Blue; }//藍筆
                if (RadioButton4.Checked) { Line.BorderColor = Color.Black; }//黑筆
                Line.Parent = C;//線段加入畫布C
                stP = e.Location;//終點變起點
                p += "/" + stP.X.ToString() + "," + stP.Y.ToString();//持續紀錄座標
            }
        }
        //送出繪圖動作
        private void metroPanel2_MouseUp(object sender, MouseEventArgs e)
        {
                if (RadioButton1.Checked) { p = "1_" + p; }//紅筆
                if (RadioButton2.Checked) { p = "2_" + p; }//綠色筆
                if (RadioButton3.Checked) { p = "3_" + p; }//藍筆
                if (RadioButton4.Checked) { p = "4_" + p; }//黑筆
                Send("5"+p);   
        }
        //本機端開始繪圖
        private void metroPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            stP = e.Location;//起點
            p = stP.X.ToString() + "," + stP.Y.ToString();//起點座標紀錄
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C.Shapes.Clear();
        }
        private void PointShape(string  str) 
        {
            while (true)
            {
                string[] Z = str.Split('_');
                string[] Q = Z[1].Split('/');//切割座標點資訊
                Point[] R = new Point[Q.Length];//宣告座標點陣列
                for (int i = 0; i < Q.Length; i++)
                {
                    string[] K = Q[i].Split(',');//切割X與Y座標
                    R[i].X = int.Parse(K[0]);//定義第i點X座標
                    R[i].Y = int.Parse(K[1]);//定義第i點Y座標
                }
                    LineShape Line = new LineShape();//建立線段物件
                    Line.Parent = C;//線段L加入畫布D(遠端使用者繪圖)
                
            }
   
        }
    }
}
