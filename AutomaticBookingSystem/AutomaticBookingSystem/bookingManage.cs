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
    public partial class bookingManage : Form
    {
        DataSet ds = new DataSet();
        
        string startPoint;
        int orderId;
        string price;
        string lineId;
        string trainclass;
        DateTime startTime;
        string name;
        string userId;
        string endPoint;
        public bookingManage()
        {
            InitializeComponent();
        }

        private void bookingManage_Load(object sender, EventArgs e)
        {
            string sql = "select *from [Order]";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from [Order]";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if ((string )dataGridView1.Rows[index].Cells[1].Value != null)
            {
                if (index >= dataGridView1.RowCount - 2)
                {
                    orderId = (int)dataGridView1.Rows[index].Cells[0].Value;
                    trainclass = (string)dataGridView1.Rows[index].Cells[1].Value;
                    name = (string)dataGridView1.Rows[index].Cells[4].Value;
                    startPoint = (string)dataGridView1.Rows[index].Cells[5].Value;
                    endPoint = (string)dataGridView1.Rows[index].Cells[6].Value;
                    startTime = (DateTime)dataGridView1.Rows[index].Cells[7].Value;
                    price = (string)dataGridView1.Rows[index].Cells[8].Value;
                    userId = (string)dataGridView1.Rows[index].Cells[2].Value;
                    lineId = (string)dataGridView1.Rows[index].Cells[3].Value;

                    string sqlUpdate = String.Format("insert into [Order] values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", orderId, userId, lineId, trainclass, name, startPoint, endPoint, startTime, price);
                    if (DataOperation.UpdateDataTable(sqlUpdate))
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加失败，请检查后重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string sql = "select *from [Order] ";
                    ds = DataOperation.GetDataSetBySql(sql);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("添加失败，请在表格后空白栏添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string no =txtclass.Text;
                string sql = "select * from [Order] where  trainClass='" + no + "'";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string sql = "select * from [Order] where  name='" + name + "'";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
        //    SqlDataAdapter da = new SqlDataAdapter();
            int index = dataGridView1.CurrentRow.Index;
            int id = (int)dataGridView1.Rows[index].Cells[0].Value;
            string sqlDel = "delete from[Order] where OrderId=" + id;
            DataOperation.UpdateDataTable(sqlDel);

            string sql = "select *from [Order] ";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void update_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            orderId = (int)dataGridView1.Rows[index].Cells[0].Value;
            trainclass = (string)dataGridView1.Rows[index].Cells[1].Value;
            name = (string)dataGridView1.Rows[index].Cells[4].Value;
            startPoint = (string)dataGridView1.Rows[index].Cells[5].Value;
             endPoint= (string)dataGridView1.Rows[index].Cells[6].Value;
           startTime = (DateTime)dataGridView1.Rows[index].Cells[7].Value;
           price = (string)dataGridView1.Rows[index].Cells[8].Value;
           userId= (string)dataGridView1.Rows[index].Cells[2].Value;
           lineId = (string)dataGridView1.Rows[index].Cells[3].Value;
           string sqlUpdate = String.Format("update [Order] set orderId={0},userId='{1}',lineId='{2}',trainClass='{3}',name='{4}',startPoint='{5}',endPoint='{6}',startTime='{7}',price='{8}' where orderId={0}", orderId, userId, lineId, trainclass, name, startPoint, endPoint, startTime, price);
           if (DataOperation.UpdateDataTable(sqlUpdate))
           {
               MessageBox.Show("更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           { 
              MessageBox.Show ("更改失败,请检查再重试","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }

            string sql = "select *from [Order] ";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
           
        }

     
    }
}
