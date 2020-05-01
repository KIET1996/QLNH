using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Dish
    {
        private int iD_Dish;
        private int iD_Ca;
        private string name;
        private string unit;
        private double price;
        private int sta; 
        private string descript;


        public Dish(DataRow row)
        {
            this.ID_Dish = (int)row["ID_Dish"];
            this.ID_Ca = (int)row["ID_Ca"];
            this.Name = row["name"].ToString();
            this.Unit = row["unit"].ToString();
            this.Price = (double)row["price"];
            this.Sta = Convert.ToInt32(row["sta"]);
            this.Descript = row["descript"].ToString();
        }

        public Dish(int iD_Dish, int iD_Ca, string name, string unit, double price, int sta, string descript)
        {
            this.ID_Dish = iD_Dish;
            this.ID_Ca = iD_Ca;
            this.Name = name;
            this.Unit = unit;
            this.Price = price;
            this.Sta = sta;
            this.Descript = descript;
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

        public int ID_Ca
        {
            get
            {
                return iD_Ca;
            }

            set
            {
                iD_Ca = value;
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

        public string Unit
        {
            get
            {
                return unit;
            }

            set
            {
                unit = value;
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

        public int Sta
         {
             get
             {
                 return sta;
             }

             set
             {
                 sta = value;
             }
         }
        /*  Get/Set for 1st Radio button
        public bool PhucVu
        {
            // If the Global Variable = 1 return true, else return false
            get
            {
                if (sta.Equals(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // If the value being passed in = 1 set the Global Variable = 1, else do nothing
            set
            {
                if (value.Equals(true))
                {
                    sta = 1;
                }
            }
        }

        // Get/Set for 2nd Radio button
        public bool NgungPhucVu
        {
            // If the Global Variable = 2 return true, else return false
            get
            {
                if (sta.Equals(0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // If the value being passed in = 2 set the Global Variable = 2, else do nothing
            set
            {
                if (value.Equals(true))
                {
                    sta = 0;
                }
            }
        }
        */
        public string Descript
        {
            get
            {
                return descript;
            }

            set
            {
                descript = value;
            }
        }
    }
}
