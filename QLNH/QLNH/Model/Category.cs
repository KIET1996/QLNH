using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Category
    {
        private int id_Ca;
        private string name;

        public Category(int id_Ca, string name)
        {
            this.Id_Ca = id_Ca;
            this.Name = name;
        }

        public Category(DataRow row)
        {
            this.Id_Ca = (int)row["ID_Ca"];
            this.Name = row["name"].ToString();
        }

        public int Id_Ca
        {
            get
            {
                return id_Ca;
            }

            set
            {
                id_Ca = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
