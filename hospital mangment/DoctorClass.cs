using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_mangment
{
    internal class DoctorClass:PersonClass
    {
        public string specialization { get; set; }
        public DoctorClass(string name, int id, int number, string date, string gender,
      string eMail, string password, string verifyPassword, string specialization)
                : base(name, id, number, date, gender, eMail, password, verifyPassword)
        {
            this.specialization = specialization;
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
