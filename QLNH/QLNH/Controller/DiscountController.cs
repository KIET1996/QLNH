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

        //Lấy toàn bộ danh sách Discount từ csdl, trả về list các phần tử là Discount
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

        //Delete discount
        public bool DeleteDiscount(int ID_Dis)
        {
            string sql = string.Format("DELETE Discount WHERE ID_Dis = '{0}'", ID_Dis);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

        public bool UpdateDiscount(int ID_Dis, double per, string descript, DateTime start, DateTime finish)
        {

            int result = DataProvider.Instance.ExecuteNonQuery("exec QLNH_UpdateDiscount  @id_dis , @per , @descript , @start , @finish", new object[] { ID_Dis, per, descript, start, finish });

            return result > 0;
        }

        //Lấy id dish lớn nhất
        public int GetMaxIDDis()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID_Dis) FROM Discount");
            }
            catch
            {
                return 1;
            }
        }

        // Thêm chương trình giảm giá
        public bool InsertDiscount(double per, string descript, DateTime start, DateTime finish)
        {
          
            int result = DataProvider.Instance.ExecuteNonQuery("exec QLNH_InsertDiscount  @per , @descript , @start , @finish", new object[] { per, descript, start, finish });

            return result > 0;

        }
    }

}
