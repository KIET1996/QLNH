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
        private int iD;
        private string position;
        private int capability;
        private int status;
        private int iD_pos;

        public Table(int id, string pos, int capa, int status, int id_pos)
        {
            this.ID = id;
            this.Position = pos;
            this.Capability = capa;
            this.Status = status;
            this.ID_pos = id_pos;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID_Table"];
            this.Position = row["Position"].ToString();
            this.Capability = (int)row["Capability"];
            this.Status = Convert.ToInt32(row["Status_Table"]);
            this.ID_pos = (int)row["ID_Pos"];
        }

       

        public int ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
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

        public int ID_pos
        {
            get
            {
                return iD_pos;
            }

            set
            {
                iD_pos = value;
            }
        }
    }
}
