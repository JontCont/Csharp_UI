using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SigninForms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        //Signin forms1 = new Signin();
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x01;
            const int HTCAPTION = 0x02;
            if (m.Msg == WM_NCHITTEST)
            {
                this.DefWndProc(ref m);
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = new IntPtr(HTCAPTION);
                else
                    base.WndProc(ref m);
            }
            else
            {
                base.WndProc(ref m);
            }
        }



        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        

        if (textBox2.Text == "" || textBox3.Text == "") 
            ErrorPwd.Text = "密碼不能空白";
            else if (checkBox1.Checked ==true )
            {
              SqlConnection con = new SqlConnection("Data Source=DESKTOP-G659TMJ;Initial Catalog=example;Integrated Security=True");
              con.Open();
              SqlCommand cmd = new SqlCommand("insert into regitdata(name,email" + ",password) values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "') ", con);
              int i  = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("data  saved");
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();
            }
        else
                Error1.Text = "沒有勾選";
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
