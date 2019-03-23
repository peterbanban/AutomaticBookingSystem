namespace AutomaticBookingSystem
{
    partial class goingOrder
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
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.automaticBookingSystemDataSet1 = new AutomaticBookingSystem.automaticBookingSystemDataSet1();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSet1TableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.lineIdDataGridViewTextBoxColumn,
            this.trainClassDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(906, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "用户编号";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // lineIdDataGridViewTextBoxColumn
            // 
            this.lineIdDataGridViewTextBoxColumn.DataPropertyName = "lineId";
            this.lineIdDataGridViewTextBoxColumn.HeaderText = "线路编号";
            this.lineIdDataGridViewTextBoxColumn.Name = "lineIdDataGridViewTextBoxColumn";
            // 
            // trainClassDataGridViewTextBoxColumn
            // 
            this.trainClassDataGridViewTextBoxColumn.DataPropertyName = "trainClass";
            this.trainClassDataGridViewTextBoxColumn.HeaderText = "车次";
            this.trainClassDataGridViewTextBoxColumn.Name = "trainClassDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // startPointDataGridViewTextBoxColumn
            // 
            this.startPointDataGridViewTextBoxColumn.DataPropertyName = "startPoint";
            this.startPointDataGridViewTextBoxColumn.HeaderText = "起点站";
            this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
            // 
            // endPointDataGridViewTextBoxColumn
            // 
            this.endPointDataGridViewTextBoxColumn.DataPropertyName = "endPoint";
            this.endPointDataGridViewTextBoxColumn.HeaderText = "终点站";
            this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "发车时间";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.automaticBookingSystemDataSet1;
            // 
            // automaticBookingSystemDataSet1
            // 
            this.automaticBookingSystemDataSet1.DataSetName = "automaticBookingSystemDataSet1";
            this.automaticBookingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.automaticBookingSystemDataSet1;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // goingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 375);
            this.Controls.Add(this.dataGridView1);
            this.Name = "goingOrder";
            this.Text = "goingOrder";
            this.Load += new System.EventHandler(this.goingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private automaticBookingSystemDataSet1 automaticBookingSystemDataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private automaticBookingSystemDataSet1TableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource1;
    }
}