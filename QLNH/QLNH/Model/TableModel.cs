using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLNH.Model
{
    class TableModel
    {
        private int iD;
        private string position;
        private int capability;
        private int status;
        private int iD_pos;

        public TableModel(int id, string pos, int capa, int status, int id_pos)
        {
            this.ID = id;
            this.Position = pos;
            this.Capability = capa;
            this.Status = status;
            this.ID_pos = id_pos;
        }

        public TableModel(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Position = row["position"].ToString();
            this.Capability = (int)row["capability"];
            this.Status = (int) row["status"];
            this.ID_pos = (int)row["id_pos"];
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
