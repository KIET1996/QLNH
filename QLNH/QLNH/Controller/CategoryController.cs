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
    }
}
