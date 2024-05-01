using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class PersonClass:Person
    {
        public PersonClass(string name, int id, int number,  string date, string gender,
            string eMail, string password, string verifyPassword)
                    : base(name, id, date, gender, number, password, eMail, verifyPassword)
        {
        }
        public virtual void DisplayInformation()
        {

        }
    }
}
