using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class ProfitController
    {
        private static ProfitController instance;

        public static ProfitController Instance
        {
            get { if (instance == null) instance = new ProfitController(); return ProfitController.instance; }
            private set { ProfitController.instance = value; }
        }

        private ProfitController() { }

        //Lay doanh thu tu ngay a den ngay b
        public List<Profit> GetListProfit(DateTime start, DateTime finish)
        {
            List<Profit> list = new List<Profit>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec QLNH_Profit  @start , @finish", new object[] { start, finish });

            foreach (DataRow item in data.Rows)
            {
                Profit profit = new Profit(item);
                list.Add(profit);
            }

            return list;
        }



    }
}
