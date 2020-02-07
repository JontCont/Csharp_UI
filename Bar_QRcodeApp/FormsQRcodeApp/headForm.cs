using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsQRcodeApp
{
    public partial class headForm : Form
    {
        public headForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barcode bar = new Barcode();
            Qrcode qr = new Qrcode();
            switch(comboBox1.Text)
            {
                case "Bar-code": bar.Show();this.Hide(); break;
                case "Qr-code": qr.Show(); this.Hide(); break;
            }
        }

        private void headForm_Load(object sender, EventArgs e)
        {

        }
    }
}
