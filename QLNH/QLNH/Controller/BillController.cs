using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Model;

namespace QLNH.Controller
{
    public class BillController
    {
        private static BillController instance;

        public static BillController Instance
        {
            get { if (instance == null) instance = new BillController(); return BillController.instance; }
            private set { BillController.instance = value; }
        }

        private BillController() { }

        //Lay id bill chua thanh toan
        public int GetBillID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE ID_Table = " + id + " AND sta = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID_Bill;
            }

            return -1;
        }


    }
}
