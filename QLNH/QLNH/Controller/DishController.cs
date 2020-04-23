using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class DishController
    {
        private static DishController instance;

        public static DishController Instance
        {
            get { if (instance == null) instance = new DishController(); return DishController.instance; }
            private set { DishController.instance = value; }
        }

        private DishController() { }

        //Lấy list các món Dish theo Loại Category, tham số là ID Category, trả về danh sách món theo loại
        public List<Dish> GetDishByCategoryID(int id)
        {
            List<Dish> list = new List<Dish>();

            string query = "select * from Dishes where ID_Ca = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Dish dish = new Dish(item);
                list.Add(dish);
            }

            return list;
        }
    }
}
