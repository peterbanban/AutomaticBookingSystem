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
    public partial class regester : Form
    {
        public regester()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            int id=110;
            string name = txtName.Text;
            string password = txtPwd.Text;
            string idCard = txtNo.Text;
            string phone = txtPhone.Text;
            string userName=txtUserName.Text;
            string sex = "男";
            string age = txtAge.Text;
            string guestType = comboBox1.Text;
            int manager =0;

            if (radioButtonSex1.Checked == true)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            
            if (name =="" || password =="" || idCard =="" || phone == "" || userName == "" || sex == "" || age == "" || guestType =="")
            {
                MessageBox.Show("请检查是否有空值", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             else
            {
                string connString = Class1.dataSource;
               SqlConnection connection = new SqlConnection(connString);
            
               string sql2 = String.Format("select MAX([USER].userId)from [User]");
                string addInformation = String.Format("update");
              try                      
               {   
                connection.Open();
                  SqlCommand command1=new SqlCommand (sql2,connection);
                  id = (int)command1.ExecuteScalar()+1;
                  string sql1 = String.Format("insert into [User] VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9})", id, userName, password, name, age, sex, idCard, phone, guestType, manager);
                  SqlCommand command = new SqlCommand(sql1, connection);
                int num = (int)command.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("恭喜您成为本系统第"+id+"个用户","注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("请检查注册信息格式是否正确","注册失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
