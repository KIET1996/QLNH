namespace QLNH
{
    partial class frmOther
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
            this.pnOther = new System.Windows.Forms.Panel();
            this.updQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.lbCategories = new System.Windows.Forms.Label();
            this.btnOther = new System.Windows.Forms.Button();
            this.cbDish = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pnBill = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbChange = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnManagenment = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOther = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.pnOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).BeginInit();
            this.pnBill.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOther
            // 
            this.pnOther.Controls.Add(this.updQuantity);
            this.pnOther.Controls.Add(this.lbQuantity);
            this.pnOther.Controls.Add(this.lbFood);
            this.pnOther.Controls.Add(this.lbCategories);
            this.pnOther.Controls.Add(this.btnOther);
            this.pnOther.Controls.Add(this.cbDish);
            this.pnOther.Controls.Add(this.cbCategory);
            this.pnOther.Location = new System.Drawing.Point(396, 38);
            this.pnOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOther.Name = "pnOther";
            this.pnOther.Size = new System.Drawing.Size(500, 116);
            this.pnOther.TabIndex = 0;
            // 
            // updQuantity
            // 
            this.updQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updQuantity.Location = new System.Drawing.Point(104, 77);
            this.updQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.updQuantity.Name = "updQuantity";
            this.updQuantity.Size = new System.Drawing.Size(105, 30);
            this.updQuantity.TabIndex = 7;
            this.updQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(9, 73);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(84, 23);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.Location = new System.Drawing.Point(9, 38);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(48, 23);
            this.lbFood.TabIndex = 5;
            this.lbFood.Text = "Món";
            // 
            // lbCategories
            // 
            this.lbCategories.AutoSize = true;
            this.lbCategories.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.Location = new System.Drawing.Point(9, 4);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(48, 23);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.Text = "Loại";
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(345, 69);
            this.btnOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(103, 38);
            this.btnOther.TabIndex = 2;
            this.btnOther.Text = "Chọn món";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // cbDish
            // 
            this.cbDish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDish.FormattingEnabled = true;
            this.cbDish.Location = new System.Drawing.Point(104, 40);
            this.cbDish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDish.Name = "cbDish";
            this.cbDish.Size = new System.Drawing.Size(227, 30);
            this.cbDish.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(104, 4);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(224, 30);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.txtTotal);
            this.pnBill.Controls.Add(this.lbTotal);
            this.pnBill.Controls.Add(this.lvBill);
            this.pnBill.Location = new System.Drawing.Point(394, 161);
            this.pnBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(333, 366);
            this.pnBill.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(170, 325);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(160, 28);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(72, 325);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(97, 23);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Tổng tiền:";
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.Location = new System.Drawing.Point(4, 16);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(326, 304);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Món ăn";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.txtPercent);
            this.pnButton.Controls.Add(this.cbDiscount);
            this.pnButton.Controls.Add(this.btnChange);
            this.pnButton.Controls.Add(this.lbChange);
            this.pnButton.Controls.Add(this.comboBox1);
            this.pnButton.Controls.Add(this.lbDiscount);
            this.pnButton.Controls.Add(this.btnDiscount);
            this.pnButton.Controls.Add(this.btnCheckout);
            this.pnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnButton.Location = new System.Drawing.Point(733, 161);
            this.pnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(168, 366);
            this.pnButton.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(8, 86);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(103, 38);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Chuyển";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(8, 16);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(101, 22);
            this.lbChange.TabIndex = 6;
            this.lbChange.Text = "Chuyển bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 30);
            this.comboBox1.TabIndex = 5;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(9, 146);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(154, 22);
            this.lbDiscount.TabIndex = 3;
            this.lbDiscount.Text = "Loại giảm giá (%)";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(9, 269);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(103, 38);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Gỉam";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(9, 315);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 38);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpnTable);
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 489);
            this.panel1.TabIndex = 3;
            // 
            // fpnTable
            // 
            this.fpnTable.AutoScroll = true;
            this.fpnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnTable.Location = new System.Drawing.Point(3, 4);
            this.fpnTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fpnTable.Name = "fpnTable";
            this.fpnTable.Size = new System.Drawing.Size(380, 472);
            this.fpnTable.TabIndex = 0;
            // 
            // mnLogout
            // 
            this.mnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(100, 26);
            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManagenment,
            this.mnDish,
            this.mnOther,
            this.mnStatistic,
            this.mnLogout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(901, 30);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnManagenment
            // 
            this.mnManagenment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànToolStripMenuItem});
            this.mnManagenment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnManagenment.Name = "mnManagenment";
            this.mnManagenment.Size = new System.Drawing.Size(84, 26);
            this.mnManagenment.Text = "Quản lý";
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
            // mnOther
            // 
            this.mnOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnOther.Name = "mnOther";
            this.mnOther.Size = new System.Drawing.Size(90, 26);
            this.mnOther.Text = "Gọi món";
            // 
            // mnStatistic
            // 
            this.mnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStatistic.Name = "mnStatistic";
            this.mnStatistic.Size = new System.Drawing.Size(94, 26);
            this.mnStatistic.Text = "Thống kê";
            // 
            // cbDiscount
            // 
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(13, 181);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(143, 26);
            this.cbDiscount.TabIndex = 8;
            this.cbDiscount.SelectedIndexChanged += new System.EventHandler(this.cbDiscount_SelectedIndexChanged);
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(13, 223);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(100, 24);
            this.txtPercent.TabIndex = 9;
            // 
            // frmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.pnOther);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOther";
            this.Text = "Quản lý hà hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOther_FormClosing);
            this.pnOther.ResumeLayout(false);
            this.pnOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updQuantity)).EndInit();
            this.pnBill.ResumeLayout(false);
            this.pnBill.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnButton.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnOther;
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnTable;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.Label lbCategories;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.ComboBox cbDish;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnManagenment;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnOther;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown updQuantity;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolStripMenuItem mnDish;
        private System.Windows.Forms.ToolStripMenuItem mnStatistic;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.TextBox txtPercent;
    }
}

