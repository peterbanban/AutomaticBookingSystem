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
    public partial class lineManager : Form
    {
        DataSet ds = new DataSet();
        string lineId;
        string trainNo;
        string startPoint;
        string endPoint;
        DateTime startTime;
        DateTime startDate;
        DateTime endTime;
        string firstClass;
        string count1;
        string secondClass;
        string count2;
    
        public lineManager()
        {
            InitializeComponent();
        }

        private void lineManager_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“automaticBookingSystemDataSet.Line”中。您可以根据需要移动或删除它。
           // this.lineTableAdapter.Fill(this.automaticBookingSystemDataSet.Line);
            string sql = "select *from [Line]";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            int index = dataGridView1.CurrentRow.Index;
            string id = (string )dataGridView1.Rows[index].Cells[0].Value;
            string sqlDel = "delete from[Line] where lineId=" + id;
            DataOperation.UpdateDataTable(sqlDel);

            string sql = "select *from [Line] ";
            ds = DataOperation.GetDataSetBySql(sql);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            try
            {
                string no =txtNo.Text ;
                string sql = "select * from [Line] where  lineId='" + no + "'";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtClass.Text;
                string sql = "select * from [Line] where  trainNo='" + name + "'";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            { 
                string sql = "select * from [Line]";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index <=dataGridView1.RowCount - 2)
            {
                lineId = (string)dataGridView1.Rows[index].Cells[0].Value;
                trainNo = (string)dataGridView1.Rows[index].Cells[1].Value;
                startPoint = (string)dataGridView1.Rows[index].Cells[2].Value;
                endPoint = (string)dataGridView1.Rows[index].Cells[3].Value;
                startTime = (DateTime)dataGridView1.Rows[index].Cells[4].Value;
                startDate = (DateTime)dataGridView1.Rows[index].Cells[4].Value;
                endTime = (DateTime)dataGridView1.Rows[index].Cells[5].Value;
                firstClass = (string)dataGridView1.Rows[index].Cells[6].Value;
                count1 = (string)dataGridView1.Rows[index].Cells[7].Value;
                secondClass = (string)dataGridView1.Rows[index].Cells[8].Value;
                count2 = (string)dataGridView1.Rows[index].Cells[9].Value;
                string sqlUpdate = String.Format("update [line] set lineId='{0}',trainNo='{10}',startPoint='{1}',endPoint='{2}',startTime='{3}',startDate='{4}',endTime='{5}',firstClass='{6}',counts1='{7}',secondClass='{8}',counts2='{9}' where lineId='{0}'", lineId, startPoint, endPoint, startTime, startDate, endTime, firstClass, count1, secondClass, count2, trainNo);
                if (DataOperation.UpdateDataTable(sqlUpdate))
                {
                    MessageBox.Show("更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("更改失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string sql = "select *from [line] ";
                ds = DataOperation.GetDataSetBySql(sql);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            else {
                   MessageBox.Show("更改失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if ((string)dataGridView1.Rows[index].Cells[1].Value != null)
            {
                if (index >= dataGridView1.RowCount - 2)
                {
                    lineId = (string)dataGridView1.Rows[index].Cells[0].Value;
                    trainNo = (string)dataGridView1.Rows[index].Cells[1].Value;
                    startPoint = (string)dataGridView1.Rows[index].Cells[2].Value;
                    endPoint = (string)dataGridView1.Rows[index].Cells[3].Value;
                    startTime = (DateTime)dataGridView1.Rows[index].Cells[4].Value;
                    startDate = (DateTime)dataGridView1.Rows[index].Cells[4].Value;
                    endTime = (DateTime)dataGridView1.Rows[index].Cells[5].Value;
                    firstClass = (string)dataGridView1.Rows[index].Cells[6].Value;
                    count1 = (string)dataGridView1.Rows[index].Cells[7].Value;
                    secondClass = (string)dataGridView1.Rows[index].Cells[8].Value;
                    count2 = (string)dataGridView1.Rows[index].Cells[9].Value; 
                    string sqlUpdate = String.Format("insert into [line] values( '{0}','{10}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", lineId, startPoint, endPoint, startTime, startDate, endTime, firstClass, count1, secondClass, count2, trainNo);
                    if (DataOperation.UpdateDataTable(sqlUpdate))
                    {
                        MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加失败,请检查再重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string sql = "select *from [line] ";
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
    }
}
 