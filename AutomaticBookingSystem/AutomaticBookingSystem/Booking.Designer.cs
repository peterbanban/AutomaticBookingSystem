namespace AutomaticBookingSystem
{
    partial class Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.UserTableAdapter();
            this.lineTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.LineTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "出发站:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "达到站:";
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Items.AddRange(new object[] {
            "北京",
            "上海",
            "南京",
            "合肥",
            "成都",
            "南昌",
            "石家庄"});
            this.cbStart.Location = new System.Drawing.Point(126, 15);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(145, 20);
            this.cbStart.TabIndex = 2;
            this.cbStart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbEnd
            // 
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Items.AddRange(new object[] {
            "北京",
            "上海",
            "南京",
            "合肥",
            "成都",
            "南昌",
            "石家庄"});
            this.cbEnd.Location = new System.Drawing.Point(127, 60);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(145, 20);
            this.cbEnd.TabIndex = 3;
            this.cbEnd.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(539, 427);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交订单";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "出发时间:";
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
            this.dataGridView1.Location = new System.Drawing.Point(308, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(759, 234);
            this.dataGridView1.TabIndex = 10;
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
            this.startPointDataGridViewTextBoxColumn.HeaderText = "起点";
            this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
            // 
            // endPointDataGridViewTextBoxColumn
            // 
            this.endPointDataGridViewTextBoxColumn.DataPropertyName = "endPoint";
            this.endPointDataGridViewTextBoxColumn.HeaderText = "终点";
            this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "出发时间";
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
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.automaticBookingSystemDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // lineTableAdapter
            // 
            this.lineTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "追加时间查询";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(210, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "线路编号：";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(300, 312);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(440, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "车次：";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(511, 314);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(100, 21);
            this.txtClass.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(643, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "起点：";
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(704, 314);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.ReadOnly = true;
            this.txtStartPoint.Size = new System.Drawing.Size(100, 21);
            this.txtStartPoint.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(850, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "终点：";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(911, 314);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.ReadOnly = true;
            this.txtEndPoint.Size = new System.Drawing.Size(100, 21);
            this.txtEndPoint.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(850, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "价格：";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(911, 369);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(427, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "到达时间：";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(514, 369);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(100, 21);
            this.txtEndTime.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(210, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "出发时间：";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(300, 367);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(100, 21);
            this.txtStartTime.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "一等座",
            "二等座"});
            this.comboBox1.Location = new System.Drawing.Point(719, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 20);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(630, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "座位类型：";
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(381, 427);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 23);
            this.btnSelect.TabIndex = 30;
            this.btnSelect.Text = "选择乘客";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(15, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1048, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "---------------------------------------------------------------------------------" +
                "-------------------------------------------------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "查看已购订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStartPoint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbEnd);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private automaticBookingSystemDataSet automaticBookingSystemDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private automaticBookingSystemDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private automaticBookingSystemDataSetTableAdapters.LineTableAdapter lineTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.Button button1;
    }
}