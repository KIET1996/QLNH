namespace QLNH
{
    partial class FrmStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.txtIDDis = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDiscount = new System.Windows.Forms.DataGridView();
            this.ID_Dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProfit = new System.Windows.Forms.TabPage();
            this.gbTimePicker2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb2_dt2 = new System.Windows.Forms.DateTimePicker();
            this.gb2_dt1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).BeginInit();
            this.tabProfit.SuspendLayout();
            this.gbTimePicker2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManagement,
            this.mnDish,
            this.mnOrder,
            this.mnStatistic,
            this.mnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManagement
            // 
            this.mnManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnManagement.Name = "mnManagement";
            this.mnManagement.Size = new System.Drawing.Size(74, 23);
            this.mnManagement.Text = "Quản Lý";
            // 
            // mnDish
            // 
            this.mnDish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDish.Name = "mnDish";
            this.mnDish.Size = new System.Drawing.Size(72, 23);
            this.mnDish.Text = "Món Ăn";
            // 
            // mnOrder
            // 
            this.mnOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnOrder.Name = "mnOrder";
            this.mnOrder.Size = new System.Drawing.Size(76, 23);
            this.mnOrder.Text = "Gọi Món";
            // 
            // mnStatistic
            // 
            this.mnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStatistic.Name = "mnStatistic";
            this.mnStatistic.Size = new System.Drawing.Size(82, 23);
            this.mnStatistic.Text = "Thống Kê";
            // 
            // mnLogout
            // 
            this.mnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(86, 23);
            this.mnLogout.Text = "Đăng Xuất";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDiscount);
            this.tabControl1.Controls.Add(this.tabProfit);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.btnSave);
            this.tabDiscount.Controls.Add(this.btnDelete);
            this.tabDiscount.Controls.Add(this.btnEdit);
            this.tabDiscount.Controls.Add(this.btnAdd);
            this.tabDiscount.Controls.Add(this.gbDiscount);
            this.tabDiscount.Controls.Add(this.gvDiscount);
            this.tabDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDiscount.Location = new System.Drawing.Point(4, 22);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscount.Size = new System.Drawing.Size(869, 377);
            this.tabDiscount.TabIndex = 0;
            this.tabDiscount.Text = "Giảm Giá";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(102, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(287, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(193, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.nudPercent);
            this.gbDiscount.Controls.Add(this.txtIDDis);
            this.gbDiscount.Controls.Add(this.lblID);
            this.gbDiscount.Controls.Add(this.dtFinish);
            this.gbDiscount.Controls.Add(this.label6);
            this.gbDiscount.Controls.Add(this.dtStart);
            this.gbDiscount.Controls.Add(this.label5);
            this.gbDiscount.Controls.Add(this.txtDiscription);
            this.gbDiscount.Controls.Add(this.label2);
            this.gbDiscount.Controls.Add(this.label1);
            this.gbDiscount.Location = new System.Drawing.Point(20, 54);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(302, 251);
            this.gbDiscount.TabIndex = 1;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Giảm Giá";
            // 
            // nudPercent
            // 
            this.nudPercent.Location = new System.Drawing.Point(83, 65);
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(120, 26);
            this.nudPercent.TabIndex = 2;
            // 
            // txtIDDis
            // 
            this.txtIDDis.Location = new System.Drawing.Point(83, 19);
            this.txtIDDis.Name = "txtIDDis";
            this.txtIDDis.ReadOnly = true;
            this.txtIDDis.Size = new System.Drawing.Size(100, 26);
            this.txtIDDis.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // dtFinish
            // 
            this.dtFinish.CustomFormat = "dd-MM-yyyy";
            this.dtFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinish.Location = new System.Drawing.Point(83, 209);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(200, 26);
            this.dtFinish.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Finish";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MM-yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtStart.Location = new System.Drawing.Point(83, 163);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 26);
            this.dtStart.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(83, 113);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(200, 26);
            this.txtDiscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần trăm";
            // 
            // gvDiscount
            // 
            this.gvDiscount.AllowUserToAddRows = false;
            this.gvDiscount.AllowUserToDeleteRows = false;
            this.gvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Dis,
            this.per,
            this.descript,
            this.start,
            this.finish,
            this.sta});
            this.gvDiscount.Location = new System.Drawing.Point(348, 6);
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            this.gvDiscount.Size = new System.Drawing.Size(501, 311);
            this.gvDiscount.TabIndex = 0;
            this.gvDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDiscount_CellClick);
            // 
            // ID_Dis
            // 
            this.ID_Dis.DataPropertyName = "ID_Dis";
            this.ID_Dis.HeaderText = "Mã giảm giá";
            this.ID_Dis.Name = "ID_Dis";
            this.ID_Dis.ReadOnly = true;
            this.ID_Dis.Width = 50;
            // 
            // per
            // 
            this.per.DataPropertyName = "Per";
            this.per.HeaderText = "Phần trăm";
            this.per.Name = "per";
            this.per.ReadOnly = true;
            this.per.Width = 50;
            // 
            // descript
            // 
            this.descript.DataPropertyName = "Descript";
            this.descript.HeaderText = "Mô tả";
            this.descript.Name = "descript";
            this.descript.ReadOnly = true;
            // 
            // start
            // 
            this.start.DataPropertyName = "Start";
            dataGridViewCellStyle11.Format = "dd-MM-yyyy";
            dataGridViewCellStyle11.NullValue = null;
            this.start.DefaultCellStyle = dataGridViewCellStyle11;
            this.start.HeaderText = "Bắt đầu";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // finish
            // 
            this.finish.DataPropertyName = "Finish";
            dataGridViewCellStyle12.Format = "dd-MM-yyyy";
            dataGridViewCellStyle12.NullValue = null;
            this.finish.DefaultCellStyle = dataGridViewCellStyle12;
            this.finish.HeaderText = "Kết thúc";
            this.finish.Name = "finish";
            this.finish.ReadOnly = true;
            // 
            // sta
            // 
            this.sta.DataPropertyName = "Sta";
            this.sta.HeaderText = "Trạng thái";
            this.sta.Name = "sta";
            this.sta.ReadOnly = true;
            this.sta.Width = 50;
            // 
            // tabProfit
            // 
            this.tabProfit.Controls.Add(this.gbTimePicker2);
            this.tabProfit.Controls.Add(this.dataGridView2);
            this.tabProfit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfit.Location = new System.Drawing.Point(4, 22);
            this.tabProfit.Name = "tabProfit";
            this.tabProfit.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfit.Size = new System.Drawing.Size(869, 377);
            this.tabProfit.TabIndex = 1;
            this.tabProfit.Text = "Lợi Nhuận";
            this.tabProfit.UseVisualStyleBackColor = true;
            // 
            // gbTimePicker2
            // 
            this.gbTimePicker2.Controls.Add(this.label3);
            this.gbTimePicker2.Controls.Add(this.gb2_dt2);
            this.gbTimePicker2.Controls.Add(this.gb2_dt1);
            this.gbTimePicker2.Controls.Add(this.label4);
            this.gbTimePicker2.Location = new System.Drawing.Point(50, 26);
            this.gbTimePicker2.Name = "gbTimePicker2";
            this.gbTimePicker2.Size = new System.Drawing.Size(256, 238);
            this.gbTimePicker2.TabIndex = 6;
            this.gbTimePicker2.TabStop = false;
            this.gbTimePicker2.Text = "Thời Gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ Ngày";
            // 
            // gb2_dt2
            // 
            this.gb2_dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gb2_dt2.Location = new System.Drawing.Point(68, 163);
            this.gb2_dt2.Name = "gb2_dt2";
            this.gb2_dt2.Size = new System.Drawing.Size(144, 26);
            this.gb2_dt2.TabIndex = 4;
            // 
            // gb2_dt1
            // 
            this.gb2_dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gb2_dt1.Location = new System.Drawing.Point(68, 83);
            this.gb2_dt1.Name = "gb2_dt1";
            this.gb2_dt1.Size = new System.Drawing.Size(144, 26);
            this.gb2_dt1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đến Ngày";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(405, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 311);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStatistical";
            this.Text = "Quản Lý Nhà Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDiscount.ResumeLayout(false);
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).EndInit();
            this.tabProfit.ResumeLayout(false);
            this.gbTimePicker2.ResumeLayout(false);
            this.gbTimePicker2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManagement;
        private System.Windows.Forms.ToolStripMenuItem mnDish;
        private System.Windows.Forms.ToolStripMenuItem mnOrder;
        private System.Windows.Forms.ToolStripMenuItem mnStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabProfit;
        private System.Windows.Forms.DataGridView gvDiscount;
        private System.Windows.Forms.GroupBox gbTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker gb2_dt2;
        private System.Windows.Forms.DateTimePicker gb2_dt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.TextBox txtIDDis;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn per;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn sta;
        private System.Windows.Forms.Button btnSave;
    }
}