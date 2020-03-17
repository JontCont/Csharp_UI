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
    }
}
