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

        void ResetFieldsDish(bool status)
        {
            btnSave.Enabled = !status;
            btnAddFood.Enabled = status;
            btnCancel.Enabled = !status;
            btnUpdateFood.Enabled = status;
            btnDeleteFood.Enabled = status;

        }
        private void Load_Dishes()
        {
            BindingData1.DataSource = Controller.DishController.Instance.ListDish();

        }

        // Binding data food
        void AddFood()
        {
            txtFoodID.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "ID_Dish"));
            txtFoodName.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Name"));
            numBoxFoodPrice.DataBindings.Add(new Binding("Value", datagrdFood.DataSource, "Price"));
            txtFoodUnit.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Unit"));
            txtFoodDes.DataBindings.Add(new Binding("Text", datagrdFood.DataSource, "Descript"));
            radioBtnStatusOn.DataBindings.Add(new Binding("Checked", datagrdFood.DataSource, "Sta"));
           // radioBtnStatusOn.DataBindings.Add("Checked", datagrdFood.DataSource, "PhucVu", true, DataSourceUpdateMode.OnPropertyChanged, false);
            //radioBtnStatusOff.DataBindings.Add("Checked", datagrdFood.DataSource, "NgungPhucVu", true, DataSourceUpdateMode.OnPropertyChanged, false);

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
                    int id = (int)datagrdFood.SelectedCells[0].OwningRow.Cells["Mã Loại"].Value;

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

        int noDish;
        // Add new Food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            ResetFieldsDish(false);
            try
            {
                noDish = DishController.Instance.getMaxIdDish();
            }
            catch
            {
                noDish = 0;
            }
            noDish++;
            
            txtFoodID.Text = noDish.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
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
                        ResetFieldsDish(true);
                    }

                }

            }
        }

        //Update  food
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
        private void btnFoodSearch_Click(object sender, EventArgs e)
        {
            // BindingData1.DataSource = SearchingFood(txtFoodSearch.Text);
            BindingData1.DataSource = DishController.Instance.Search(txtFoodSearch.Text);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFieldsDish(true);
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

        // Phân trang

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtpage.Text = "1";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int recordNum = CategoryController.Instance.loadCaPageNum();
            int lastpage = recordNum / 10;
            if (recordNum % 10 != 0)
            {
                lastpage++;
            }
            txtpage.Text = lastpage.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtpage.Text);
            if (page > 1)
                page--;
            txtpage.Text = page.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtpage.Text);
            int recordNum = CategoryController.Instance.loadCaPageNum();
            if (page < recordNum)
                page++;
            txtpage.Text = page.ToString();
        }

        private void txtpage_TextChanged(object sender, EventArgs e)
        {
            categoryList.DataSource = CategoryController.Instance.loadCaPage(Convert.ToInt32(txtpage.Text));
        }


        //Tai lai trang
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCobCategory(cobFoodCa);
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
        //Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Tro ve login
        private void mnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Close();
                //Application.Exit();
            }
        }

        //Luu them mon
        private void btnSaveCa_Click(object sender, EventArgs e)
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
                            ResetFieldCategory(true);
                        }
                    }
                }
                catch
                {

                }
            }
        }

        //Them loai moi mon an 
        private void btnAddCa_Click(object sender, EventArgs e)
        {
            ResetFieldCategory(false);
            int count = CategoryController.Instance.GetMaxIDCategory();
            count++;
            txtCaId.Text = count.ToString();
            txtCaName.Clear();
        }

        //Reset lai cac button
        public void ResetFieldCategory(bool status)
        {
            btnAddCa.Enabled = status;
            btnEditCa.Enabled = status;
            btnDeleteCa.Enabled = status;
            btnCancleCa.Enabled = !status;
            btnSaveCa.Enabled = !status;
        }

        //Huy them moi loai mon an
        private void btnCancleCa_Click(object sender, EventArgs e)
        {
            ResetFieldCategory(true);
        }

        //Chinh sua loai mon an
        private void btnEditCa_Click(object sender, EventArgs e)
        {
            int ID_Ca = Convert.ToInt32(txtCaId.Text);
            string name = txtCaName.Text;

            if (CategoryController.Instance.UpdateCategory(ID_Ca, name))
            {
                MessageBox.Show("Sửa thông tin thành công!");
                Load_category();
            }
        }

       
    }
}
