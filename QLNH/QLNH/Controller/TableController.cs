using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNH.Model;

namespace QLNH.Controller
{
    public class TableController
    {
        private static TableController instance;

        public static TableController Instance
        {
            get { if (instance == null) instance = new TableController(); return TableController.instance; }
            private set { TableController.instance = value; }
        }

        public static int TableWidth = 95;
        public static int TableHeight = 95;

        private TableController() { }

        //Lấy danh sách bàn 
        public List<Table> ListTable()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("QLNH_ListTable");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        //Lấy tất cả các trường ra list table
        public List<Table> getListTable()
        {
            List<Table> table = new List<Table>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("QLNH_getListTable");

            foreach(DataRow item in dt.Rows)
            {
                Table tb = new Table(item);
                table.Add(tb);
            }
            return table;
        }


    }
}
