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
        

        public Table(int id, string pos, int capa, int status)
        {
            this.ID = id;
            this.Position = pos;
            this.Capability = capa;
            this.Status = status;
        
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID_Table"];
            this.Position = row["Position"].ToString();
            this.Capability = (int)row["capability"];
            this.Status = Convert.ToInt32(row["sta"]);
           
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

      
    }
}
