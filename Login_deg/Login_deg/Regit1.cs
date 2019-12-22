using System;
using System.Windows.Forms;

namespace Login_deg
{ 
    public partial class Regit1 : Form
    {
        public Regit1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_btu_Click(object sender, EventArgs e)
        {
            Form_Login M_Log = new Form_Login();
            M_Log.Show();
            this.Close();
        }

        private void Login_btu_Click(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuTextBox4.Text = bunifuTextBox3.Text = bunifuTextBox2.Text = bunifuTextBox1.Text = "";
        }

        private void Login_btu_Click_1(object sender, EventArgs e)
        {
            if (!bunifuCheckbox1.Checked)
            {
                MessageBox.Show("未同意規則");
            }
        }
    }
}
