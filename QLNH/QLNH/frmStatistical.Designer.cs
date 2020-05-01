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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDTSeen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDTFinish = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDTStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.gvProfit = new System.Windows.Forms.DataGridView();
            this.ID_Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Arrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDish = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalStatistic = new System.Windows.Forms.TextBox();
            this.btnSeen = new System.Windows.Forms.Button();
            this.gbTimePicker2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStatisticFinish = new System.Windows.Forms.DateTimePicker();
            this.dtStatisticStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gvStatisticDish = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).BeginInit();
            this.tabProfit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfit)).BeginInit();
            this.tabDish.SuspendLayout();
            this.gbTimePicker2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatisticDish)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManagement,
            this.mnDish,
            this.mnOrder,
            this.mnStatistic,
            this.mnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManagement
            // 
            this.mnManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànToolStripMenuItem});
            this.mnManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnManagement.Name = "mnManagement";
            this.mnManagement.Size = new System.Drawing.Size(89, 26);
            this.mnManagement.Text = "Quản Lý";
            this.mnManagement.Click += new System.EventHandler(this.mnManagement_Click);
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.bànToolStripMenuItem.Text = "Bàn";
            // 
            // mnDish
            // 
            this.mnDish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDish.Name = "mnDish";
            this.mnDish.Size = new System.Drawing.Size(86, 26);
            this.mnDish.Text = "Món Ăn";
            this.mnDish.Click += new System.EventHandler(this.mnDish_Click);
            // 
            // mnOrder
            // 
            this.mnOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnOrder.Name = "mnOrder";
            this.mnOrder.Size = new System.Drawing.Size(93, 26);
            this.mnOrder.Text = "Gọi Món";
            this.mnOrder.Click += new System.EventHandler(this.mnOrder_Click);
            // 
            // mnStatistic
            // 
            this.mnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStatistic.Name = "mnStatistic";
            this.mnStatistic.Size = new System.Drawing.Size(99, 26);
            this.mnStatistic.Text = "Thống Kê";
            // 
            // mnLogout
            // 
            this.mnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(105, 26);
            this.mnLogout.Text = "Đăng Xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDiscount);
            this.tabControl1.Controls.Add(this.tabProfit);
            this.tabControl1.Controls.Add(this.tabDish);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // tabDiscount
            // 
            this.tabDiscount.Controls.Add(this.btnCancel);
            this.tabDiscount.Controls.Add(this.btnSave);
            this.tabDiscount.Controls.Add(this.btnDelete);
            this.tabDiscount.Controls.Add(this.btnEdit);
            this.tabDiscount.Controls.Add(this.btnAdd);
            this.tabDiscount.Controls.Add(this.gbDiscount);
            this.tabDiscount.Controls.Add(this.gvDiscount);
            this.tabDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDiscount.Location = new System.Drawing.Point(4, 31);
            this.tabDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Padding = new System.Windows.Forms.Padding(6);
            this.tabDiscount.Size = new System.Drawing.Size(1059, 492);
            this.tabDiscount.TabIndex = 0;
            this.tabDiscount.Text = "Giảm Giá";
            this.tabDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(72, 382);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(206, 382);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(140, 331);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 331);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 40);
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
            this.gbDiscount.Location = new System.Drawing.Point(18, 11);
            this.gbDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Padding = new System.Windows.Forms.Padding(6);
            this.gbDiscount.Size = new System.Drawing.Size(354, 296);
            this.gbDiscount.TabIndex = 1;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Giảm Giá";
            // 
            // nudPercent
            // 
            this.nudPercent.Location = new System.Drawing.Point(112, 87);
            this.nudPercent.Margin = new System.Windows.Forms.Padding(6);
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(118, 30);
            this.nudPercent.TabIndex = 2;
            // 
            // txtIDDis
            // 
            this.txtIDDis.Location = new System.Drawing.Point(112, 36);
            this.txtIDDis.Margin = new System.Windows.Forms.Padding(6);
            this.txtIDDis.Name = "txtIDDis";
            this.txtIDDis.ReadOnly = true;
            this.txtIDDis.Size = new System.Drawing.Size(118, 30);
            this.txtIDDis.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 22);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // dtFinish
            // 
            this.dtFinish.CustomFormat = "dd-MM-yyyy";
            this.dtFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinish.Location = new System.Drawing.Point(112, 240);
            this.dtFinish.Margin = new System.Windows.Forms.Padding(6);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(223, 30);
            this.dtFinish.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đến ngày";
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MM-yyyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtStart.Location = new System.Drawing.Point(112, 189);
            this.dtStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(223, 30);
            this.dtStart.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Từ ngày";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(112, 138);
            this.txtDiscription.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(223, 30);
            this.txtDiscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
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
            this.gvDiscount.Location = new System.Drawing.Point(384, 12);
            this.gvDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.ReadOnly = true;
            this.gvDiscount.Size = new System.Drawing.Size(612, 372);
            this.gvDiscount.TabIndex = 0;
            this.gvDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDiscount_CellClick);
            // 
            // ID_Dis
            // 
            this.ID_Dis.DataPropertyName = "ID_Dis";
            this.ID_Dis.HeaderText = "Mã giảm giá";
            this.ID_Dis.Name = "ID_Dis";
            this.ID_Dis.ReadOnly = true;
            this.ID_Dis.Width = 70;
            // 
            // per
            // 
            this.per.DataPropertyName = "Per";
            this.per.HeaderText = "Phần trăm";
            this.per.Name = "per";
            this.per.ReadOnly = true;
            this.per.Width = 70;
            // 
            // descript
            // 
            this.descript.DataPropertyName = "Descript";
            this.descript.HeaderText = "Mô tả";
            this.descript.Name = "descript";
            this.descript.ReadOnly = true;
            this.descript.Width = 140;
            // 
            // start
            // 
            this.start.DataPropertyName = "Start";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.start.DefaultCellStyle = dataGridViewCellStyle1;
            this.start.HeaderText = "Bắt đầu";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 110;
            // 
            // finish
            // 
            this.finish.DataPropertyName = "Finish";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy";
            dataGridViewCellStyle2.NullValue = "null";
            this.finish.DefaultCellStyle = dataGridViewCellStyle2;
            this.finish.HeaderText = "Kết thúc";
            this.finish.Name = "finish";
            this.finish.ReadOnly = true;
            this.finish.Width = 110;
            // 
            // sta
            // 
            this.sta.DataPropertyName = "Sta";
            this.sta.HeaderText = "Trạng thái";
            this.sta.Name = "sta";
            this.sta.ReadOnly = true;
            this.sta.Width = 70;
            // 
            // tabProfit
            // 
            this.tabProfit.Controls.Add(this.txtTotal);
            this.tabProfit.Controls.Add(this.label10);
            this.tabProfit.Controls.Add(this.label9);
            this.tabProfit.Controls.Add(this.btnDTSeen);
            this.tabProfit.Controls.Add(this.groupBox1);
            this.tabProfit.Controls.Add(this.gvProfit);
            this.tabProfit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfit.Location = new System.Drawing.Point(4, 31);
            this.tabProfit.Margin = new System.Windows.Forms.Padding(6);
            this.tabProfit.Name = "tabProfit";
            this.tabProfit.Size = new System.Drawing.Size(1059, 492);
            this.tabProfit.TabIndex = 2;
            this.tabProfit.Text = "Doanh thu";
            this.tabProfit.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(693, 417);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(270, 30);
            this.txtTotal.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Danh sách hóa đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 418);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tổng doanh thu";
            // 
            // btnDTSeen
            // 
            this.btnDTSeen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTSeen.Location = new System.Drawing.Point(109, 211);
            this.btnDTSeen.Margin = new System.Windows.Forms.Padding(6);
            this.btnDTSeen.Name = "btnDTSeen";
            this.btnDTSeen.Size = new System.Drawing.Size(110, 40);
            this.btnDTSeen.TabIndex = 2;
            this.btnDTSeen.Text = "Xem";
            this.btnDTSeen.UseVisualStyleBackColor = true;
            this.btnDTSeen.Click += new System.EventHandler(this.btnDTSeen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDTFinish);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtDTStart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(323, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh Thu";
            // 
            // dtDTFinish
            // 
            this.dtDTFinish.CustomFormat = "dd-MM-yyyy";
            this.dtDTFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDTFinish.Location = new System.Drawing.Point(100, 108);
            this.dtDTFinish.Margin = new System.Windows.Forms.Padding(6);
            this.dtDTFinish.Name = "dtDTFinish";
            this.dtDTFinish.Size = new System.Drawing.Size(189, 30);
            this.dtDTFinish.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đến ngày";
            // 
            // dtDTStart
            // 
            this.dtDTStart.CustomFormat = "dd-MM-yyyy";
            this.dtDTStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDTStart.Location = new System.Drawing.Point(98, 43);
            this.dtDTStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtDTStart.Name = "dtDTStart";
            this.dtDTStart.Size = new System.Drawing.Size(191, 30);
            this.dtDTStart.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Từ ngày";
            // 
            // gvProfit
            // 
            this.gvProfit.AllowUserToAddRows = false;
            this.gvProfit.AllowUserToDeleteRows = false;
            this.gvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Bill,
            this.ID_Table,
            this.Time_Arrive,
            this.Time_Payment,
            this.Percent,
            this.Total});
            this.gvProfit.Location = new System.Drawing.Point(360, 55);
            this.gvProfit.Margin = new System.Windows.Forms.Padding(6);
            this.gvProfit.Name = "gvProfit";
            this.gvProfit.ReadOnly = true;
            this.gvProfit.Size = new System.Drawing.Size(603, 357);
            this.gvProfit.TabIndex = 0;
            // 
            // ID_Bill
            // 
            this.ID_Bill.DataPropertyName = "ID_Bill";
            this.ID_Bill.HeaderText = "Mã hóa đơn";
            this.ID_Bill.Name = "ID_Bill";
            this.ID_Bill.ReadOnly = true;
            // 
            // ID_Table
            // 
            this.ID_Table.DataPropertyName = "ID_Table";
            this.ID_Table.HeaderText = "Bàn";
            this.ID_Table.Name = "ID_Table";
            this.ID_Table.ReadOnly = true;
            this.ID_Table.Width = 40;
            // 
            // Time_Arrive
            // 
            this.Time_Arrive.DataPropertyName = "Time_Arrive";
            dataGridViewCellStyle3.Format = "dd-MM-yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.Time_Arrive.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time_Arrive.HeaderText = "Check in";
            this.Time_Arrive.Name = "Time_Arrive";
            this.Time_Arrive.ReadOnly = true;
            this.Time_Arrive.Width = 125;
            // 
            // Time_Payment
            // 
            this.Time_Payment.DataPropertyName = "Time_Payment";
            dataGridViewCellStyle4.Format = "dd-MM-yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.Time_Payment.DefaultCellStyle = dataGridViewCellStyle4;
            this.Time_Payment.HeaderText = "Check out";
            this.Time_Payment.Name = "Time_Payment";
            this.Time_Payment.ReadOnly = true;
            this.Time_Payment.Width = 125;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Per";
            this.Percent.HeaderText = "Giảm giá";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 50;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total_price";
            this.Total.HeaderText = "Tổng tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // tabDish
            // 
            this.tabDish.Controls.Add(this.label11);
            this.tabDish.Controls.Add(this.txtTotalStatistic);
            this.tabDish.Controls.Add(this.btnSeen);
            this.tabDish.Controls.Add(this.gbTimePicker2);
            this.tabDish.Controls.Add(this.gvStatisticDish);
            this.tabDish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDish.Location = new System.Drawing.Point(4, 31);
            this.tabDish.Margin = new System.Windows.Forms.Padding(6);
            this.tabDish.Name = "tabDish";
            this.tabDish.Padding = new System.Windows.Forms.Padding(6);
            this.tabDish.Size = new System.Drawing.Size(1059, 492);
            this.tabDish.TabIndex = 1;
            this.tabDish.Text = "Món Ăn";
            this.tabDish.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(553, 421);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng doanh thu";
            // 
            // txtTotalStatistic
            // 
            this.txtTotalStatistic.Location = new System.Drawing.Point(724, 418);
            this.txtTotalStatistic.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalStatistic.Name = "txtTotalStatistic";
            this.txtTotalStatistic.ReadOnly = true;
            this.txtTotalStatistic.Size = new System.Drawing.Size(255, 30);
            this.txtTotalStatistic.TabIndex = 9;
            // 
            // btnSeen
            // 
            this.btnSeen.Location = new System.Drawing.Point(116, 211);
            this.btnSeen.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(110, 40);
            this.btnSeen.TabIndex = 7;
            this.btnSeen.Text = "Xem";
            this.btnSeen.UseVisualStyleBackColor = true;
            this.btnSeen.Click += new System.EventHandler(this.btnSeen_Click);
            // 
            // gbTimePicker2
            // 
            this.gbTimePicker2.Controls.Add(this.label3);
            this.gbTimePicker2.Controls.Add(this.dtStatisticFinish);
            this.gbTimePicker2.Controls.Add(this.dtStatisticStart);
            this.gbTimePicker2.Controls.Add(this.label4);
            this.gbTimePicker2.Location = new System.Drawing.Point(12, 12);
            this.gbTimePicker2.Margin = new System.Windows.Forms.Padding(6);
            this.gbTimePicker2.Name = "gbTimePicker2";
            this.gbTimePicker2.Padding = new System.Windows.Forms.Padding(6);
            this.gbTimePicker2.Size = new System.Drawing.Size(328, 187);
            this.gbTimePicker2.TabIndex = 6;
            this.gbTimePicker2.TabStop = false;
            this.gbTimePicker2.Text = "Thời Gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ Ngày";
            // 
            // dtStatisticFinish
            // 
            this.dtStatisticFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStatisticFinish.Location = new System.Drawing.Point(103, 94);
            this.dtStatisticFinish.Margin = new System.Windows.Forms.Padding(6);
            this.dtStatisticFinish.Name = "dtStatisticFinish";
            this.dtStatisticFinish.Size = new System.Drawing.Size(167, 30);
            this.dtStatisticFinish.TabIndex = 4;
            // 
            // dtStatisticStart
            // 
            this.dtStatisticStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStatisticStart.Location = new System.Drawing.Point(103, 40);
            this.dtStatisticStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtStatisticStart.Name = "dtStatisticStart";
            this.dtStatisticStart.Size = new System.Drawing.Size(167, 30);
            this.dtStatisticStart.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đến Ngày";
            // 
            // gvStatisticDish
            // 
            this.gvStatisticDish.AllowUserToAddRows = false;
            this.gvStatisticDish.AllowUserToDeleteRows = false;
            this.gvStatisticDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStatisticDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gvStatisticDish.Location = new System.Drawing.Point(352, 12);
            this.gvStatisticDish.Margin = new System.Windows.Forms.Padding(6);
            this.gvStatisticDish.Name = "gvStatisticDish";
            this.gvStatisticDish.ReadOnly = true;
            this.gvStatisticDish.Size = new System.Drawing.Size(627, 396);
            this.gvStatisticDish.TabIndex = 0;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "ID_Dish";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(945, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmStatistical";
            this.Text = "Quản lý nhà hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDiscount.ResumeLayout(false);
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).EndInit();
            this.tabProfit.ResumeLayout(false);
            this.tabProfit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProfit)).EndInit();
            this.tabDish.ResumeLayout(false);
            this.tabDish.PerformLayout();
            this.gbTimePicker2.ResumeLayout(false);
            this.gbTimePicker2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStatisticDish)).EndInit();
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
        private System.Windows.Forms.TabPage tabDish;
        private System.Windows.Forms.DataGridView gvDiscount;
        private System.Windows.Forms.GroupBox gbTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtStatisticFinish;
        private System.Windows.Forms.DateTimePicker dtStatisticStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvStatisticDish;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabProfit;
        private System.Windows.Forms.Button btnDTSeen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDTFinish;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDTStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gvProfit;
        private System.Windows.Forms.Button btnSeen;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalStatistic;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dis;
        private System.Windows.Forms.DataGridViewTextBoxColumn per;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn sta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Arrive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
    }
}