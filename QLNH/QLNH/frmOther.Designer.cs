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
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.lbCategories = new System.Windows.Forms.Label();
            this.btnOther = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.pnBill = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.pnButton = new System.Windows.Forms.Panel();
            this.nupDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbChange = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOther = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.pnBill.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOther
            // 
            this.pnOther.Controls.Add(this.nupQuantity);
            this.pnOther.Controls.Add(this.lbQuantity);
            this.pnOther.Controls.Add(this.lbFood);
            this.pnOther.Controls.Add(this.lbCategories);
            this.pnOther.Controls.Add(this.btnOther);
            this.pnOther.Controls.Add(this.cbFood);
            this.pnOther.Controls.Add(this.cbCategories);
            this.pnOther.Location = new System.Drawing.Point(452, 40);
            this.pnOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnOther.Name = "pnOther";
            this.pnOther.Size = new System.Drawing.Size(477, 124);
            this.pnOther.TabIndex = 0;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantity.Location = new System.Drawing.Point(119, 82);
            this.nupQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(120, 30);
            this.nupQuantity.TabIndex = 7;
            this.nupQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(10, 78);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(98, 25);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFood.Location = new System.Drawing.Point(10, 41);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(54, 25);
            this.lbFood.TabIndex = 5;
            this.lbFood.Text = "Món";
            // 
            // lbCategories
            // 
            this.lbCategories.AutoSize = true;
            this.lbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.Location = new System.Drawing.Point(10, 4);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(53, 25);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.Text = "Loại";
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(347, 71);
            this.btnOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(118, 41);
            this.btnOther.TabIndex = 2;
            this.btnOther.Text = "Chọn món";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(119, 43);
            this.cbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(206, 33);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(119, 4);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(206, 33);
            this.cbCategories.TabIndex = 0;
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.lvBill);
            this.pnBill.Location = new System.Drawing.Point(450, 172);
            this.pnBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(332, 390);
            this.pnBill.TabIndex = 1;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.GridLines = true;
            this.lvBill.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvBill.Location = new System.Drawing.Point(3, 17);
            this.lvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(324, 359);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.nupDiscount);
            this.pnButton.Controls.Add(this.btnChange);
            this.pnButton.Controls.Add(this.lbChange);
            this.pnButton.Controls.Add(this.comboBox1);
            this.pnButton.Controls.Add(this.lbPercentage);
            this.pnButton.Controls.Add(this.lbDiscount);
            this.pnButton.Controls.Add(this.btnDiscount);
            this.pnButton.Controls.Add(this.btnPay);
            this.pnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnButton.Location = new System.Drawing.Point(787, 172);
            this.pnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(142, 390);
            this.pnButton.TabIndex = 2;
            // 
            // nupDiscount
            // 
            this.nupDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupDiscount.Location = new System.Drawing.Point(11, 190);
            this.nupDiscount.Name = "nupDiscount";
            this.nupDiscount.Size = new System.Drawing.Size(88, 30);
            this.nupDiscount.TabIndex = 8;
            this.nupDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(9, 92);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(118, 41);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Chuyển";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(9, 17);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(119, 25);
            this.lbChange.TabIndex = 6;
            this.lbChange.Text = "Chuyển bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 30);
            this.comboBox1.TabIndex = 5;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentage.Location = new System.Drawing.Point(105, 200);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(24, 20);
            this.lbPercentage.TabIndex = 4;
            this.lbPercentage.Text = "%";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(10, 156);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(89, 25);
            this.lbDiscount.TabIndex = 3;
            this.lbDiscount.Text = "Giảm giá";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(10, 229);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(118, 41);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Gỉam";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(10, 330);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(118, 41);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpnTable);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 522);
            this.panel1.TabIndex = 3;
            // 
            // fpnTable
            // 
            this.fpnTable.AutoScroll = true;
            this.fpnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnTable.Location = new System.Drawing.Point(3, 4);
            this.fpnTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fpnTable.Name = "fpnTable";
            this.fpnTable.Size = new System.Drawing.Size(434, 504);
            this.fpnTable.TabIndex = 0;
            // 
            // mnLogout
            // 
            this.mnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(113, 32);
            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.mnOther,
            this.mnLogout});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(929, 36);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bànToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // bànToolStripMenuItem
            // 
            this.bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            this.bànToolStripMenuItem.Size = new System.Drawing.Size(122, 32);
            this.bànToolStripMenuItem.Text = "Bàn";
            // 
            // mnOther
            // 
            this.mnOther.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnOther.Name = "mnOther";
            this.mnOther.Size = new System.Drawing.Size(100, 32);
            this.mnOther.Text = "Gọi món";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 80;
            // 
            // frmOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnBill);
            this.Controls.Add(this.pnOther);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOther";
            this.Text = "Quản lý hà hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOther_FormClosing);
            this.pnOther.ResumeLayout(false);
            this.pnOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.pnBill.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.pnButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiscount)).EndInit();
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
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnOther;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.NumericUpDown nupDiscount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

