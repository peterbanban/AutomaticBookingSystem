namespace AutomaticBookingSystem
{
    partial class lineManager
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
            this.lineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counts1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counts2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automaticBookingSystemDataSet = new AutomaticBookingSystem.automaticBookingSystemDataSet();
            this.lineTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.LineTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnclass = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIdDataGridViewTextBoxColumn,
            this.trainNoDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.firstClassDataGridViewTextBoxColumn,
            this.counts1DataGridViewTextBoxColumn,
            this.secondClassDataGridViewTextBoxColumn,
            this.counts2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(903, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lineIdDataGridViewTextBoxColumn
            // 
            this.lineIdDataGridViewTextBoxColumn.DataPropertyName = "lineId";
            this.lineIdDataGridViewTextBoxColumn.HeaderText = "线路编号";
            this.lineIdDataGridViewTextBoxColumn.Name = "lineIdDataGridViewTextBoxColumn";
            // 
            // trainNoDataGridViewTextBoxColumn
            // 
            this.trainNoDataGridViewTextBoxColumn.DataPropertyName = "trainNo";
            this.trainNoDataGridViewTextBoxColumn.HeaderText = "车次";
            this.trainNoDataGridViewTextBoxColumn.Name = "trainNoDataGridViewTextBoxColumn";
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
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "到站时间";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // firstClassDataGridViewTextBoxColumn
            // 
            this.firstClassDataGridViewTextBoxColumn.DataPropertyName = "firstClass";
            this.firstClassDataGridViewTextBoxColumn.HeaderText = "一等座";
            this.firstClassDataGridViewTextBoxColumn.Name = "firstClassDataGridViewTextBoxColumn";
            // 
            // counts1DataGridViewTextBoxColumn
            // 
            this.counts1DataGridViewTextBoxColumn.DataPropertyName = "counts1";
            this.counts1DataGridViewTextBoxColumn.HeaderText = "数量";
            this.counts1DataGridViewTextBoxColumn.Name = "counts1DataGridViewTextBoxColumn";
            // 
            // secondClassDataGridViewTextBoxColumn
            // 
            this.secondClassDataGridViewTextBoxColumn.DataPropertyName = "secondClass";
            this.secondClassDataGridViewTextBoxColumn.HeaderText = "二等座";
            this.secondClassDataGridViewTextBoxColumn.Name = "secondClassDataGridViewTextBoxColumn";
            // 
            // counts2DataGridViewTextBoxColumn
            // 
            this.counts2DataGridViewTextBoxColumn.DataPropertyName = "counts2";
            this.counts2DataGridViewTextBoxColumn.HeaderText = "数量";
            this.counts2DataGridViewTextBoxColumn.Name = "counts2DataGridViewTextBoxColumn";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(667, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加线路";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(812, 295);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除线路";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclass
            // 
            this.btnclass.Location = new System.Drawing.Point(73, 317);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(75, 23);
            this.btnclass.TabIndex = 3;
            this.btnclass.Text = "按车次查询";
            this.btnclass.UseVisualStyleBackColor = true;
            this.btnclass.Click += new System.EventHandler(this.btnclass_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(73, 276);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "按编号查询";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(170, 277);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(114, 21);
            this.txtNo.TabIndex = 5;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(170, 318);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(114, 21);
            this.txtClass.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(377, 295);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "全部显示";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改线路";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lineManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 468);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnclass);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "lineManager";
            this.Text = "lineManager";
            this.Load += new System.EventHandler(this.lineManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private automaticBookingSystemDataSet automaticBookingSystemDataSet;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private automaticBookingSystemDataSetTableAdapters.LineTableAdapter lineTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counts1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counts2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnclass;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
    }
}