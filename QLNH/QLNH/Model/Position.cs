using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH.Model
{
    class Position
    {
        private int IDPosition;
        private string position;
        private string status;
        private string note;

        public Position(int id_pos, string pos, string sta, string note)
        {
            this.ID_Position = id_pos;
            this.NamePosition = pos;
            this.Status = sta;
            this.Note = note;
        }

        public int ID_Position
        {
            get
            {
                return ID_Position;
            }
            set
            {
                ID_Position = value;
            }
        }
        public string NamePosition
        {
            get
            {
                return NamePosition;
            }
            set
            {
                NamePosition = value;
            }
        }

        public string Status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }
        public string Note
        {
            get
            {
                return Note;
            }
            set
            {
                Note = value;
            }
        }
    }
}
