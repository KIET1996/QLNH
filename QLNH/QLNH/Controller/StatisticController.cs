using QLNH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Controller
{
    public class StatisticController
    {
        private static StatisticController instance;

        public static StatisticController Instance
        {
            get { if (instance == null) instance = new StatisticController(); return StatisticController.instance; }
            private set { StatisticController.instance = value; }
        }

        private StatisticController() { }

        //Lay doanh thu tu ngay a den ngay b
        public List<Statistic> GetListStatistic(DateTime start, DateTime finish)
        {
            List<Statistic> list = new List<Statistic>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec QLNH_ProfitFollowDish  @start , @finish", new object[] { start, finish });

            foreach (DataRow item in data.Rows)
            {
                Statistic statistic = new Statistic(item);
                list.Add(statistic);
            }

            return list;
        }
    }
}
