using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "test_Accout" && txtPassword.Text == "test_passwd")
            {
                MessageBox.Show("登录成功！");
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("登陆失败");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //遍历窗体中所有控件
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
