using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class CategoryController
    {
        private static CategoryController instance;

        public static CategoryController Instance
        {
            get { if (instance == null) instance = new CategoryController(); return CategoryController.instance; }
            private set { CategoryController.instance = value; }
        }

        private CategoryController() { }

        //Lấy danh sách category từ csdl, trả về list các phần tử là category
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from Categories";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        // Add category
        public bool AddCategory(string name)
        {
            string query = string.Format("INSERT dbo.Categories ( name)VALUES  ( '{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //Delete category
        public bool DeleteCategory(int id_Ca)
        {
            string query = string.Format("DeLETE dbo.Categories ( id_Ca)VALUES  ( {0})", id_Ca);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //Get category by id
        public Category getCategoryByID(int id)
        {
            Category ca = null;

            string query = "select * from Categories where ID_Ca = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ca = new Category(item);
                return ca;
            }

            return ca;
        }

        //Check exist category
        public bool CheckCategory(string name)
        {
            string sql = string.Format("Select count(name) from  dbo.Categories where name = '{0}' ", name);
            int result = (Int32)DataProvider.Instance.ExecuteScalar(sql);

            return result > 0;
        }

       

    }
}
