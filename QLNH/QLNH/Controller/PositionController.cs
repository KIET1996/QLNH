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

        //get position by id
        public Position getPositionByID(int id)
        {
            Position position = null;
            string sql = string.Format("SELECT * FROM Position_Table where ID_Pos = " + id);

            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow item in data.Rows)
            {
                position = new Position(item);
                return position;
            }
            return position;
        }

        //Thêm vị trí
        public bool AddPosition(string pos, string sta, string note)
        {
            string sql = string.Format("INSERT INTO Position_Table VALUES ( '{0}', '{1}', '{2}')", pos, sta, note);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

        //Delete position 
        public bool DeletePosition(int ID_Pos)
        {
            string sql = string.Format("DELETE Position_Table WHERE ID_Pos = '{0}'", ID_Pos);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

        //Update information position
        public bool UpdatePosition(int ID_Pos, string name, string Sta, string note)
        {
            string sql = string.Format("UPDATE Position_Table SET position = '{0}', sta = '{1}', note = '{2}' where ID_Pos = '{3}'", name, Sta, note, ID_Pos);
            int result = DataProvider.Instance.ExecuteNonQuery(sql);

            return result > 0;
        }

        //Check xem vi tri co ton tai khong
        public bool CheckPosition(string pos)
        {
            string sql = string.Format("SELECT COUNT(*) from Position_Table where position = '{0}'", pos);
            int result = (Int32)DataProvider.Instance.ExecuteScalar(sql);
            return result > 0;
        }

        //thuc hien truy van lay ve ma so lon nhat IDPOS, xoa trang cac truong them vao thong qua phuong thuc resetfields
        public bool CheckAddPos(int ID_Pos)
        {
            string sql = string.Format("SELECT MAX(ID_Pos) FROM Position_Table where ID_Pos = '{0}'", ID_Pos);
            int result = (Int32)DataProvider.Instance.ExecuteScalar(sql);
            return result > 0;
        }


    }
}
