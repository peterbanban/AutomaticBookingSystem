namespace AutomaticBookingSystem
{
    partial class bookingManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.automaticBookingSystemDataSet1 = new AutomaticBookingSystem.automaticBookingSystemDataSet1();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automaticBookingSystemDataSet = new AutomaticBookingSystem.automaticBookingSystemDataSet();
            this.lineTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.LineTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.OrderTableAdapter();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter1 = new AutomaticBookingSystem.automaticBookingSystemDataSet1TableAdapters.OrderTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.trainClass,
            this.userIdDataGridViewTextBoxColumn,
            this.lineIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(941, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // trainClass
            // 
            this.trainClass.DataPropertyName = "trainClass";
            this.trainClass.HeaderText = "车次";
            this.trainClass.Name = "trainClass";
            this.trainClass.ReadOnly = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "用户编号";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // lineIdDataGridViewTextBoxColumn
            // 
            this.lineIdDataGridViewTextBoxColumn.DataPropertyName = "lineId";
            this.lineIdDataGridViewTextBoxColumn.HeaderText = "线路编号";
            this.lineIdDataGridViewTextBoxColumn.Name = "lineIdDataGridViewTextBoxColumn";
            this.lineIdDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // startPointDataGridViewTextBoxColumn
            // 
            this.startPointDataGridViewTextBoxColumn.DataPropertyName = "startPoint";
            this.startPointDataGridViewTextBoxColumn.HeaderText = "起点站";
            this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
            this.startPointDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // endPointDataGridViewTextBoxColumn
            // 
            this.endPointDataGridViewTextBoxColumn.DataPropertyName = "endPoint";
            this.endPointDataGridViewTextBoxColumn.HeaderText = "终点站";
            this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
            this.endPointDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "发车时间";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = false;
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataMember = "Order";
            this.orderBindingSource2.DataSource = this.automaticBookingSystemDataSet1;
            // 
            // automaticBookingSystemDataSet1
            // 
            this.automaticBookingSystemDataSet1.DataSetName = "automaticBookingSystemDataSet1";
            this.automaticBookingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataMember = "Line";
            this.lineBindingSource.DataSource = this.automaticBookingSystemDataSet;
            // 
            // automaticBookingSystemDataSet
            // 
            this.automaticBookingSystemDataSet.DataSetName = "automaticBookingSystemDataSet";
            this.automaticBookingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lineTableAdapter
            // 
            this.lineTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = this.automaticBookingSystemDataSet1;
            this.orderBindingSource.Position = 0;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.automaticBookingSystemDataSet;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(458, 277);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 26);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "添加订单";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(614, 277);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 26);
            this.update.TabIndex = 2;
            this.update.Text = "更改订单";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(764, 277);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 26);
            this.del.TabIndex = 3;
            this.del.Text = "删除订单";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(43, 253);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 26);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "按车次查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(33, 300);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(99, 26);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "按用户名查找";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(151, 257);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(110, 21);
            this.txtclass.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 303);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 21);
            this.txtName.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "显示全部订单";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookingManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.del);
            this.Controls.Add(this.update);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bookingManage";
            this.Text = "bookingManagecs";
            this.Load += new System.EventHandler(this.bookingManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private automaticBookingSystemDataSet automaticBookingSystemDataSet;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private automaticBookingSystemDataSetTableAdapters.LineTableAdapter lineTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private automaticBookingSystemDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private automaticBookingSystemDataSet1 automaticBookingSystemDataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private automaticBookingSystemDataSet1TableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button3;
    }
}