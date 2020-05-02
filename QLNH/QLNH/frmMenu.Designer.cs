namespace QLNH
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.TagMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSaveCa = new System.Windows.Forms.Button();
            this.btnCancleCa = new System.Windows.Forms.Button();
            this.btnEditCa = new System.Windows.Forms.Button();
            this.btnDeleteCa = new System.Windows.Forms.Button();
            this.btnAddCa = new System.Windows.Forms.Button();
            this.txtCaId = new System.Windows.Forms.TextBox();
            this.lblCaID = new System.Windows.Forms.Label();
            this.txtCaName = new System.Windows.Forms.TextBox();
            this.lblCaName = new System.Windows.Forms.Label();
            this.datagrdviewCategories = new System.Windows.Forms.DataGridView();
            this.idCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.cobFoodCa = new System.Windows.Forms.ComboBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodUnit = new System.Windows.Forms.Label();
            this.numBoxFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.txtFoodDes = new System.Windows.Forms.RichTextBox();
            this.txtFoodUnit = new System.Windows.Forms.TextBox();
            this.lblFoodDes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioBtnStatusOff = new System.Windows.Forms.RadioButton();
            this.radioBtnStatusOn = new System.Windows.Forms.RadioButton();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrdFood = new System.Windows.Forms.DataGridView();
            this.ID_Dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblheadFood = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnFoodSearch = new System.Windows.Forms.Button();
            this.txtFoodSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TagMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdviewCategories)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFoodPrice)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdFood)).BeginInit();
            this.panel11.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManagement
            // 
            this.mnManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànToolStripMenuItem});
            this.mnManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnManagement.Name = "mnManagement";
            this.mnManagement.Size = new System.Drawing.Size(89, 26);
            this.mnManagement.Text = "Quản lý ";
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
            this.mnDish.Size = new System.Drawing.Size(81, 26);
            this.mnDish.Text = "Món ăn";
            // 
            // mnOrder
            // 
            this.mnOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnOrder.Name = "mnOrder";
            this.mnOrder.Size = new System.Drawing.Size(90, 26);
            this.mnOrder.Text = "Gọi món";
            this.mnOrder.Click += new System.EventHandler(this.mnOrder_Click);
            // 
            // mnStatistic
            // 
            this.mnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStatistic.Name = "mnStatistic";
            this.mnStatistic.Size = new System.Drawing.Size(94, 26);
            this.mnStatistic.Text = "Thống kê";
            this.mnStatistic.Click += new System.EventHandler(this.mnStatistic_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(100, 26);
            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // TagMenu
            // 
            this.TagMenu.Controls.Add(this.tabPage1);
            this.TagMenu.Controls.Add(this.tabPage2);
            this.TagMenu.Location = new System.Drawing.Point(7, 35);
            this.TagMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TagMenu.Name = "TagMenu";
            this.TagMenu.SelectedIndex = 0;
            this.TagMenu.Size = new System.Drawing.Size(1060, 537);
            this.TagMenu.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtpage);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.btnPrevious);
            this.tabPage1.Controls.Add(this.btnLast);
            this.tabPage1.Controls.Add(this.btnFirst);
            this.tabPage1.Controls.Add(this.panel12);
            this.tabPage1.Controls.Add(this.datagrdviewCategories);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loại Món";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(222, 430);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(79, 30);
            this.txtpage.TabIndex = 16;
            this.txtpage.Text = "1";
            this.txtpage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpage.TextChanged += new System.EventHandler(this.txtpage_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(386, 430);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 37);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(113, 430);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(52, 37);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(441, 430);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(73, 37);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(21, 430);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(86, 37);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "Trước";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.btnSaveCa);
            this.panel12.Controls.Add(this.btnCancleCa);
            this.panel12.Controls.Add(this.btnEditCa);
            this.panel12.Controls.Add(this.btnDeleteCa);
            this.panel12.Controls.Add(this.btnAddCa);
            this.panel12.Controls.Add(this.txtCaId);
            this.panel12.Controls.Add(this.lblCaID);
            this.panel12.Controls.Add(this.txtCaName);
            this.panel12.Controls.Add(this.lblCaName);
            this.panel12.Location = new System.Drawing.Point(536, 27);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(419, 378);
            this.panel12.TabIndex = 11;
            // 
            // btnSaveCa
            // 
            this.btnSaveCa.Enabled = false;
            this.btnSaveCa.Location = new System.Drawing.Point(218, 199);
            this.btnSaveCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveCa.Name = "btnSaveCa";
            this.btnSaveCa.Size = new System.Drawing.Size(110, 40);
            this.btnSaveCa.TabIndex = 12;
            this.btnSaveCa.Text = "Lưu";
            this.btnSaveCa.UseVisualStyleBackColor = true;
            this.btnSaveCa.Click += new System.EventHandler(this.btnSaveCa_Click);
            // 
            // btnCancleCa
            // 
            this.btnCancleCa.Enabled = false;
            this.btnCancleCa.Location = new System.Drawing.Point(82, 199);
            this.btnCancleCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancleCa.Name = "btnCancleCa";
            this.btnCancleCa.Size = new System.Drawing.Size(110, 40);
            this.btnCancleCa.TabIndex = 11;
            this.btnCancleCa.Text = "Hủy";
            this.btnCancleCa.UseVisualStyleBackColor = true;
            this.btnCancleCa.Click += new System.EventHandler(this.btnCancleCa_Click);
            // 
            // btnEditCa
            // 
            this.btnEditCa.Location = new System.Drawing.Point(155, 141);
            this.btnEditCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditCa.Name = "btnEditCa";
            this.btnEditCa.Size = new System.Drawing.Size(110, 40);
            this.btnEditCa.TabIndex = 10;
            this.btnEditCa.Text = "Sửa";
            this.btnEditCa.UseVisualStyleBackColor = true;
            this.btnEditCa.Click += new System.EventHandler(this.btnEditCa_Click);
            // 
            // btnDeleteCa
            // 
            this.btnDeleteCa.Location = new System.Drawing.Point(282, 141);
            this.btnDeleteCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCa.Name = "btnDeleteCa";
            this.btnDeleteCa.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteCa.TabIndex = 9;
            this.btnDeleteCa.Text = "Xóa";
            this.btnDeleteCa.UseVisualStyleBackColor = true;
            this.btnDeleteCa.Click += new System.EventHandler(this.btnDeleteCa_Click);
            // 
            // btnAddCa
            // 
            this.btnAddCa.Location = new System.Drawing.Point(28, 141);
            this.btnAddCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddCa.Name = "btnAddCa";
            this.btnAddCa.Size = new System.Drawing.Size(110, 40);
            this.btnAddCa.TabIndex = 8;
            this.btnAddCa.Text = "Thêm";
            this.btnAddCa.UseVisualStyleBackColor = true;
            this.btnAddCa.Click += new System.EventHandler(this.btnAddCa_Click);
            // 
            // txtCaId
            // 
            this.txtCaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaId.Location = new System.Drawing.Point(148, 34);
            this.txtCaId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCaId.Name = "txtCaId";
            this.txtCaId.ReadOnly = true;
            this.txtCaId.Size = new System.Drawing.Size(245, 26);
            this.txtCaId.TabIndex = 4;
            // 
            // lblCaID
            // 
            this.lblCaID.AutoSize = true;
            this.lblCaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaID.Location = new System.Drawing.Point(12, 34);
            this.lblCaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaID.Name = "lblCaID";
            this.lblCaID.Size = new System.Drawing.Size(82, 20);
            this.lblCaID.TabIndex = 3;
            this.lblCaID.Text = "Mã Loại:";
            // 
            // txtCaName
            // 
            this.txtCaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaName.Location = new System.Drawing.Point(148, 83);
            this.txtCaName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCaName.Name = "txtCaName";
            this.txtCaName.Size = new System.Drawing.Size(245, 26);
            this.txtCaName.TabIndex = 6;
            // 
            // lblCaName
            // 
            this.lblCaName.AutoSize = true;
            this.lblCaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaName.Location = new System.Drawing.Point(12, 89);
            this.lblCaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaName.Name = "lblCaName";
            this.lblCaName.Size = new System.Drawing.Size(88, 20);
            this.lblCaName.TabIndex = 5;
            this.lblCaName.Text = "Tên Loại:";
            // 
            // datagrdviewCategories
            // 
            this.datagrdviewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdviewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCa,
            this.caName});
            this.datagrdviewCategories.Location = new System.Drawing.Point(21, 27);
            this.datagrdviewCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datagrdviewCategories.Name = "datagrdviewCategories";
            this.datagrdviewCategories.RowTemplate.Height = 28;
            this.datagrdviewCategories.Size = new System.Drawing.Size(493, 378);
            this.datagrdviewCategories.TabIndex = 1;
            // 
            // idCa
            // 
            this.idCa.DataPropertyName = "ID_Ca";
            this.idCa.HeaderText = "Mã loại";
            this.idCa.Name = "idCa";
            this.idCa.Width = 200;
            // 
            // caName
            // 
            this.caName.DataPropertyName = "name";
            this.caName.HeaderText = "Tên loại";
            this.caName.Name = "caName";
            this.caName.Width = 250;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món Ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.lblFoodID);
            this.panel3.Controls.Add(this.txtFoodID);
            this.panel3.Controls.Add(this.cobFoodCa);
            this.panel3.Controls.Add(this.lblFoodName);
            this.panel3.Controls.Add(this.txtFoodName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblFoodPrice);
            this.panel3.Controls.Add(this.lblFoodUnit);
            this.panel3.Controls.Add(this.numBoxFoodPrice);
            this.panel3.Controls.Add(this.txtFoodDes);
            this.panel3.Controls.Add(this.txtFoodUnit);
            this.panel3.Controls.Add(this.lblFoodDes);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.btnUpdateFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Location = new System.Drawing.Point(650, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 471);
            this.panel3.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(84, 418);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(215, 418);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodID.Location = new System.Drawing.Point(15, 17);
            this.lblFoodID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(76, 21);
            this.lblFoodID.TabIndex = 0;
            this.lblFoodID.Text = "Mã món:";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(122, 8);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(130, 30);
            this.txtFoodID.TabIndex = 1;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // cobFoodCa
            // 
            this.cobFoodCa.FormattingEnabled = true;
            this.cobFoodCa.Location = new System.Drawing.Point(122, 52);
            this.cobFoodCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cobFoodCa.Name = "cobFoodCa";
            this.cobFoodCa.Size = new System.Drawing.Size(242, 33);
            this.cobFoodCa.TabIndex = 8;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(15, 112);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(103, 21);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Tên món ăn:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(122, 99);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(248, 30);
            this.txtFoodName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại món:";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(15, 203);
            this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(50, 22);
            this.lblFoodPrice.TabIndex = 0;
            this.lblFoodPrice.Text = "Giá: ";
            // 
            // lblFoodUnit
            // 
            this.lblFoodUnit.AutoSize = true;
            this.lblFoodUnit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodUnit.Location = new System.Drawing.Point(15, 158);
            this.lblFoodUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodUnit.Name = "lblFoodUnit";
            this.lblFoodUnit.Size = new System.Drawing.Size(65, 21);
            this.lblFoodUnit.TabIndex = 0;
            this.lblFoodUnit.Text = "Đơn vị:";
            // 
            // numBoxFoodPrice
            // 
            this.numBoxFoodPrice.Location = new System.Drawing.Point(122, 187);
            this.numBoxFoodPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numBoxFoodPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBoxFoodPrice.Name = "numBoxFoodPrice";
            this.numBoxFoodPrice.Size = new System.Drawing.Size(168, 30);
            this.numBoxFoodPrice.TabIndex = 5;
            this.numBoxFoodPrice.ValueChanged += new System.EventHandler(this.numBoxFoodPrice_ValueChanged);
            // 
            // txtFoodDes
            // 
            this.txtFoodDes.Location = new System.Drawing.Point(122, 231);
            this.txtFoodDes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodDes.Name = "txtFoodDes";
            this.txtFoodDes.Size = new System.Drawing.Size(250, 60);
            this.txtFoodDes.TabIndex = 4;
            this.txtFoodDes.Text = "";
            // 
            // txtFoodUnit
            // 
            this.txtFoodUnit.Location = new System.Drawing.Point(122, 143);
            this.txtFoodUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodUnit.Name = "txtFoodUnit";
            this.txtFoodUnit.Size = new System.Drawing.Size(168, 30);
            this.txtFoodUnit.TabIndex = 1;
            // 
            // lblFoodDes
            // 
            this.lblFoodDes.AutoSize = true;
            this.lblFoodDes.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodDes.Location = new System.Drawing.Point(15, 241);
            this.lblFoodDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodDes.Name = "lblFoodDes";
            this.lblFoodDes.Size = new System.Drawing.Size(58, 21);
            this.lblFoodDes.TabIndex = 3;
            this.lblFoodDes.Text = "Mô tả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trạng thái";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(151, 363);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteFood.TabIndex = 7;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.radioBtnStatusOff);
            this.panel10.Controls.Add(this.radioBtnStatusOn);
            this.panel10.Location = new System.Drawing.Point(122, 307);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(271, 36);
            this.panel10.TabIndex = 10;
            // 
            // radioBtnStatusOff
            // 
            this.radioBtnStatusOff.AutoSize = true;
            this.radioBtnStatusOff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStatusOff.Location = new System.Drawing.Point(111, 2);
            this.radioBtnStatusOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnStatusOff.Name = "radioBtnStatusOff";
            this.radioBtnStatusOff.Size = new System.Drawing.Size(148, 26);
            this.radioBtnStatusOff.TabIndex = 1;
            this.radioBtnStatusOff.TabStop = true;
            this.radioBtnStatusOff.Text = "Không phục vụ";
            this.radioBtnStatusOff.UseVisualStyleBackColor = true;
            // 
            // radioBtnStatusOn
            // 
            this.radioBtnStatusOn.AutoSize = true;
            this.radioBtnStatusOn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStatusOn.Location = new System.Drawing.Point(4, 3);
            this.radioBtnStatusOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBtnStatusOn.Name = "radioBtnStatusOn";
            this.radioBtnStatusOn.Size = new System.Drawing.Size(93, 26);
            this.radioBtnStatusOn.TabIndex = 0;
            this.radioBtnStatusOn.TabStop = true;
            this.radioBtnStatusOn.Text = "Phục vụ";
            this.radioBtnStatusOn.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.Location = new System.Drawing.Point(283, 363);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateFood.TabIndex = 5;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(19, 363);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(110, 40);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(526, 16);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 40);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagrdFood);
            this.panel2.Controls.Add(this.lblheadFood);
            this.panel2.Location = new System.Drawing.Point(8, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 426);
            this.panel2.TabIndex = 3;
            // 
            // datagrdFood
            // 
            this.datagrdFood.AllowUserToAddRows = false;
            this.datagrdFood.AllowUserToDeleteRows = false;
            this.datagrdFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Dish,
            this.name,
            this.unit,
            this.price,
            this.descript,
            this.Sta});
            this.datagrdFood.Location = new System.Drawing.Point(4, 25);
            this.datagrdFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datagrdFood.Name = "datagrdFood";
            this.datagrdFood.ReadOnly = true;
            this.datagrdFood.RowTemplate.Height = 28;
            this.datagrdFood.Size = new System.Drawing.Size(624, 380);
            this.datagrdFood.TabIndex = 1;
            this.datagrdFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdFood_CellClick);
            // 
            // ID_Dish
            // 
            this.ID_Dish.DataPropertyName = "ID_Dish";
            this.ID_Dish.HeaderText = "Mã món";
            this.ID_Dish.Name = "ID_Dish";
            this.ID_Dish.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên món";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // descript
            // 
            this.descript.DataPropertyName = "descript";
            this.descript.HeaderText = "Mô tả";
            this.descript.Name = "descript";
            this.descript.ReadOnly = true;
            // 
            // Sta
            // 
            this.Sta.DataPropertyName = "sta";
            this.Sta.HeaderText = "Trạng Thái";
            this.Sta.Name = "Sta";
            this.Sta.ReadOnly = true;
            // 
            // lblheadFood
            // 
            this.lblheadFood.AutoSize = true;
            this.lblheadFood.Location = new System.Drawing.Point(6, -3);
            this.lblheadFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheadFood.Name = "lblheadFood";
            this.lblheadFood.Size = new System.Drawing.Size(78, 25);
            this.lblheadFood.TabIndex = 0;
            this.lblheadFood.Text = "Món ăn";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnFoodSearch);
            this.panel11.Controls.Add(this.txtFoodSearch);
            this.panel11.Location = new System.Drawing.Point(10, 7);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(464, 52);
            this.panel11.TabIndex = 4;
            // 
            // btnFoodSearch
            // 
            this.btnFoodSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodSearch.Location = new System.Drawing.Point(322, 8);
            this.btnFoodSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFoodSearch.Name = "btnFoodSearch";
            this.btnFoodSearch.Size = new System.Drawing.Size(97, 35);
            this.btnFoodSearch.TabIndex = 2;
            this.btnFoodSearch.Text = "Tìm kiếm";
            this.btnFoodSearch.UseVisualStyleBackColor = true;
            this.btnFoodSearch.Click += new System.EventHandler(this.btnFoodSearch_Click);
            // 
            // txtFoodSearch
            // 
            this.txtFoodSearch.Location = new System.Drawing.Point(9, 8);
            this.txtFoodSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFoodSearch.Name = "txtFoodSearch";
            this.txtFoodSearch.Size = new System.Drawing.Size(287, 30);
            this.txtFoodSearch.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(946, 575);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.TagMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMenu";
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TagMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdviewCategories)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFoodPrice)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdFood)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManagement;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnDish;
        private System.Windows.Forms.ToolStripMenuItem mnOrder;
        private System.Windows.Forms.ToolStripMenuItem mnStatistic;
        private System.Windows.Forms.TabControl TagMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCaName;
        private System.Windows.Forms.Label lblCaName;
        private System.Windows.Forms.TextBox txtCaId;
        private System.Windows.Forms.Label lblCaID;
        private System.Windows.Forms.DataGridView datagrdviewCategories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioBtnStatusOff;
        private System.Windows.Forms.RadioButton radioBtnStatusOn;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.RichTextBox txtFoodDes;
        private System.Windows.Forms.Label lblFoodDes;
        private System.Windows.Forms.NumericUpDown numBoxFoodPrice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.TextBox txtFoodUnit;
        private System.Windows.Forms.Label lblFoodUnit;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.ComboBox cobFoodCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagrdFood;
        private System.Windows.Forms.Label lblheadFood;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnFoodSearch;
        private System.Windows.Forms.TextBox txtFoodSearch;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnAddCa;
        private System.Windows.Forms.Button btnDeleteCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn caName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sta;
        private System.Windows.Forms.Button btnSaveCa;
        private System.Windows.Forms.Button btnCancleCa;
        private System.Windows.Forms.Button btnEditCa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}