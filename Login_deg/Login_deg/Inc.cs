using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_deg
{
    public partial class Inc : Form
    {
        SqlConnection objCont;
        //SqlCommand objCmd;
        SqlDataAdapter sda;
       
        String strSQL;
        public Inc()
        {
            InitializeComponent();
        }

        private void Close_bu_Click(object sender, EventArgs e)
        {
            Form_Login M_Log = new Form_Login();
            this.Close();
        }

        private void Usrname_bun_TextChanged(object sender, EventArgs e){}
        private void Inc_Load(object sender, EventArgs e){}
        private void Paw_bun_TextChanged_Leave (object sender, EventArgs e) { }
        private void Login_btu_Click(object sender, EventArgs e)
        {
            strSQL = "select * from account where username='"+ usrname_bun.Text + "'and password ='"+ paw_bun.Text + "'";
  
            objCont = new SqlConnection(@"Data Source=JCONT-RD;Initial Catalog=statement;Persist Security Info=True;User ID=tes;Password=123");
            objCont.Open();

            sda = new SqlDataAdapter(strSQL, objCont);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                if (dt.Rows.Count == 1)
                    MessageBox.Show("welcome", "Messge",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("your username or password is incorrect","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Messge",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            objCont.Close();
        }
        private void Return_btu_Click(object sender, EventArgs e)
        {
            Form_Login M_Log = new Form_Login();
            M_Log.Show();
            this.Close();
        }

        private void usrname_bun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Login_btu.PerformClick();
        }

        private void paw_bun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Login_btu.PerformClick();
        }
    }
}
