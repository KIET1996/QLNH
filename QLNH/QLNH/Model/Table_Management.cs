using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Table_Management
    {
        private int iD_Table;
        private int iD_Pos;
        private int capa;
        private int sta;

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
                return iD_Pos;
            }

            set
            {
                iD_Pos = value;
            }
        }

        public int Capa
        {
            get
            {
                return capa;
            }

            set
            {
                capa = value;
            }
        }

        public int Sta
        {
            get
            {
                return sta;
            }

            set
            {
                sta = value;
            }
        }

        public Table_Management(int iD_Table, int iD_Pos, int capa, int sta)
        {
            this.ID_Table = iD_Table;
            this.ID_Pos = iD_Pos;
            this.Capa = capa;
            this.Sta = sta;
        }

        public Table_Management(DataRow row)
        {
            this.ID_Table = (int)row["ID_Table"];
            this.ID_Pos = (int)row["ID_Pos"];
            this.Capa = (int)row["Capability"];
            this.Sta = Convert.ToInt32(row["sta"]);

        }
    }
}
