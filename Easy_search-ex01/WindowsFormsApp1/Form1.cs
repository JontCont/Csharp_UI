using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Button1_Click_1(object sender, EventArgs e)
        {
            int start = 0;
            int last = richTextBox1.Text.LastIndexOf(textBox1.Text);
            string clrFont = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = clrFont;

            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;

            while (start < last)
            {
                richTextBox1.Find(textBox1.Text, start, richTextBox1.TextLength, RichTextBoxFinds.MatchCase);
                richTextBox1.SelectionBackColor = Color.Yellow;

                start = richTextBox1.Text.IndexOf(textBox1.Text, start) + 1;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
        //char KeyChar = e.KeyCode;

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();// 執行按鈕“1”的操作
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           char KeyChar = e.KeyChar;

            if (KeyChar.ToString() == "13")
            {
                button1.PerformClick();// 執行按鈕“1”的操作
                e.Handled = true;
            }
        }


    }
}
