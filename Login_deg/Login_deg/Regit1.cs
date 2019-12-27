using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_deg
{ 
    public partial class Regit1 : Form
    {
        SqlConnection objCont;
        SqlCommand objCmd;
        String strSQL,type;

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


        private void Login_btu_Click_1(object sender, EventArgs e)
        {
            
            if (check1.CheckState == CheckState.Checked)
                type = "男";
            else if (check2.CheckState == CheckState.Checked)
                type = "女";
            else
                MessageBox.Show("只能選一個");


            if (!bunifuCheckbox1.Checked)
            {
                MessageBox.Show("未同意規則");
            }
            else
            {
                strSQL = "INSERT INTO account (username,password,email,birthday,sex) VALUES('";
                strSQL += txtname.Text + "','";
                strSQL += txtpwd.Text + "','";
                strSQL += txtemail.Text + "','";
                strSQL += dateBirt.CustomFormat + "','";
                strSQL += type + "')";

                objCont = new SqlConnection(@"Data Source=JCONT-RD;Initial Catalog=statement;Persist Security Info=True;User ID=tes;Password=123");
                objCont.Open();

                objCmd = new SqlCommand(strSQL, objCont);
                int count = objCmd.ExecuteNonQuery();

                if (count == 1)
                {
                    MessageBox.Show("註冊完成");
                    Inc loge = new Inc();
                    loge.Show();this.Close();
                }
                else
                    MessageBox.Show("error");
                objCont.Close();
            }
        }
    }
}
