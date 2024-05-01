using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class PatientClass : PersonClass
    {
        public string sickness { get; set; }
        public string history { get; set; }
        public int emergencyNumber { get; set; }
        public string address { get; set; }

        public PatientClass(string name, int id, int number, int emergencyNumber,string date, string gender,
            string address, string eMail, string password ,string sickness, string history,string verifyPassword )
                    : base(name, id, number, date, gender, eMail, password,verifyPassword)
        {
            this.sickness = sickness;
            this.history = history;
            this.emergencyNumber = emergencyNumber;
            this.address = address;
        }
        public override void DisplayInformation()
        {
            Console.WriteLine($"Doctor Name: {name}");
            Console.WriteLine($"Doctor Name: {id}");
            Console.WriteLine($"Age: {date}");
            Console.WriteLine($"Gender: {gender}");
        }
    }
}
