using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormColculator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        float first_no , secc_no;
        string option;
        public Form1()
        {
            InitializeComponent();
            TextBox1.Text = " ";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Mb01_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 1;
        }
        private void Mb02_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 2;
        }
        private void Mb03_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 3;
        }

        private void Mb04_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 4;
        }

        private void Mb05_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 5;
        }

        private void Mb06_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 6;
        }

        private void Mb07_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 7;
        }

        private void Mb08_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 8;
        }

        private void Mb09_Click(object sender, EventArgs e)
        {
                TextBox1.Text += 9;
        }

        private void Mb0_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != " ")
                TextBox1.Text += 0;
            else if(TextBox1.Text == " ")
                TextBox1.Text = " ";
        }

        private void MbC_Click(object sender, EventArgs e)
        {
            option = "";
            label1.Text = " ";
            TextBox1.Text = " ";
        }

        private void MbCE_Click(object sender, EventArgs e)
        {
            TextBox1.Text = " ";
            
        }

        private void Mblife_Click(object sender, EventArgs e)
        {
            int lenght = TextBox1.TextLength-1;
            string text = TextBox1.Text;
            TextBox1.Text =" ";
            for(int i = 0;i< lenght; i++)
            {
                TextBox1.Text = TextBox1.Text + text[i];
            }
           
        }

        private void MbAND_Click(object sender, EventArgs e)
        {
            secc_no = float.Parse(TextBox1.Text);

            float num;
            label1.Text = first_no.ToString() + option +secc_no.ToString()+"=";
            switch (option)
            {
                case "+":
                    num = first_no +secc_no ;
                    TextBox1.Text = num.ToString();
                    break;

                case "-":
                    num = first_no - secc_no;
                    TextBox1.Text = num.ToString();
                    break;

                case "*": 
                    num = first_no * secc_no;
                    TextBox1.Text = num.ToString();
                    break;

                case "/":
                    num = first_no / secc_no;
                    TextBox1.Text = num.ToString();
                    break;
            }
        }

        private void MbA_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text;
            first_no = float.Parse(TextBox1.Text);
            option = "+";
            label1.Text = first_no.ToString() + option;
            TextBox1.Text = " ";
        }

        private void MbN_Click(object sender, EventArgs e)
        {
            first_no = float.Parse(TextBox1.Text);
            TextBox1.Text = " ";
            option = "-";
            label1.Text =first_no.ToString()+option ;
        }

        private void MbS_Click(object sender, EventArgs e)
        {
            first_no = float.Parse(TextBox1.Text);
            TextBox1.Text = " ";
            option = "*";
            label1.Text = first_no.ToString() + option;
        }

        private void MbQ_Click(object sender, EventArgs e)
        {
            first_no = float.Parse(TextBox1.Text);
            TextBox1.Text = " ";
            option = "/";
            label1.Text = first_no.ToString() + option;
        }

        private void MbF_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == " ")
                TextBox1.Text += "0.";
            else if(!TextBox1.Text.Contains("."))
                TextBox1.Text += ".";
        }

        private void MbAN_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Contains("-"))
            {
                TextBox1.Text = TextBox1.Text.Remove(0,1);
            }
            else if(!TextBox1.Text.Contains("-"))
            {
                TextBox1.Text = "-" + TextBox1.Text;
            }
            
        }
    }
}
