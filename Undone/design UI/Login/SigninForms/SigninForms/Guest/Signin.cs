using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigninForms
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
            font_pwd.MaxLength = 12;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Closer_Form_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Font_pwd_TextChanged(object sender, EventArgs e){ }//Font_pwd
    }
}
