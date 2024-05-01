using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    public class AppointmentClass
   
    {
     public string time { get; set; }
     public string date { get; set; }
      public string doctor { get; set; }
      public string name { get; set; }
      public string  department { get; set; }
      public  string room { get; set; }
      public int id { get; set; }

        public AppointmentClass(string name, int id, string department, string doctor,string date,string time,  string room)
        {
            this.time = time;
            this.room = room;       
            this.id = id;
            this.date = date;
            this.doctor = doctor;
            this.name = name;
            this.department = department;
        }
    }
}
