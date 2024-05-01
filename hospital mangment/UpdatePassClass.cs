using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class UpdatePassClass
    {
        public string password { get; set; }
        public string verifyPassword { get; set; }
        public int id { get; set; }

        public UpdatePassClass(string password, string verifyPassword, int id)
        {
            this.password = password;
            this.verifyPassword = verifyPassword;
            this.id = id;
        }
    }
}
  
