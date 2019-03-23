using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace AutomaticBookingSystem
{
    public partial class userManage : Form
    {
        int userId;
        string age;
        string userName;
        string password;
        string  name ; 
        string sex;
        string phone;
        string identify;
        string type;
        string manager = "0";

        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        public userManage()
        {
            InitializeComponent();
        }

        private void userManage_Load(object sender, EventArgs e)
        {
             string sql = "select *from [User] ";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

     

      

        private void btSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int  userId =Convert.ToInt32( txtselect.Text);
                string sql = "select * from [User] where  userId=" + userId;
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nameToolStripTextBox_Click(object sender, EventArgs e)
        {
          

        }

        private void 查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.查询(this.automaticBookingSystemDataSet.User);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 查询ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void add_Click(object sender, EventArgs e)
        {
              int index = dataGridView1.CurrentRow.Index;
            if ((string)dataGridView1.Rows[index].Cells[1].Value != null)
            {
                if (index >= dataGridView1.RowCount - 2)
                {
                    userId = (int)dataGridView1.Rows[index].Cells[0].Value;
                    userName = (string)dataGridView1.Rows[index].Cells[1].Value;
                    name = (string)dataGridView1.Rows[index].Cells[2].Value;
                    age = (string)dataGridView1.Rows[index].Cells[3].Value;
                    sex = (string)dataGridView1.Rows[index].Cells[4].Value;
                    identify = (string)dataGridView1.Rows[index].Cells[5].Value;
                    phone = (string)dataGridView1.Rows[index].Cells[6].Value;
                    type= (string)dataGridView1.Rows[index].Cells[7].Value;
                    manager = (string)dataGridView1.Rows[index].Cells[8].Value;
                    password = "";
                    string sqlAdd = String.Format("insert into [user] values( '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", userId, userName, password, name,age, sex, identify,phone,type,manager);
                    if (DataOperation.UpdateDataTable(sqlAdd))
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string sql = "select *from [User] ";
                    ds = DataOperation.GetDataSetBySql(sql);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("添加失败,请在表格下方空白栏处添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("添加失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }
        
        
        private void btnname_Click(object sender, EventArgs e)
        {
            try
            {
                string name =txtName.Text ;
                string sql = "select * from [user] where  name='" +name+ "'";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
             SqlDataAdapter da = new SqlDataAdapter();
             int index = dataGridView1.CurrentRow.Index;
             int id  = (int )dataGridView1.Rows[index ].Cells[0].Value;
             string sqlDel = "delete from[User] where userId=" + id;
             DataOperation.UpdateDataTable(sqlDel);

             string sql = "select *from [User] ";
             ds = DataOperation.GetDataSetBySql(sql);
             this.dataGridView1.DataSource = ds.Tables[0];
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select *from [User] ";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;
            if ((string)dataGridView1.Rows[index].Cells[1].Value != null)
            {
                if (index<=dataGridView1.RowCount - 2)
                {
                    userId = (int)dataGridView1.Rows[index].Cells[0].Value;
                    userName = (string)dataGridView1.Rows[index].Cells[1].Value;
                    name = (string)dataGridView1.Rows[index].Cells[2].Value;
                    age = (string)dataGridView1.Rows[index].Cells[3].Value;
                    sex = (string)dataGridView1.Rows[index].Cells[4].Value;
                    identify = (string)dataGridView1.Rows[index].Cells[5].Value;
                    phone = (string)dataGridView1.Rows[index].Cells[6].Value;
                    type = (string)dataGridView1.Rows[index].Cells[7].Value;
                    manager = (string)dataGridView1.Rows[index].Cells[8].Value;
                   
                    string sqlPassword = "select password from [user] where userId=" + userId;
                    ds1=DataOperation.GetDataSetBySql(sqlPassword);
                     password= (string)ds1.Tables[0].Rows[0][0];

                     string sqlAdd = String.Format("update  [user] set userId={0},userName='{1}',password='{2}',name='{3}',age='{4}',sex='{5}',number='{6}',phone='{7}',guestType='{8}',manager='{9}' where userId='{0}'", userId, userName, password, name, age, sex, identify, phone, type, manager);
                    if (DataOperation.UpdateDataTable(sqlAdd))
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("修改失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string sql = "select *from [User] ";
                    ds = DataOperation.GetDataSetBySql(sql);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("修改失败,请在表格下方空白栏处添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("修改失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
