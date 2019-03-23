using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AutomaticBookingSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();


        }

        private void labTime_Click(object sender, EventArgs e)
        {
            /*  while (true)    //用于刷新时间
              {
                  Application.DoEvents(); 
                  labTime.Text = DateTime.Now.ToString();
                  System.Threading.Thread.Sleep(1000);
              } */
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }





        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Class1.level == 0)
            {
                ToolStripMenuItem.Enabled = false;

            }
         


        }



        private void 增添个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regester regest = new regester();
            // regest.MdiParent = this;
            // regest.WindowState = FormWindowState.Maximized;
            regest.Show();
        }

        private void 查看个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            guestInformation guest = new guestInformation();
            guest.MdiParent = this;
            guest.WindowState = FormWindowState.Maximized;
            guest.Show();

        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userManage user = new userManage();
            user.MdiParent = this;
            user.WindowState = FormWindowState.Maximized;
            user.Show();
        }

        private void 线路管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineManager line = new lineManager();
            line.MdiParent = this;
            line.WindowState = FormWindowState.Maximized;
            line.Show();

        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingManage order = new bookingManage();
            order.MdiParent = this;
            order.WindowState = FormWindowState.Maximized;
            order.Show();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 线路选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.MdiParent = this;
            booking.WindowState = FormWindowState.Maximized;
            booking.Show();

        }

        private void 已购订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userOrder userOrder1 = new userOrder();
            userOrder1.MdiParent = this;
            userOrder1.WindowState = FormWindowState.Maximized;
            userOrder1.Show();
        }

        private void 未出行订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goingOrder goingOrder1 = new goingOrder();
            goingOrder1.MdiParent = this;
            goingOrder1.WindowState = FormWindowState.Maximized;
            goingOrder1.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            guestInformation guest = new guestInformation();
            guest.MdiParent = this;
            guest.WindowState = FormWindowState.Maximized;
            guest.Show();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            userOrder userOrder1 = new userOrder();
            userOrder1.MdiParent = this;
            userOrder1.WindowState = FormWindowState.Maximized;
            userOrder1.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            regester regest = new regester();
           // regest.MdiParent = this;
           // regest.WindowState = FormWindowState.Maximized;
            regest.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {


        }

        private void 问题咨询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            question question1 = new question();
            question1.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            question question1 = new question();
            question1.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background2;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
        }
    }
}