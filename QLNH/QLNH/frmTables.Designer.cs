namespace QLNH
{
    partial class frmTables
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
            this.mnDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTable = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.grpListTable = new System.Windows.Forms.GroupBox();
            this.dtGridTable = new System.Windows.Forms.DataGridView();
            this.ID_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.numCapa = new System.Windows.Forms.NumericUpDown();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtIDTable = new System.Windows.Forms.TextBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.labCapability = new System.Windows.Forms.Label();
            this.labPosition = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.tabPagePosition = new System.Windows.Forms.TabPage();
            this.grpListPos = new System.Windows.Forms.GroupBox();
            this.scrollPosition = new System.Windows.Forms.VScrollBar();
            this.dtGridPosition = new System.Windows.Forms.DataGridView();
            this.ID_Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePos = new System.Windows.Forms.Button();
            this.btnCanl = new System.Windows.Forms.Button();
            this.btnDeletePos = new System.Windows.Forms.Button();
            this.btnEditPos = new System.Windows.Forms.Button();
            this.btnAddPos = new System.Windows.Forms.Button();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.txtStatusPos = new System.Windows.Forms.TextBox();
            this.txtNotePos = new System.Windows.Forms.TextBox();
            this.txtNamePos = new System.Windows.Forms.TextBox();
            this.txtIDPos = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbNamePos = new System.Windows.Forms.Label();
            this.lbIDPosition = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.grpListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapa)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.tabPagePosition.SuspendLayout();
            this.grpListPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPosition)).BeginInit();
            this.grpPosition.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManagement
            // 
            this.mnManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnManagement.Name = "mnManagement";
            this.mnManagement.Size = new System.Drawing.Size(89, 26);
            this.mnManagement.Text = "Quản lý ";
            // 
            // mnDish
            // 
            this.mnDish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnDish.Name = "mnDish";
            this.mnDish.Size = new System.Drawing.Size(81, 26);
            this.mnDish.Text = "Món ăn";
            this.mnDish.Click += new System.EventHandler(this.mnDish_Click);
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
            this.mnLogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(98, 26);
            this.mnLogout.Text = "Đăng xuất";
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.tabPageTable);
            this.tabTable.Controls.Add(this.tabPagePosition);
            this.tabTable.Controls.Add(this.tabPage1);
            this.tabTable.Controls.Add(this.tabPage4);
            this.tabTable.Controls.Add(this.tabPage5);
            this.tabTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTable.Location = new System.Drawing.Point(0, 33);
            this.tabTable.Name = "tabTable";
            this.tabTable.SelectedIndex = 0;
            this.tabTable.Size = new System.Drawing.Size(1077, 525);
            this.tabTable.TabIndex = 1;
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.grpListTable);
            this.tabPageTable.Controls.Add(this.btnSave);
            this.tabPageTable.Controls.Add(this.btnCancel);
            this.tabPageTable.Controls.Add(this.btnDelete);
            this.tabPageTable.Controls.Add(this.btnEdit);
            this.tabPageTable.Controls.Add(this.btnAdd);
            this.tabPageTable.Controls.Add(this.grpInfo);
            this.tabPageTable.Location = new System.Drawing.Point(4, 31);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(1069, 490);
            this.tabPageTable.TabIndex = 0;
            this.tabPageTable.Text = "Bàn";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // grpListTable
            // 
            this.grpListTable.Controls.Add(this.dtGridTable);
            this.grpListTable.Location = new System.Drawing.Point(483, 36);
            this.grpListTable.Name = "grpListTable";
            this.grpListTable.Size = new System.Drawing.Size(548, 440);
            this.grpListTable.TabIndex = 6;
            this.grpListTable.TabStop = false;
            this.grpListTable.Text = "Danh sách bàn";
            // 
            // dtGridTable
            // 
            this.dtGridTable.AllowUserToAddRows = false;
            this.dtGridTable.AllowUserToDeleteRows = false;
            this.dtGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Table,
            this.PositionTable,
            this.Capability,
            this.Column1});
            this.dtGridTable.Location = new System.Drawing.Point(29, 29);
            this.dtGridTable.Name = "dtGridTable";
            this.dtGridTable.ReadOnly = true;
            this.dtGridTable.RowTemplate.Height = 24;
            this.dtGridTable.Size = new System.Drawing.Size(498, 389);
            this.dtGridTable.TabIndex = 0;
            this.dtGridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridTable_CellClick);
            // 
            // ID_Table
            // 
            this.ID_Table.DataPropertyName = "ID_Table";
            this.ID_Table.HeaderText = "ID Bàn";
            this.ID_Table.Name = "ID_Table";
            this.ID_Table.ReadOnly = true;
            // 
            // PositionTable
            // 
            this.PositionTable.DataPropertyName = "ID_Pos";
            this.PositionTable.HeaderText = "ID Khu Vực";
            this.PositionTable.Name = "PositionTable";
            this.PositionTable.ReadOnly = true;
            this.PositionTable.Width = 120;
            // 
            // Capability
            // 
            this.Capability.DataPropertyName = "Capa";
            this.Capability.HeaderText = "Cơ Cấu";
            this.Capability.Name = "Capability";
            this.Capability.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sta";
            this.Column1.HeaderText = "Trạng Thái";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(345, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(191, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.numCapa);
            this.grpInfo.Controls.Add(this.panelStatus);
            this.grpInfo.Controls.Add(this.cbPosition);
            this.grpInfo.Controls.Add(this.txtIDTable);
            this.grpInfo.Controls.Add(this.labStatus);
            this.grpInfo.Controls.Add(this.labCapability);
            this.grpInfo.Controls.Add(this.labPosition);
            this.grpInfo.Controls.Add(this.labID);
            this.grpInfo.Location = new System.Drawing.Point(29, 36);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(437, 205);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin bàn";
            // 
            // numCapa
            // 
            this.numCapa.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCapa.Location = new System.Drawing.Point(146, 110);
            this.numCapa.Name = "numCapa";
            this.numCapa.Size = new System.Drawing.Size(219, 30);
            this.numCapa.TabIndex = 17;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.radYes);
            this.panelStatus.Controls.Add(this.radNo);
            this.panelStatus.Location = new System.Drawing.Point(146, 146);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(219, 42);
            this.panelStatus.TabIndex = 16;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(111, 6);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(105, 26);
            this.radYes.TabIndex = 13;
            this.radYes.Text = "Có người";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Location = new System.Drawing.Point(16, 6);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(77, 26);
            this.radNo.TabIndex = 14;
            this.radNo.TabStop = true;
            this.radNo.Text = "Trống";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            this.cbPosition.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(146, 74);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(219, 30);
            this.cbPosition.TabIndex = 9;
            // 
            // txtIDTable
            // 
            this.txtIDTable.Enabled = false;
            this.txtIDTable.Location = new System.Drawing.Point(146, 38);
            this.txtIDTable.Name = "txtIDTable";
            this.txtIDTable.Size = new System.Drawing.Size(219, 30);
            this.txtIDTable.TabIndex = 6;
            this.txtIDTable.TextChanged += new System.EventHandler(this.txtIDTable_TextChanged);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(27, 152);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(96, 22);
            this.labStatus.TabIndex = 4;
            this.labStatus.Text = "Trạng Thái";
            // 
            // labCapability
            // 
            this.labCapability.AutoSize = true;
            this.labCapability.Location = new System.Drawing.Point(27, 112);
            this.labCapability.Name = "labCapability";
            this.labCapability.Size = new System.Drawing.Size(84, 22);
            this.labCapability.TabIndex = 3;
            this.labCapability.Text = "Sức chứa";
            // 
            // labPosition
            // 
            this.labPosition.AutoSize = true;
            this.labPosition.Location = new System.Drawing.Point(27, 77);
            this.labPosition.Name = "labPosition";
            this.labPosition.Size = new System.Drawing.Size(80, 22);
            this.labPosition.TabIndex = 1;
            this.labPosition.Text = "Khu Vực";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(27, 41);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(66, 22);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID Bàn";
            // 
            // tabPagePosition
            // 
            this.tabPagePosition.Controls.Add(this.grpListPos);
            this.tabPagePosition.Controls.Add(this.btnSavePos);
            this.tabPagePosition.Controls.Add(this.btnCanl);
            this.tabPagePosition.Controls.Add(this.btnDeletePos);
            this.tabPagePosition.Controls.Add(this.btnEditPos);
            this.tabPagePosition.Controls.Add(this.btnAddPos);
            this.tabPagePosition.Controls.Add(this.grpPosition);
            this.tabPagePosition.Location = new System.Drawing.Point(4, 31);
            this.tabPagePosition.Name = "tabPagePosition";
            this.tabPagePosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosition.Size = new System.Drawing.Size(1069, 490);
            this.tabPagePosition.TabIndex = 1;
            this.tabPagePosition.Text = "Khu vực";
            this.tabPagePosition.UseVisualStyleBackColor = true;
            // 
            // grpListPos
            // 
            this.grpListPos.Controls.Add(this.scrollPosition);
            this.grpListPos.Controls.Add(this.dtGridPosition);
            this.grpListPos.Location = new System.Drawing.Point(537, 46);
            this.grpListPos.Name = "grpListPos";
            this.grpListPos.Size = new System.Drawing.Size(467, 395);
            this.grpListPos.TabIndex = 6;
            this.grpListPos.TabStop = false;
            this.grpListPos.Text = "Danh sách khu vực";
            // 
            // scrollPosition
            // 
            this.scrollPosition.Location = new System.Drawing.Point(701, 43);
            this.scrollPosition.Name = "scrollPosition";
            this.scrollPosition.Size = new System.Drawing.Size(21, 468);
            this.scrollPosition.TabIndex = 1;
            // 
            // dtGridPosition
            // 
            this.dtGridPosition.AllowUserToAddRows = false;
            this.dtGridPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pos,
            this.NamePos,
            this.StatusPos,
            this.NotePos});
            this.dtGridPosition.Location = new System.Drawing.Point(0, 29);
            this.dtGridPosition.Name = "dtGridPosition";
            this.dtGridPosition.RowTemplate.Height = 24;
            this.dtGridPosition.ShowCellErrors = false;
            this.dtGridPosition.Size = new System.Drawing.Size(447, 347);
            this.dtGridPosition.TabIndex = 0;
            // 
            // ID_Pos
            // 
            this.ID_Pos.DataPropertyName = "ID_Pos";
            this.ID_Pos.HeaderText = "ID Khu Vực";
            this.ID_Pos.Name = "ID_Pos";
            // 
            // NamePos
            // 
            this.NamePos.DataPropertyName = "Pos";
            this.NamePos.HeaderText = "Tên Khu Vực";
            this.NamePos.Name = "NamePos";
            // 
            // StatusPos
            // 
            this.StatusPos.DataPropertyName = "Sta";
            this.StatusPos.HeaderText = "Trạng Thái";
            this.StatusPos.Name = "StatusPos";
            // 
            // NotePos
            // 
            this.NotePos.DataPropertyName = "Note";
            this.NotePos.HeaderText = "Ghi Chú";
            this.NotePos.Name = "NotePos";
            // 
            // btnSavePos
            // 
            this.btnSavePos.Location = new System.Drawing.Point(291, 379);
            this.btnSavePos.Name = "btnSavePos";
            this.btnSavePos.Size = new System.Drawing.Size(84, 31);
            this.btnSavePos.TabIndex = 5;
            this.btnSavePos.Text = "Lưu";
            this.btnSavePos.UseVisualStyleBackColor = true;
            this.btnSavePos.Click += new System.EventHandler(this.btnSavePos_Click);
            // 
            // btnCanl
            // 
            this.btnCanl.Location = new System.Drawing.Point(121, 379);
            this.btnCanl.Name = "btnCanl";
            this.btnCanl.Size = new System.Drawing.Size(91, 31);
            this.btnCanl.TabIndex = 4;
            this.btnCanl.Text = "Hủy";
            this.btnCanl.UseVisualStyleBackColor = true;
            this.btnCanl.Click += new System.EventHandler(this.btnCanl_Click);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Location = new System.Drawing.Point(366, 322);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(95, 32);
            this.btnDeletePos.TabIndex = 3;
            this.btnDeletePos.Text = "Xóa";
            this.btnDeletePos.UseVisualStyleBackColor = true;
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // btnEditPos
            // 
            this.btnEditPos.Location = new System.Drawing.Point(203, 322);
            this.btnEditPos.Name = "btnEditPos";
            this.btnEditPos.Size = new System.Drawing.Size(96, 32);
            this.btnEditPos.TabIndex = 2;
            this.btnEditPos.Text = "Sửa";
            this.btnEditPos.UseVisualStyleBackColor = true;
            this.btnEditPos.Click += new System.EventHandler(this.btnEditPos_Click);
            // 
            // btnAddPos
            // 
            this.btnAddPos.Location = new System.Drawing.Point(53, 322);
            this.btnAddPos.Name = "btnAddPos";
            this.btnAddPos.Size = new System.Drawing.Size(84, 32);
            this.btnAddPos.TabIndex = 1;
            this.btnAddPos.Text = "Thêm";
            this.btnAddPos.UseVisualStyleBackColor = true;
            this.btnAddPos.Click += new System.EventHandler(this.btnAddPos_Click);
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.txtStatusPos);
            this.grpPosition.Controls.Add(this.txtNotePos);
            this.grpPosition.Controls.Add(this.txtNamePos);
            this.grpPosition.Controls.Add(this.txtIDPos);
            this.grpPosition.Controls.Add(this.lbNote);
            this.grpPosition.Controls.Add(this.lbStatus);
            this.grpPosition.Controls.Add(this.lbNamePos);
            this.grpPosition.Controls.Add(this.lbIDPosition);
            this.grpPosition.Location = new System.Drawing.Point(28, 46);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(487, 243);
            this.grpPosition.TabIndex = 0;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "Thông tin khu vực";
            // 
            // txtStatusPos
            // 
            this.txtStatusPos.Location = new System.Drawing.Point(186, 122);
            this.txtStatusPos.Name = "txtStatusPos";
            this.txtStatusPos.Size = new System.Drawing.Size(258, 30);
            this.txtStatusPos.TabIndex = 7;
            // 
            // txtNotePos
            // 
            this.txtNotePos.Location = new System.Drawing.Point(186, 167);
            this.txtNotePos.Name = "txtNotePos";
            this.txtNotePos.Size = new System.Drawing.Size(258, 30);
            this.txtNotePos.TabIndex = 6;
            // 
            // txtNamePos
            // 
            this.txtNamePos.Location = new System.Drawing.Point(186, 82);
            this.txtNamePos.Name = "txtNamePos";
            this.txtNamePos.Size = new System.Drawing.Size(258, 30);
            this.txtNamePos.TabIndex = 5;
            // 
            // txtIDPos
            // 
            this.txtIDPos.Enabled = false;
            this.txtIDPos.Location = new System.Drawing.Point(186, 43);
            this.txtIDPos.Name = "txtIDPos";
            this.txtIDPos.Size = new System.Drawing.Size(258, 30);
            this.txtIDPos.TabIndex = 4;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(32, 170);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(76, 22);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "Ghi Chú";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(32, 125);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(96, 22);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Trạng Thái";
            // 
            // lbNamePos
            // 
            this.lbNamePos.AutoSize = true;
            this.lbNamePos.Location = new System.Drawing.Point(32, 85);
            this.lbNamePos.Name = "lbNamePos";
            this.lbNamePos.Size = new System.Drawing.Size(115, 22);
            this.lbNamePos.TabIndex = 1;
            this.lbNamePos.Text = "Tên Khu Vực";
            // 
            // lbIDPosition
            // 
            this.lbIDPosition.AutoSize = true;
            this.lbIDPosition.Location = new System.Drawing.Point(32, 46);
            this.lbIDPosition.Name = "lbIDPosition";
            this.lbIDPosition.Size = new System.Drawing.Size(105, 22);
            this.lbIDPosition.TabIndex = 0;
            this.lbIDPosition.Text = "ID Khu Vực";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1069, 490);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1069, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Khách hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1069, 490);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Khuyến mãi";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // frmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabTable);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTables";
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.frmTables_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTable.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.grpListTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTable)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapa)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.tabPagePosition.ResumeLayout(false);
            this.grpListPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPosition)).EndInit();
            this.grpPosition.ResumeLayout(false);
            this.grpPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManagement;
        private System.Windows.Forms.ToolStripMenuItem mnDish;
        private System.Windows.Forms.ToolStripMenuItem mnOrder;
        private System.Windows.Forms.ToolStripMenuItem mnStatistic;
        private System.Windows.Forms.TabControl tabTable;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TabPage tabPagePosition;
        private System.Windows.Forms.Label labPosition;
        private System.Windows.Forms.Label labCapability;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.TextBox txtIDTable;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpListTable;
        private System.Windows.Forms.DataGridView dtGridTable;
        private System.Windows.Forms.GroupBox grpPosition;
        private System.Windows.Forms.Label lbIDPosition;
        private System.Windows.Forms.Label lbNamePos;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtIDPos;
        private System.Windows.Forms.TextBox txtNamePos;
        private System.Windows.Forms.TextBox txtNotePos;
        private System.Windows.Forms.Button btnAddPos;
        private System.Windows.Forms.Button btnEditPos;
        private System.Windows.Forms.Button btnDeletePos;
        private System.Windows.Forms.Button btnCanl;
        private System.Windows.Forms.Button btnSavePos;
        private System.Windows.Forms.GroupBox grpListPos;
        private System.Windows.Forms.VScrollBar scrollPosition;
        private System.Windows.Forms.DataGridView dtGridPosition;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePos;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotePos;
        private System.Windows.Forms.TextBox txtStatusPos;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.NumericUpDown numCapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnExit;
    }
}

