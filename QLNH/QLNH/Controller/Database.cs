using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLNH.Controller
{
    class Database
    {
        public static SqlConnection con;
        
        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=DESKTOP-ACK104U\\SQLEXPRESS; Database = QL_NhaHang;  uid = mylogin; pwd=mylogin ");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
