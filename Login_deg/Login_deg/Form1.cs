using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_deg
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reg_btu_Click(object sender, EventArgs e)
        {
            Regit1 reg = new Regit1();
            reg.Show();
            this.Visible=false;
        }

        private void Login_btu_Click(object sender, EventArgs e)
        {
            Inc inc1 = new Inc();
            inc1.Show();
            this.Hide();

        }

        private void BunifuGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
