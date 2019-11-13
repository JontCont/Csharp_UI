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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
            font_pwd.MaxLength = 12;
        }

        Signup formsignup = new Signup();
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
        }//wndproc 

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Closer_Form_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Font_pwd_TextChanged(object sender, EventArgs e){ }//Font_pwd

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            formsignup.Show();
            
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-G659TMJ;Initial Catalog=example;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into regitdata(name) values('"+textBox1.Text+"') ",con);
            
            int i = cmd.ExecuteNonQuery();
            if (i != 0) {
                MessageBox.Show("data  saved");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
