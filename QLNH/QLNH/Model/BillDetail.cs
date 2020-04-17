using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class BillDetail
    {
        private int iD_Detail;
        private int iD_Bill;
        private int iD_Dish;
        private int quantity;
      

        public int ID_Detail
        {
            get
            {
                return iD_Detail;
            }

            set
            {
                iD_Detail = value;
            }
        }

        public int ID_Bill
        {
            get
            {
                return iD_Bill;
            }

            set
            {
                iD_Bill = value;
            }
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


        public BillDetail(int iD_Detail, int iD_Bill, int iD_Dish, int quantity)
        {
            this.ID_Detail = iD_Detail;
            this.ID_Bill = iD_Bill;
            this.ID_Dish = iD_Dish;
            this.Quantity = quantity;
         
        }

        public BillDetail(DataRow row)
        {
            this.ID_Detail = (int)row["ID_Detail"];
            this.ID_Bill = (int)row["ID_Bill"];
            this.ID_Dish = (int)row["ID_Dis"];
            this.Quantity = (int)row["Quantity"];
        }
    }
}
