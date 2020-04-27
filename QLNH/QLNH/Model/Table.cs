using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLNH.Model
{
    public class Table
    {
        private int iD_Table;
        private string position;
        private int capability;
        private int status;
        private int iD_Position;
        
       
        public Table(int id_table, string pos, int capa, int status, int id_pos)
        {
            this.ID_Table = id_table;
            this.Position = pos;
            this.Capability = capa;
            this.Status = status;
            this.ID_Pos = id_pos;
        }

        public Table(DataRow row)
        {
            this.ID_Table = (int)row["ID_Table"];
            //this.Position = row["Position"].ToString();
            this.Capability = (int)row["capability"];
            this.Status = Convert.ToInt32(row["sta"]);
            this.ID_Pos = (int)row["ID_Pos"];
        }

       
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public int Capability
        {
            get
            {
                return capability;
            }

            set
            {
                capability = value;
            }
        }

        public int ID_Table
        {
            get
            {
                return iD_Table;
            }

            set
            {
                iD_Table = value;
            }
        }

        public int ID_Pos
        {
            get
            {
                return iD_Position;
            }
            set
            {
                iD_Position = value;
            }
        }
    }
}
