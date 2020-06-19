using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ez_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regitdataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regitdataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exampleDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'exampleDataSet.regitdata' 資料表。您可以視需要進行移動或移除。
            this.regitdataTableAdapter.Fill(this.exampleDataSet.regitdata);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regitdataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.exampleDataSet);
        }
    }
}
