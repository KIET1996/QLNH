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

namespace QLNH
{
    public partial class frmMenu : Form
    {
        // Khai bao BindingSource vi moi lan binding thi datasource se bi thay doi 
        //Bang cach gan datagrdviewCategories.DataSource = categoryList;
        // vi the moi lan load len thi du lieu se thay doi theo binding day 

        BindingSource categoryList = new BindingSource();
        BindingSource BindingData1 = new BindingSource();

        public frmMenu()
        {
            InitializeComponent();
        }

      

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numBoxFoodPrice_ValueChanged(object sender, EventArgs e)
        {

        }


        // Load all categories dish
        private void frmMenu_Load(object sender, EventArgs e)
        {
            Load_category();
            datagrdviewCategories.DataSource = categoryList;
            addCategoryBinding();

            // Dish 
            datagrdFood.DataSource = BindingData1;
            Load_Dishes();
            AddFood();
            LoadCobCategory(cobFoodCa);

        }
        /*********************Dish**********************/
        //Load data Food
        private void Load_Dishes()
        {
            BindingData1.DataSource = Controller.DishController.Instance.GetListDish();

        }

        // Binding data food
        void AddFood()
        {
            txtFoodID.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "ID_Dish"));
            txtFoodName.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Name"));
            numBoxFoodPrice.DataBindings.Add(new Binding("Value", datagrdFood.DataSource, "Price"));
            txtFoodUnit.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Unit"));
            txtFoodDes.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Descript"));
            radioBtnStatusOn.DataBindings.Add("Checked", datagrdFood.DataSource, "PhucVu", true, DataSourceUpdateMode.OnPropertyChanged, false);
            radioBtnStatusOff.DataBindings.Add("Checked", datagrdFood.DataSource, "NgungPhucVu", true, DataSourceUpdateMode.OnPropertyChanged, false);

        }

        // Dishplay combox in Data food
        void LoadCobCategory(ComboBox cb)
        {
            cb.DataSource = CategoryController.Instance.GetListCategory();
            cb.DisplayMember = "Name";

        }


        // Khi idFood thay doi thi Category cung se thay doi the0
        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (datagrdFood.SelectedCells.Count > 0)
                {
                    int id = (int)datagrdFood.SelectedCells[0].OwningRow.Cells["ID_Ca"].Value;

                    Category ca = CategoryController.Instance.getCategoryByID(id);
                    cobFoodCa.SelectedItem = ca;
                    // Select index trong category theo id 
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cobFoodCa.Items)
                    {
                        if (item.Id_Ca == ca.Id_Ca)
                        {
                            index = i;
                            break;

                        }
                        i++;
                    }
                    cobFoodCa.SelectedIndex = index;

                }
            }
            catch
            {

            }

        }

        // Add new Food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtFoodName.Text;
            int ID_Ca = (cobFoodCa.SelectedItem as Category).Id_Ca;
            string unit = txtFoodUnit.Text;
            double price = (double)numBoxFoodPrice.Value;
            string descript = txtFoodDes.Text;
            int sta = 0;

            if (radioBtnStatusOn.Checked)
            {
                sta = 1;
            }

            if (name == "" || unit == "" || descript == "")
            {
                MessageBox.Show("Nhập thiếu thông tin món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Load_Dishes();
            }
            else
            {

                if (DishController.Instance.CheckFood(name))
                {
                    MessageBox.Show("Món ăn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Load_Dishes();
                }

                else
                {
                    if (DishController.Instance.AddFood(ID_Ca, name, unit, price, descript, sta))
                    {
                        MessageBox.Show("Thêm món ăn thành công");
                        Load_Dishes();
                    }

                }

            }
        }

        //Update   food
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int ID_Ca = (cobFoodCa.SelectedItem as Category).Id_Ca;
            string name = txtFoodName.Text;
            string unit = txtFoodUnit.Text;
            float price = (float)numBoxFoodPrice.Value;
            string descript = txtFoodDes.Text;
            int sta = 0;
            int ID_Dish = Convert.ToInt32(txtFoodID.Text);

            if (radioBtnStatusOn.Checked)
            {
                sta = 1;
            }

            if (DishController.Instance.UpdateFood(ID_Ca, name, unit, price, descript, sta, ID_Dish))
            {
                MessageBox.Show("Sửa món thành công");
                Load_Dishes();
            }
        }

        // Search Food
        List<Dish> SearchingFood(string name)
        {
            List<Model.Dish> listfood = DishController.Instance.SearchFood(name);

            return listfood;
        }
        private void btnFoodSearch_Click(object sender, EventArgs e)
        {
            BindingData1.DataSource = SearchingFood(txtFoodSearch.Text);
        }


        //Delete food
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int ID_Dish = Convert.ToInt32(txtFoodID.Text);

            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                if (DishController.Instance.DeleteFood(ID_Dish))
                {
                    MessageBox.Show("Xóa món ăn thành công");
                    Load_Dishes();
                }
                else
                {
                    MessageBox.Show("Xóa món ăn thất bại");
                }

            }
        }

        /*********************Category**********************/

        // create function load categories
        private void Load_category()
        {
            categoryList.DataSource = Controller.CategoryController.Instance.GetListCategory();
        }

        // DataBindingAddCategory
        void addCategoryBinding()
        {
            txtCaName.DataBindings.Add(new Binding("Text", datagrdviewCategories.DataSource, "name"));
            txtCaId.DataBindings.Add(new Binding("Text", datagrdviewCategories.DataSource, "ID_Ca"));

        }

        //Them moi cac loai mon an
        private void btnAddCa_Click(object sender, EventArgs e)
        {
            if (txtCaName.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    string name = txtCaName.Text;

                    if (CategoryController.Instance.CheckCategory(name))
                    {

                        MessageBox.Show("Loại món ăn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else
                    {
                        if (CategoryController.Instance.AddCategory(name))
                        {

                            MessageBox.Show("Thêm loại món ăn thành công");
                            Load_category();
                           
                        }

                    }

                }
                catch
                {

                }
            }
        }

        // Xoa cac loai mon an
        private void btnDeleteCa_Click(object sender, EventArgs e)
        {
            int id_Ca = Convert.ToInt32(txtCaId.Text);

            if (CategoryController.Instance.DeleteCategory(id_Ca))
            {
                MessageBox.Show("Xóa loại món thành công");
                Load_category();
            }
            else
            {
                MessageBox.Show("Xóa bị lỗi, thử lại nào");
            }
        }

        //Tai lai trang
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCobCategory(cobFoodCa);
        }

        //Su kien dong form
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        ///Chuyen sang form Quan ly thong ke
        private void mnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStatistical frm = new FrmStatistical();
            frm.Show();
        }

        ///Chuyen sang form Quan ly goi mon
        private void mnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOther frm = new frmOther();
            frm.Show();
        }

        ///Chuyen sang form Quan ly ban
        private void mnManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTables frm = new frmTables();
            frm.Show();
        }
    }
}
