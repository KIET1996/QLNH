using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Profit
    {
        private int iD_Bill;
        private int iD_Table;
        private DateTime? time_Arrive;
        private DateTime? time_Payment;
        private double per;
        private float total_price;

        public Profit(DataRow row)
        {
            this.ID_Bill = (int)row["ID_Bill"];
            this.ID_Table = (int)row["ID_Table"];
            this.Time_Arrive = (DateTime?)row["Time_Arrive"];
            if (row["Time_Payment"].ToString() != "")
                this.Time_Payment = (DateTime?)row["Time_Payment"];
            this.Per = (double)row["Per"];
            this.Total_price = (float)row["Total_price"];
        }

        public Profit(int iD_Bill, int iD_Table, DateTime? time_Arrive, DateTime? time_Payment, double per, float total_price)
        {
            this.ID_Bill = iD_Bill;
            this.ID_Table = iD_Table;
            this.Time_Arrive = time_Arrive;
            this.Time_Payment = time_Payment;
            this.Per = per;
            this.Total_price = total_price;
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

        public int ID_Table
        {
            get
            {
                return iD_Table;
            }

            set
            {
                iD_Table = value;
            }
        }

        public DateTime? Time_Arrive
        {
            get
            {
                return time_Arrive;
            }

            set
            {
                time_Arrive = value;
            }
        }

        public DateTime? Time_Payment
        {
            get
            {
                return time_Payment;
            }

            set
            {
                time_Payment = value;
            }
        }

        public double Per
        {
            get
            {
                return per;
            }

            set
            {
                per = value;
            }
        }

        public float Total_price
        {
            get
            {
                return total_price;
            }

            set
            {
                total_price = value;
            }
        }
    }
}
