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

    public partial class Booking : Form
    {
        DataSet ds = new DataSet();
        int rowSelected;
        string  setStartPoint ;
        string  setEndPoint ;
        string price;
        string lineId;
        string trainclass ; 
        string startTime ;
        string endTime ;
        string mount2;
        string mount1;
        int flag;

        public Booking()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“automaticBookingSystemDataSet.Line”中。您可以根据需要移动或删除它。
          //  this.lineTableAdapter.Fill(this.automaticBookingSystemDataSet.Line);
            // TODO: 这行代码将数据加载到表“automaticBookingSystemDataSet.User”中。您可以根据需要移动或删除它。
           // this.userTableAdapter.Fill(this.automaticBookingSystemDataSet.User);
            string sql = "select *from [Line]";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string delSql;
            string orderSql = String.Format("insert into [Order] values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') ", Class1.orderId, Class1.userId, lineId, trainclass, Class1.name, setStartPoint, setEndPoint, startTime, price);
            DataOperation.UpdateDataTable(orderSql);
            Class1.orderId++;
            if (flag == 1)
            {
                mount1 = Convert.ToString((Convert.ToInt32(mount1) - 1));
                delSql = "uPdate [line] set  counts1='" + mount1 + "'where lineId ='" + lineId+"'";
                DataOperation.UpdateDataTable(delSql);
            }
             if (flag == 2)
            {
                mount2 = Convert.ToString((Convert.ToInt32(mount2) - 1));
                delSql = "uPdate [line] set  counts2='" + mount2 + "' where lineId ='" + lineId + "'";
                DataOperation.UpdateDataTable(delSql);
            }
          //  this.lineTableAdapter.Fill(this.automaticBookingSystemDataSet.Line);
              string  sqlUpdate = "select *from [Line]";
        
            ds = DataOperation.GetDataSetBySql(sqlUpdate );
            this.dataGridView1.DataSource = ds.Tables[0];
           
            MessageBox.Show ("提交订单成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sqlSelect;
            string   startPoint = cbStart.Text;
            string  endPoint = cbEnd.Text;
            DateTime Timepicker = dateTimePicker1.Value;
            string time = Convert.ToString(Timepicker);
            int positon = time.IndexOf(" ");
            string DateTime = time.Substring(0, positon);
          
            
            if (!checkBox1.Checked)
            {
                sqlSelect = "select *from [Line] where startPoint='" + startPoint + "'and endPoint='" + endPoint + "'";
            }
            else
            {
                sqlSelect = "select *from [Line] where startPoint='" + startPoint + "'and endPoint='" + endPoint + "'and startDate='" + DateTime + "'";
            }
            ds = DataOperation.GetDataSetBySql(sqlSelect);
            this.dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = dataGridView1.CurrentRow.Index;
             lineId = Convert.ToString((object)dataGridView1.Rows[rowSelected].Cells[0].Value);
              trainclass = (string)dataGridView1.Rows[rowSelected].Cells[1].Value;
              setStartPoint = (string)dataGridView1.Rows[rowSelected].Cells[2].Value;
              setEndPoint = (string)dataGridView1.Rows[rowSelected].Cells[3].Value;
              startTime = Convert.ToString((DateTime)dataGridView1.Rows[rowSelected].Cells[4].Value);
             endTime = Convert.ToString((DateTime)dataGridView1.Rows[rowSelected].Cells[5].Value);
            string price1 = (string)dataGridView1.Rows[rowSelected].Cells[6].Value;
            string price2 = (string)dataGridView1.Rows[rowSelected].Cells[8].Value;
              mount1 = (string)dataGridView1.Rows[rowSelected].Cells[7].Value;
             mount2=(string)dataGridView1.Rows[rowSelected].Cells[9].Value;

            txtClass.Text = trainclass;
            txtEndPoint.Text = setEndPoint;
            txtEndTime.Text = endTime;
            txtId.Text = lineId;
           
            txtStartPoint.Text = setStartPoint;
            txtStartTime.Text = startTime;

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "一等座")
            {
                txtPrice.Text = (string)dataGridView1.Rows[rowSelected].Cells[6].Value;
                price = txtPrice.Text;
                flag = 1;
                mount1 = Convert.ToString((Convert.ToInt32(mount1) - 1));
            }
            else
            {
                txtPrice.Text = (string)dataGridView1.Rows[rowSelected].Cells[8].Value;
                price = txtPrice.Text;
                flag = 2;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userOrder order = new userOrder();
            order.MdiParent = MainForm.ActiveForm ;
            order.WindowState = FormWindowState.Maximized;
            order.Show();
        }
    }
}
