using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class RoomClass
    {
        public string doctor { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int room { get; set; }
        public int id { get; set; }

        public RoomClass(string name, int id, string department, string doctor,  int room)
        {
            this.room = room;
            this.id = id;
            this.doctor = doctor;
            this.name = name;
            this.department = department;
        }
    }
}
