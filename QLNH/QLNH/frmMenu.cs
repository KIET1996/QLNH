using QLNH.Controller;
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

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFoodSearch_Click(object sender, EventArgs e)
        {

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

        }
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
            string name = txtCaName.Text;

            if (CategoryController.Instance.AddCategory(name))
            {
                MessageBox.Show("Thêm loại món thành công");
                Load_category();
            }
            else
            {
                MessageBox.Show("Thêm bị lỗi, thử lại nào");
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

       

    }
}
