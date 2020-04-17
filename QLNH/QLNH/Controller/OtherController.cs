using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class OtherController
    {
        private static OtherController instance;

        public static OtherController Instance
        {
            get { if (instance == null) instance = new OtherController(); return OtherController.instance; }
            private set { OtherController.instance = value; }
        }

        private OtherController() { }

        //
        public List<Other> GetOtherByTable(int id)
        {
            List<Other> listOther = new List<Other>();

            string query = "SELECT d.name, bd.quantity, d.price, d.price*bd.quantity AS total FROM Bill_Details AS bd, Bill AS b, Dishes AS d WHERE bd.ID_Bill = b.ID_Bill AND bd.ID_Dish = d.ID_Dish AND b.ID_Table =" + id; 
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Other menu = new Other (item);
                listOther.Add(menu);
            }

            return listOther;
        }
    }
}
