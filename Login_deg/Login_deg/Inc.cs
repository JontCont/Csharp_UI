using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_deg
{
    public partial class Inc : Form
    {
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
            if (usrname_bun.Text == "admin" && paw_bun.Text == "123")
                MessageBox.Show("welcom");
            else
                MessageBox.Show("使用者名稱或是密碼錯誤");
               
        }

        private void Return_btu_Click(object sender, EventArgs e)
        {
            Form_Login M_Log = new Form_Login();
            M_Log.Show();
            this.Close();
        }
    }
}
