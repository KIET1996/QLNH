using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH.Model;
using System.Data.SqlClient;

namespace QLNH.Controller
{
    public class PositionController
    {
        private static PositionController instance;
        public static PositionController Instance
        {
            get { if (instance == null) instance = new PositionController(); return PositionController.instance; }
            private set { PositionController.instance = value; }
        }

        private PositionController() { }

        //Lay danh sach position
        public List<Position> getListPosition()
        {
            List<Position> list = new List<Position>();
            string sql = "SELECT * FROM Position_Table";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow item in data.Rows)
            {
                Position pos = new Position(item);
                list.Add(pos);
            }
            return list;
        }
    }
}
