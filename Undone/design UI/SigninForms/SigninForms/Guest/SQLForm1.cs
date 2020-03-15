using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigninForms.Guest
{
    public partial class SQLForm1 : Form
    {
        public SQLForm1()
        {
            InitializeComponent();
        }

        private void SQLForm1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'exampleDataSet.regitdata' 資料表。您可以視需要進行移動或移除。
            this.regitdataTableAdapter.Fill(this.exampleDataSet.regitdata);

        }
    }
}
