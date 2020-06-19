using SqlForm.MES_HZDataSetTableAdapters;
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
using System.Configuration;
using System.Threading;

namespace SqlForm
{
    public partial class Form1 : Form
    {

        string str, Sqlstr;
        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
 //           textBox1.Text = MES_HZDataSet.Tables[3].ToString();
            int cout = MES_HZDataSet.Tables.Count;
            //textBox1.Text = cout.ToString();
            for(int i=0; i < 26; i++)
            {
                comboBox1.Items.Add(MES_HZDataSet.Tables[i].ToString());
            }
            comboBox1.Text = MES_HZDataSet.Tables[0].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mES_HZDataSet.BDP00_0000' 資料表。您可以視需要進行移動或移除。
            //this.bDP00_0000TableAdapter.Fill(this.MES_HZDataSet.BDP00_0000);
            str = ConfigurationManager.ConnectionStrings["conndb"].ConnectionString;
            Sqlstr = "select * from BDP03_0000";
            connection = new SqlConnection(str);


            da = new SqlDataAdapter(Sqlstr, connection);
            ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (textBox1.Text.Equals("")) textBox1.Text = "BDP03_0000";

                Sqlstr = "select * from " + comboBox1.Text;
                da = new SqlDataAdapter(Sqlstr, connection);

                ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch{}
        }


    }
}
