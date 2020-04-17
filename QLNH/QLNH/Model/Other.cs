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
        private decimal price;
        private decimal total;

        public Other(string foodName, int quantity, decimal price, decimal total = 0)
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
            this.Price = (decimal)row["price"];
            this.Total =(decimal)row["total"];
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

        public decimal Price
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

        public decimal Total
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
