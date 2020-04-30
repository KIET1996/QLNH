using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class DiscountController
    {
        private static DiscountController instance;

        public static DiscountController Instance
        {
            get { if (instance == null) instance = new DiscountController(); return DiscountController.instance; }
            private set { DiscountController.instance = value; }
        }

        private DiscountController() { }

        //Lấy danh sách Discount còn hoạt động từ csdl, trả về list các phần tử là Discount
        public List<Discount> GetListDiscount()
        {
            List<Discount> list = new List<Discount>();

            string query = "select * from Discount where sta=0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }

            return list;
        }

        //Lấy danh sách Discount từ csdl, trả về list các phần tử là Discount
        public List<Discount> GetListAllDiscount()
        {
            List<Discount> list = new List<Discount>();

            string query = "select * from Discount";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }

            return list;
        }

    }
}
