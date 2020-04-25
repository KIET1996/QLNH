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

        // List Food
        public List<Dish> GetListDish()
        {
            List<Dish> list = new List<Dish>();

            string query = "select * from Dishes";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Dish food = new Dish(item);
                list.Add(food);
            }

            return list;
        }

        // Add new food
        public bool AddFood(int ID_Ca, string name, string unit, double price, string descipt, int sta)
        {
            string query = string.Format("INSERT dbo.Dishes ( ID_Ca, name, unit, price, descript, sta )VALUES  ( {0} ,'{1}' , '{2}' , {3}, '{4}', {5})", ID_Ca, name, unit, price, descipt, sta);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Check exist Food 
        public bool CheckFood(string name)
        {
            string sql = string.Format("Select count(name) from  dbo.Dishes where name = '{0}' ", name);
            int result = (Int32)DataProvider.Instance.ExecuteScalar(sql);
            return result > 0;
        }

        // Searching Food
        public List<Dish> SearchFood(string name)
        {
            List<Dish> list = new List<Dish>();

            string query = String.Format("Select * from Dishes where [dbo].[fuConvertToUnsign1](name) like '%'+ [dbo].[fuConvertToUnsign1]('{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Dish food = new Dish(item);
                list.Add(food);
            }

            return list;
        }

        //Update Food
        public bool UpdateFood(int ID_Ca, string name, string unit, float price, string descript, int sta, int ID_Dish)
        {
            string query = string.Format("UPDATE dbo.Dishes SET ID_Ca = {0}, name = '{1}', unit= '{2}', price = {3}, descript = '{4}', sta = {5}  WHERE ID_Dish = {6}", ID_Ca, name, unit, price, descript, sta, ID_Dish);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //Delete Food
        public bool DeleteFood(int ID_Dish)
        {
            string query = string.Format("DELETE dbo.Dishes WHERE ID_Dish = {0}", ID_Dish);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
