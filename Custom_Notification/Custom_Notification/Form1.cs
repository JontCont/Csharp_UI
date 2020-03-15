using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Notification
{
    public partial class Form1 :MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Amin_form.enmType type)
        {
            Amin_form frm = new Amin_form();
            frm.showAlert(msg, type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert("Success Alert", Amin_form.enmType.Success);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Alert("Warning Alert", Amin_form.enmType.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Alert("Error Alert", Amin_form.enmType.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Alert("Info Alert", Amin_form.enmType.Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
