using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    public class Position
    {
        private int iD_Pos;
        private string pos;
        private string sta;
        private string note;

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

        public string Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }

        public string Sta
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

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public Position(DataRow row)
        {
            this.ID_Pos = (int)row["ID_Pos"];
            this.Pos = row["position"].ToString();
            this.Sta = row["sta"].ToString();
            this.Note = row["note"].ToString();
        }

        public Position(int iD_Pos, string position, string sta, string note)
        {
            this.ID_Pos = iD_Pos;
            this.Pos = position;
            this.Sta = sta;
            this.Note = note;
        }
    }
}
