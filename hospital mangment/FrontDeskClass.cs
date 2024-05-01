using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace hospital_mangment
{
    internal class FrontDeskClass:PersonClass
    {
        public string department;
        public FrontDeskClass(string name, int id, int number, string date, string gender,
           string eMail, string password, string verifyPassword,string department)
  : base(name, id, number, date, gender, eMail, password, verifyPassword)
        {
            this.department = department;
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
