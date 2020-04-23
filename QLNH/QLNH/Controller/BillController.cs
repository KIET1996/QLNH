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
        public int GetUncheckBillID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE ID_Table = " + id + " AND sta = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID_Bill;
            }

            return -1;
        }

        //Thêm bill mới, giá trị truyền vào có id_emp, id_table
        //Tạm thời chỉ truyền id_table
        public void InsertBill(int id)
        {
            int emp = 1;
           
            DataProvider.Instance.ExecuteNonQuery("exec QLNH_InsertBill  @id_emp , @id_table", new object[] { emp , id });
        }

        //Lấy id bill lớn nhất
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }

        //Thay doi trang thai thanh tinh tien, tham so la id_bill
        public void CheckOut(int id)
        {
            string query = "UPDATE Bill SET sta = 1 WHERE ID_Bill = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
