using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Discount
    {
        private int iD_Dis;
        private double per;
        private string descript;
        private DateTime start;
        private DateTime finish;
        private int sta;

        public Discount(DataRow row)
        {
            this.ID_Dis = (int)row["ID_Dis"];
            this.Per = (double)row["per"];
            this.Descript = row["descript"].ToString();
            this.Start = (DateTime)row["start"];
            if (row["finish"].ToString() != "")
               this.Finish = (DateTime)row["finish"];
            this.Sta = Convert.ToInt32(row["sta"]);
        }

        public Discount(int iD_Dis, double per, string descript, DateTime start, DateTime finish, int sta)
        {
            this.ID_Dis = iD_Dis;
            this.Per = per;
            this.Descript = descript;
            this.Start = start;
            this.Finish = finish;
            this.Sta = sta;
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

        public DateTime Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public DateTime Finish
        {
            get
            {
                return finish;
            }

            set
            {
                finish = value;
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
    }
}
