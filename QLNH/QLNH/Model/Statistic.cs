using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Statistic
    {
        private int iD_Dish;
        private string name;
        private double price;
        private int quantity;
        private double total;

        public Statistic(DataRow row)
        {
            this.ID_Dish = (int)row["ID_Dish"];
            this.Name = row["name"].ToString();
            this.Price = (double)row["price"];
            this.Quantity = Convert.ToInt32(row["quantity"]);
            this.Total =(double)row["total"];
        }

        public Statistic(int iD_Dish, string name, double price, int quantity, double total)
        {
            this.ID_Dish = iD_Dish;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Total = total;
        }

        public int ID_Dish
        {
            get
            {
                return iD_Dish;
            }

            set
            {
                iD_Dish = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
