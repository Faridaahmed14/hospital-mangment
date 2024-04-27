using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class PatientClass : Person
    {
        public string sickness { get; set; }
        public string history { get; set; }
        public int emergencyNumber { get; set; }
        public PatientClass(string name, int id, int number, int emergencyNumber,string date, string gender,
            string address, string eMail, string password ,string sickness, string history,string verifyPassword )
                    : base(name, id, date, gender, number, password, address, eMail,verifyPassword)
        {
            this.sickness = sickness;
            this.history = history;
            this.emergencyNumber = emergencyNumber;

        }
    }
}
