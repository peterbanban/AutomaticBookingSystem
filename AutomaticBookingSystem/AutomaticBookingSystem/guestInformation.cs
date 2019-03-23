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
    public partial class guestInformation : Form
    {
         string age ;
           
           // string  name ; 
            string sex ;
            string phone ;
             string  identify ;
            string  type ;
            string manager = "0";
            string id;

        public guestInformation()
        {
            InitializeComponent();
        }

        private void guestInformation_Load(object sender, EventArgs e)
        {
           
            string connString = Class1.dataSource;
            SqlConnection connection = new SqlConnection(connString);

           Class1.name  = String.Format("select  [User].name from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            id= String.Format("select [User].userId from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            sex = String.Format("select [User].sex from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            phone  = String.Format("select [User].phone from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            identify = String.Format("select [User].number from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            type  = String.Format("select [User].guestType from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            age = String.Format("select [User].age from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);
            manager = String.Format("select [User].manager from [User] where userName='{0}'and password='{1}'", Class1.StillName, Class1.password);

          
            txtAge.ReadOnly = true;
            txtID.ReadOnly = true;
            txtIdentify.ReadOnly = true;
            txtLevel.ReadOnly = true;
            txtName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtUserName.ReadOnly = true;
            
            try
            {
                connection.Open();
               txtID.Text  = Class2.sqlAnalyse(id, connection);
               txtName.Text = Class2.sqlAnalyse(Class1.name, connection);
               txtPassword.Text =Class1.password;
               txtPhone.Text = Class2.sqlAnalyse(phone, connection);
               txtLevel.Text = Convert.ToString( Class1.level);
               cbGuestType.Text  = Class2.sqlAnalyse(type, connection);
               txtUserName.Text = Class1.StillName;
               txtAge.Text = Class2.sqlAnalyse(age, connection);
               cbSex.Text = Class2.sqlAnalyse(sex, connection);
               txtIdentify.Text = Class2.sqlAnalyse(identify, connection);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {
                    }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAge.ReadOnly = false;
           // txtID.ReadOnly = false;
            txtIdentify.ReadOnly = false;
          //  txtLevel.ReadOnly = false;
            txtName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtPhone.ReadOnly = false; 
            txtUserName.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
              age = txtAge.Text;
             Class1.userId = Convert .ToInt32( txtID.Text);
              Class1.name  = txtName.Text;
              sex = cbSex.Text;
              phone = txtPhone.Text;
              identify = txtIdentify.Text;
              type =cbGuestType.Text;
              manager = txtLevel .Text ;
              Class1.password = txtPassword.Text;
              Class1.StillName = txtUserName.Text;
              
             
            string connString = Class1.dataSource;
            SqlConnection connection = new SqlConnection(connString);
            string update = String.Format("update [User] set  age='{1}',name='{2}',sex='{3}',phone='{4}',number='{5}',userName='{6}',password='{7}',guestType='{8}',manager='{9}' where userId='{0}'",Class1.userId,age ,Class1.name ,sex,phone,identify,Class1.StillName,Class1.password,type,Class1.level);
            
            try
            {
                connection.Open();
                  SqlCommand command = new SqlCommand(update, connection);
                 int a= Convert.ToInt32(command.ExecuteNonQuery()) ;
                 if (a > 0)
                 {
                     MessageBox.Show("修改数据成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     MessageBox.Show("修改数据未成功，请检查并重新提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally {

                connection.Close();
            }
         
            }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

