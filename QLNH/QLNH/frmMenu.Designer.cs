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
            this.btnDeleteCa = new System.Windows.Forms.Button();
            this.btnAddCa = new System.Windows.Forms.Button();
            this.txtCaName = new System.Windows.Forms.TextBox();
            this.lblCaName = new System.Windows.Forms.Label();
            this.txtCaId = new System.Windows.Forms.TextBox();
            this.lblCaID = new System.Windows.Forms.Label();
            this.datagrdviewCategories = new System.Windows.Forms.DataGridView();
            this.idCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioBtnStatusOff = new System.Windows.Forms.RadioButton();
            this.radioBtnStatusOn = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtFoodDes = new System.Windows.Forms.RichTextBox();
            this.lblFoodDes = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.numBoxFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFoodUnit = new System.Windows.Forms.TextBox();
            this.lblFoodUnit = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cobFoodCa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrdFood = new System.Windows.Forms.DataGridView();
            this.ID_Dish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblheadFood = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnFoodSearch = new System.Windows.Forms.Button();
            this.txtFoodSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.TagMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdviewCategories)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFoodPrice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 30);
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
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
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
            // 
            // TagMenu
            // 
            this.TagMenu.Controls.Add(this.tabPage1);
            this.TagMenu.Controls.Add(this.tabPage2);
            this.TagMenu.Location = new System.Drawing.Point(0, 31);
            this.TagMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TagMenu.Name = "TagMenu";
            this.TagMenu.SelectedIndex = 0;
            this.TagMenu.Size = new System.Drawing.Size(1077, 746);
            this.TagMenu.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteCa);
            this.tabPage1.Controls.Add(this.btnAddCa);
            this.tabPage1.Controls.Add(this.txtCaName);
            this.tabPage1.Controls.Add(this.lblCaName);
            this.tabPage1.Controls.Add(this.txtCaId);
            this.tabPage1.Controls.Add(this.lblCaID);
            this.tabPage1.Controls.Add(this.datagrdviewCategories);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1069, 717);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loại Món";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDeleteCa
            // 
            this.btnDeleteCa.Location = new System.Drawing.Point(780, 192);
            this.btnDeleteCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCa.Name = "btnDeleteCa";
            this.btnDeleteCa.Size = new System.Drawing.Size(140, 46);
            this.btnDeleteCa.TabIndex = 9;
            this.btnDeleteCa.Text = "Xóa";
            this.btnDeleteCa.UseVisualStyleBackColor = true;
            this.btnDeleteCa.Click += new System.EventHandler(this.btnDeleteCa_Click);
            // 
            // btnAddCa
            // 
            this.btnAddCa.Location = new System.Drawing.Point(620, 192);
            this.btnAddCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCa.Name = "btnAddCa";
            this.btnAddCa.Size = new System.Drawing.Size(140, 46);
            this.btnAddCa.TabIndex = 8;
            this.btnAddCa.Text = "Thêm mới";
            this.btnAddCa.UseVisualStyleBackColor = true;
            this.btnAddCa.Click += new System.EventHandler(this.btnAddCa_Click);
            // 
            // txtCaName
            // 
            this.txtCaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaName.Location = new System.Drawing.Point(556, 94);
            this.txtCaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaName.Name = "txtCaName";
            this.txtCaName.Size = new System.Drawing.Size(306, 26);
            this.txtCaName.TabIndex = 6;
            // 
            // lblCaName
            // 
            this.lblCaName.AutoSize = true;
            this.lblCaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaName.Location = new System.Drawing.Point(457, 94);
            this.lblCaName.Name = "lblCaName";
            this.lblCaName.Size = new System.Drawing.Size(88, 20);
            this.lblCaName.TabIndex = 5;
            this.lblCaName.Text = "Tên Loại:";
            // 
            // txtCaId
            // 
            this.txtCaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaId.Location = new System.Drawing.Point(556, 42);
            this.txtCaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaId.Name = "txtCaId";
            this.txtCaId.Size = new System.Drawing.Size(306, 26);
            this.txtCaId.TabIndex = 4;
            // 
            // lblCaID
            // 
            this.lblCaID.AutoSize = true;
            this.lblCaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaID.Location = new System.Drawing.Point(457, 42);
            this.lblCaID.Name = "lblCaID";
            this.lblCaID.Size = new System.Drawing.Size(82, 20);
            this.lblCaID.TabIndex = 3;
            this.lblCaID.Text = "Mã Loại:";
            // 
            // datagrdviewCategories
            // 
            this.datagrdviewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdviewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCa,
            this.caName});
            this.datagrdviewCategories.Location = new System.Drawing.Point(20, 42);
            this.datagrdviewCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrdviewCategories.Name = "datagrdviewCategories";
            this.datagrdviewCategories.RowTemplate.Height = 28;
            this.datagrdviewCategories.Size = new System.Drawing.Size(422, 562);
            this.datagrdviewCategories.TabIndex = 1;
            // 
            // idCa
            // 
            this.idCa.DataPropertyName = "ID_Ca";
            this.idCa.HeaderText = "Mã món";
            this.idCa.Name = "idCa";
            // 
            // caName
            // 
            this.caName.DataPropertyName = "name";
            this.caName.HeaderText = "Tên loại";
            this.caName.Name = "caName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1069, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Món Ăn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(452, 8);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Controls.Add(this.btnUpdateFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(452, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 601);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trạng thái";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.radioBtnStatusOff);
            this.panel10.Controls.Add(this.radioBtnStatusOn);
            this.panel10.Location = new System.Drawing.Point(19, 374);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(475, 66);
            this.panel10.TabIndex = 10;
            // 
            // radioBtnStatusOff
            // 
            this.radioBtnStatusOff.AutoSize = true;
            this.radioBtnStatusOff.Location = new System.Drawing.Point(296, 23);
            this.radioBtnStatusOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnStatusOff.Name = "radioBtnStatusOff";
            this.radioBtnStatusOff.Size = new System.Drawing.Size(165, 29);
            this.radioBtnStatusOff.TabIndex = 1;
            this.radioBtnStatusOff.TabStop = true;
            this.radioBtnStatusOff.Text = "Không phục vụ";
            this.radioBtnStatusOff.UseVisualStyleBackColor = true;
            // 
            // radioBtnStatusOn
            // 
            this.radioBtnStatusOn.AutoSize = true;
            this.radioBtnStatusOn.Location = new System.Drawing.Point(140, 23);
            this.radioBtnStatusOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnStatusOn.Name = "radioBtnStatusOn";
            this.radioBtnStatusOn.Size = new System.Drawing.Size(104, 29);
            this.radioBtnStatusOn.TabIndex = 0;
            this.radioBtnStatusOn.TabStop = true;
            this.radioBtnStatusOn.Text = "Phục vụ";
            this.radioBtnStatusOn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(403, 466);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(91, 44);
            this.btnDeleteFood.TabIndex = 7;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(267, 466);
            this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(91, 44);
            this.btnUpdateFood.TabIndex = 5;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(55, 466);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(174, 44);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtFoodDes);
            this.panel9.Controls.Add(this.lblFoodDes);
            this.panel9.Location = new System.Drawing.Point(19, 240);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(475, 106);
            this.panel9.TabIndex = 3;
            // 
            // txtFoodDes
            // 
            this.txtFoodDes.Location = new System.Drawing.Point(140, 12);
            this.txtFoodDes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodDes.Name = "txtFoodDes";
            this.txtFoodDes.Size = new System.Drawing.Size(269, 78);
            this.txtFoodDes.TabIndex = 4;
            this.txtFoodDes.Text = "";
            // 
            // lblFoodDes
            // 
            this.lblFoodDes.AutoSize = true;
            this.lblFoodDes.Location = new System.Drawing.Point(44, 12);
            this.lblFoodDes.Name = "lblFoodDes";
            this.lblFoodDes.Size = new System.Drawing.Size(67, 25);
            this.lblFoodDes.TabIndex = 3;
            this.lblFoodDes.Text = "Mô tả:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.numBoxFoodPrice);
            this.panel8.Controls.Add(this.lblFoodPrice);
            this.panel8.Location = new System.Drawing.Point(19, 190);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(475, 38);
            this.panel8.TabIndex = 3;
            // 
            // numBoxFoodPrice
            // 
            this.numBoxFoodPrice.Location = new System.Drawing.Point(147, 7);
            this.numBoxFoodPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBoxFoodPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBoxFoodPrice.Name = "numBoxFoodPrice";
            this.numBoxFoodPrice.Size = new System.Drawing.Size(261, 30);
            this.numBoxFoodPrice.TabIndex = 5;
            this.numBoxFoodPrice.ValueChanged += new System.EventHandler(this.numBoxFoodPrice_ValueChanged);
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(56, 13);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(53, 25);
            this.lblFoodPrice.TabIndex = 0;
            this.lblFoodPrice.Text = "Giá: ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtFoodUnit);
            this.panel7.Controls.Add(this.lblFoodUnit);
            this.panel7.Location = new System.Drawing.Point(19, 138);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(475, 38);
            this.panel7.TabIndex = 3;
            // 
            // txtFoodUnit
            // 
            this.txtFoodUnit.Location = new System.Drawing.Point(147, 2);
            this.txtFoodUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodUnit.Name = "txtFoodUnit";
            this.txtFoodUnit.Size = new System.Drawing.Size(262, 30);
            this.txtFoodUnit.TabIndex = 1;
            // 
            // lblFoodUnit
            // 
            this.lblFoodUnit.AutoSize = true;
            this.lblFoodUnit.Location = new System.Drawing.Point(47, 10);
            this.lblFoodUnit.Name = "lblFoodUnit";
            this.lblFoodUnit.Size = new System.Drawing.Size(73, 25);
            this.lblFoodUnit.TabIndex = 0;
            this.lblFoodUnit.Text = "Đơn vị:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtFoodName);
            this.panel6.Controls.Add(this.lblFoodName);
            this.panel6.Location = new System.Drawing.Point(19, 87);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 38);
            this.panel6.TabIndex = 3;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(148, 7);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(262, 30);
            this.txtFoodName.TabIndex = 2;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(12, 13);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(123, 25);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Tên món ăn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cobFoodCa);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(19, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 38);
            this.panel5.TabIndex = 3;
            // 
            // cobFoodCa
            // 
            this.cobFoodCa.FormattingEnabled = true;
            this.cobFoodCa.Location = new System.Drawing.Point(148, 2);
            this.cobFoodCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cobFoodCa.Name = "cobFoodCa";
            this.cobFoodCa.Size = new System.Drawing.Size(262, 33);
            this.cobFoodCa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại món:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFoodID);
            this.panel4.Controls.Add(this.lblFoodID);
            this.panel4.Location = new System.Drawing.Point(19, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 38);
            this.panel4.TabIndex = 2;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(148, 2);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(262, 30);
            this.txtFoodID.TabIndex = 1;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(36, 10);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(89, 25);
            this.lblFoodID.TabIndex = 0;
            this.lblFoodID.Text = "Mã món:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagrdFood);
            this.panel2.Controls.Add(this.lblheadFood);
            this.panel2.Location = new System.Drawing.Point(10, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 601);
            this.panel2.TabIndex = 3;
            // 
            // datagrdFood
            // 
            this.datagrdFood.AllowUserToAddRows = false;
            this.datagrdFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Dish,
            this.ID_Ca,
            this.name,
            this.unit,
            this.price,
            this.descript});
            this.datagrdFood.Location = new System.Drawing.Point(4, 37);
            this.datagrdFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagrdFood.Name = "datagrdFood";
            this.datagrdFood.RowTemplate.Height = 28;
            this.datagrdFood.Size = new System.Drawing.Size(422, 562);
            this.datagrdFood.TabIndex = 1;
            // 
            // ID_Dish
            // 
            this.ID_Dish.DataPropertyName = "ID_Dish";
            this.ID_Dish.HeaderText = "Mã món";
            this.ID_Dish.Name = "ID_Dish";
            // 
            // ID_Ca
            // 
            this.ID_Ca.DataPropertyName = "ID_Ca";
            this.ID_Ca.HeaderText = "Mã loại";
            this.ID_Ca.Name = "ID_Ca";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên món";
            this.name.Name = "name";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // descript
            // 
            this.descript.DataPropertyName = "descript";
            this.descript.HeaderText = "Mô tả";
            this.descript.Name = "descript";
            // 
            // lblheadFood
            // 
            this.lblheadFood.AutoSize = true;
            this.lblheadFood.Location = new System.Drawing.Point(42, 0);
            this.lblheadFood.Name = "lblheadFood";
            this.lblheadFood.Size = new System.Drawing.Size(78, 25);
            this.lblheadFood.TabIndex = 0;
            this.lblheadFood.Text = "Món ăn";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnFoodSearch);
            this.panel11.Controls.Add(this.txtFoodSearch);
            this.panel11.Location = new System.Drawing.Point(7, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(428, 50);
            this.panel11.TabIndex = 4;
            // 
            // btnFoodSearch
            // 
            this.btnFoodSearch.Location = new System.Drawing.Point(300, 10);
            this.btnFoodSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFoodSearch.Name = "btnFoodSearch";
            this.btnFoodSearch.Size = new System.Drawing.Size(87, 30);
            this.btnFoodSearch.TabIndex = 2;
            this.btnFoodSearch.Text = "Tìm kiếm";
            this.btnFoodSearch.UseVisualStyleBackColor = true;
            this.btnFoodSearch.Click += new System.EventHandler(this.btnFoodSearch_Click);
            // 
            // txtFoodSearch
            // 
            this.txtFoodSearch.Location = new System.Drawing.Point(3, 14);
            this.txtFoodSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodSearch.Name = "txtFoodSearch";
            this.txtFoodSearch.Size = new System.Drawing.Size(262, 30);
            this.txtFoodSearch.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 774);
            this.Controls.Add(this.TagMenu);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Quản lý nhà hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TagMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdviewCategories)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxFoodPrice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.Button btnDeleteCa;
        private System.Windows.Forms.Button btnAddCa;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RichTextBox txtFoodDes;
        private System.Windows.Forms.Label lblFoodDes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numBoxFoodPrice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFoodUnit;
        private System.Windows.Forms.Label lblFoodUnit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cobFoodCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn descript;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn caName;
        private System.Windows.Forms.Button btnReset;
    }
}