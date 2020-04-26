using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class BillDetailController
    {
        private static BillDetailController instance;

        public static BillDetailController Instance
        {
            get { if (instance == null) instance = new BillDetailController(); return BillDetailController.instance; }
            private set { BillDetailController.instance = value; }
        }

        private BillDetailController() { }

        // Lay chi tiet bill dua tren id_bill, tra ve danh sach chi tiet bill
        public List<BillDetail> GetBillDetail(int id)
        {
            List<BillDetail> listBillDetail = new List<BillDetail>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill_Details WHERE ID_Bill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillDetail info = new BillDetail(item);
                listBillDetail.Add(info);
            }

            return listBillDetail;
        }

        public void InsertBillDetail(int idBill, int idDish, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("QLNH_InsertBillDetail @idBill , @idFood , @count", new object[] { idBill, idDish, count });
        }

    }
}
