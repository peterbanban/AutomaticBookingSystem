﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomaticBookingSystem
{
    public partial class goingOrder : Form
    {
        DataSet ds = new DataSet();
        public goingOrder()
        {
            InitializeComponent();
        }

        private void goingOrder_Load(object sender, EventArgs e)
        {
              DateTime  nowDatetime =  System.DateTime.Now;
            // TODO: 这行代码将数据加载到表“automaticBookingSystemDataSet1.Order”中。您可以根据需要移动或删除它。
         //   this.orderTableAdapter.Fill(this.automaticBookingSystemDataSet1.Order);
            string sql = "select *from [Order] where userId='" + Class1.userId + "'AND startTime>'"+nowDatetime+"'" ;
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
