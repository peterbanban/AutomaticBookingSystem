namespace AutomaticBookingSystem
{
    partial class userManage
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
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automaticBookingSystemDataSet = new AutomaticBookingSystem.automaticBookingSystemDataSet();
            this.btnNo = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userTableAdapter = new AutomaticBookingSystem.automaticBookingSystemDataSetTableAdapters.UserTableAdapter();
            this.txtselect = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.guestTypeDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(944, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "用户编号";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "年龄";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // guestTypeDataGridViewTextBoxColumn
            // 
            this.guestTypeDataGridViewTextBoxColumn.DataPropertyName = "guestType";
            this.guestTypeDataGridViewTextBoxColumn.HeaderText = "乘客类型";
            this.guestTypeDataGridViewTextBoxColumn.Name = "guestTypeDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "管理权限";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.automaticBookingSystemDataSet;
            // 
            // automaticBookingSystemDataSet
            // 
            this.automaticBookingSystemDataSet.DataSetName = "automaticBookingSystemDataSet";
            this.automaticBookingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(211, 318);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "按编号查询";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(505, 331);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(678, 331);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(844, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // txtselect
            // 
            this.txtselect.Location = new System.Drawing.Point(44, 320);
            this.txtselect.Name = "txtselect";
            this.txtselect.Size = new System.Drawing.Size(118, 21);
            this.txtselect.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(44, 358);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 21);
            this.txtName.TabIndex = 6;
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(211, 356);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(75, 23);
            this.btnname.TabIndex = 7;
            this.btnname.Text = "按姓名查询查询";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "查看全部";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtselect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userManage";
            this.Text = "userManage";
            this.Load += new System.EventHandler(this.userManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automaticBookingSystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private automaticBookingSystemDataSet automaticBookingSystemDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private automaticBookingSystemDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtselect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Button button1;
    }
}