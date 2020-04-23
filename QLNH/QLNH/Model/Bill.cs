using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLNH.Model
{
    public class Bill
    {
        private int iD_Bill;
        private int iD_Emp;
        private int iD_Table;
	    private DateTime? time_Arrive;
        private DateTime? time_Payment;
        private int iD_Dis;
        private int sta;
        private float total_price;

        public Bill(int id_bill, int id_emp, int id_table, DateTime? time_arrive, DateTime? time_payment, int id_dis, int status, float total_price)
        {
            this.ID_Bill = id_bill;
            this.ID_Emp = id_emp;
            this.ID_Table = id_table;
            this.Time_Arrive = time_arrive;
            this.Time_Payment = time_payment;
            this.ID_Dis = id_dis;
            this.Sta = status;
            this.Total_price = total_price;

        }

        public Bill(DataRow row)
        {
            this.ID_Bill = (int)row["ID_Bill"];
            this.ID_Emp = (int)row["ID_Emp"];
            this.ID_Table = (int)row["ID_Table"];
            this.Time_Arrive = (DateTime?)row["Time_Arrive"];
            if (row["Time_Payment"].ToString() != "")
                this.Time_Payment = (DateTime?)row["Time_Payment"];
            this.ID_Dis = (int)row["ID_Dis"];
            this.Sta = Convert.ToInt32(row["sta"]);
            this.Total_price = (float)row["Total_price"];
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

        public int ID_Emp
        {
            get
            {
                return iD_Emp;
            }

            set
            {
                iD_Emp = value;
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

        public int ID_Dis
        {
            get
            {
                return iD_Dis;
            }

            set
            {
                iD_Dis = value;
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
