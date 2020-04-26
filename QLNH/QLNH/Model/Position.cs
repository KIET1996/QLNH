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
        private int idPos;
        private string namePos;
        private string statusPos;
        private string notePos;

        public Position(int idPos, string namePos, string statusPos, string notePos)
        {
            this.IDPos = idPos;
            this.NamePos = namePos;
            this.StatusPos = statusPos;
            this.NotePos = notePos;
        }

        public Position(DataRow row)
        {
            this.IDPos = (int)row["ID_Pos"];
            this.NamePos = row["position"].ToString();
            this.StatusPos = row["sta"].ToString();
            this.NotePos = row["note"].ToString();
        }

        public int IDPos
        {
            get
            {
                return idPos;
            }
            set
            {
                idPos = value;
            }
        }

        public string NamePos
        {
            get
            {
                return namePos;
            }
            set
            {
                namePos = value;
            }
        }

        public string StatusPos
        {
            get
            {
                return statusPos;
            }
            set
            {
                statusPos = value;
            }
        }

        public string NotePos
        {
            get
            {
                return notePos;
            }
            set
            {
                notePos = value;
            }
        }
        
    }
}
