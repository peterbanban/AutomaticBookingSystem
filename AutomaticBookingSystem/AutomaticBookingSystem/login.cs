using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutomaticBookingSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if (name == null || password == null) {
                MessageBox.Show("账户或密码名不能为空", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            string connString = Class1.dataSource;
            SqlConnection connection = new SqlConnection(connString);
            string sql = String.Format("select count(*) from [User] where userName='{0}'and password='{1}'", name, password);
      //    
            string sql3 = String.Format("select name from [User] where userName='{0}' and password='{1}'",name,password);
            string sql4 = String.Format("select userId from [User] where userName='{0}' and password='{1}'", name, password);
            string sql5 = String.Format("select MAX (orderId ) from [Order] ");
            string sql2 = String.Format("select manager from [User] where userName='{0}'and password='{1}'and manager='1'", name, password);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlCommand command1 = new SqlCommand(sql2, connection); 
                SqlCommand command2 = new SqlCommand(sql3, connection);
                SqlCommand command3 = new SqlCommand(sql4, connection);
                SqlCommand command4 = new SqlCommand(sql5, connection);
                Class1.name = (string)command2.ExecuteScalar();
                Class1.userId = (int)command3.ExecuteScalar();
                Class1.orderId = (int )command4.ExecuteScalar()+1;
                int num = (int)command.ExecuteScalar();
       
                Class1.level = Convert.ToInt32((string)command1.ExecuteScalar());

                if (num > 0)
                {
                    if (MessageBox.Show("欢迎登陆自动订票系统！", "登陆成功", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                        ).Equals(DialogResult.OK))
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        Class1.StillName = name;
                        Class1.password = password;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {  //ex.Message
                MessageBox.Show("您输入的用户名或密码错误", "登陆失败！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally {
                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regester regester1=new regester();
            regester1.Show();

        }
    }
}
