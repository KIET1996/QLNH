using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Other
    {
        private string foodName;
        private int quantity;
        private double price;
        private double total;

        public Other(string foodName, int quantity, double price, double total = 0)
        {
            this.FoodName = foodName;
            this.Quantity = quantity;
            this.Price = price;
            this.Total = total;
        }

        public Other(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Quantity =(int)row["quantity"];
            this.Price = (double)row["price"];
            this.Total =(double)row["total"];
        }
        public string FoodName
        {
            get
            {
                return foodName;
            }

            set
            {
                foodName = value;
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
