using QLNH.Controller;
using QLNH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLNH
{
    public partial class frmOther : Form
    {
        public int id_discount = 1;
        public frmOther()
        {
            InitializeComponent();

            LoadTable();
            LoadCategories();
            LoadDiscount();
        }

        //Load danh sach loai giam gia
        void LoadDiscount()
        {
            List<Discount> listDiscount = DiscountController.Instance.GetListDiscount();
            cbDiscount.DataSource = listDiscount;
            cbDiscount.DisplayMember = "descript";
        }

        // Load danh sach loai mon an
        void LoadCategories()
        {
            List<Category> listCategory = CategoryController.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";

        }

        // Load danh sach thuc an theo loai
        void LoadFoodFollowCategoriey(int id)
        {
            List<Dish> listDish = DishController.Instance.GetDishByCategoryID(id);
            cbDish.DataSource = listDish;
            cbDish.DisplayMember = "name";
        }

        // Load danh sach ban
        void LoadTable()
        {
            fpnTable.Controls.Clear();
            List<Table> tableList = TableController.Instance.ListTable();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableController.TableWidth, Height = TableController.TableHeight };
                btn.Text = "Bàn " + item.ID_Table + Environment.NewLine + item.Status 
                    + Environment.NewLine + item.Position + Environment.NewLine + "Chỗ " + item.Capability;
         
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case 0:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                fpnTable.Controls.Add(btn);
            }
        }

        //Show noi dung hoa don
        void ShowBill(int id)
        {
            double total = 0;
            lvBill.Items.Clear();
            List<Other> listBillInfo = OtherController.Instance.GetOtherByTable(id);

            foreach (Other item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.FoodName.ToString());
                lvItem.SubItems.Add(item.Quantity.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Total.ToString());
                total += item.Total;
                lvBill.Items.Add(lvItem);
            }
           
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotal.Text = total.ToString("C", culture);
        }
        
        //Bat su kien khi nhan vao bieu tuong ban de show bill
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID_Table;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        //Gọi món theo bàn
        private void btnOther_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            int idBill = BillController.Instance.GetUncheckBillID(table.ID_Table);
            int idDish = (cbDish.SelectedItem as Dish).ID_Dish;
            int count = (int)updQuantity.Value;

            if (idBill == -1)
            {
                BillController.Instance.InsertBill(table.ID_Table);
                BillDetailController.Instance.InsertBillDetail(BillController.Instance.GetMaxIDBill(), idDish, count);
            }
            else
            {
                BillDetailController.Instance.InsertBillDetail(idBill, idDish, count);
            }
            updQuantity.Value = 1;
            ShowBill(table.ID_Table);
            LoadTable();
        }

        //Su kien thoat form
        private void mnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Su kien dong form
        private void frmOther_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //Bắt sự kiện khi Categogy thay đổi thức ăn thay đổi
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id_Ca;

            LoadFoodFollowCategoriey(id);
        }

        //Thanh toán tièn
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            int idBill = BillController.Instance.GetUncheckBillID(table.ID_Table);

            double per = Convert.ToDouble(txtPercent.Text) / 100;
            double total =Convert.ToDouble(txtTotal.Text.Split(',')[0]);
            total = (total + total * 0.1 + total * per)*1000;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\n Tổng tiền= tổng tiền + 10%(VAT) - giảm giá \n= {1} ", table.ID_Table, total), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillController.Instance.CheckOut(idBill, id_discount, total);
                    ShowBill(table.ID_Table);

                    LoadTable();
                }
            }
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            Discount selected = cb.SelectedItem as Discount;
            txtPercent.Text = selected.Per.ToString();
            id_discount = selected.ID_Dis;

           
        }
    }
}
