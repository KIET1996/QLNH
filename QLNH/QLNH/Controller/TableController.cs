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

        //Lay danh sach ban va hien thi id position
        public List<Table_Management> getListTable()
        {
            List<Table_Management> gettableList = new List<Table_Management>();

            DataTable data = DataProvider.Instance.ExecuteQuery("QLNH_getListTable");

            foreach (DataRow item in data.Rows)
            {
                Table_Management table = new Table_Management(item);
                gettableList.Add(table);
            }

            return gettableList;
        }

        //Insert table
        public bool InsertTable(int idpos, int capa, int sta)
        {
            string sql = string.Format("INSERT INTO Table_Management (ID_Pos, capability, sta) VALUES ('{0}', '{1}', '{2}')", idpos, capa, sta );
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;

        }
        
        //Delete table
        public bool DeleteTable(int ID_Table)
        {
            string sql = string.Format("DELETE Table_Management WHERE ID_Table = '{0}'", ID_Table);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

        //Update information table
        public bool UpdateTable(int ID_Table, int ID_Pos, int Capa, int Sta)
        {
            string sql = string.Format("UPDATE Table_Management SET ID_Pos = {0}, capability = '{1}', Sta = '{2}' where ID_Table = '{3}'",  ID_Pos, Capa, Sta, ID_Table);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

    }
}
