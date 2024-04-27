using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital_mangment
{
    internal class LoginForm
    {
        public int id { get; set; }
        public string password { get; set; }
        public LoginForm( int id, string password)
        {
            this.id = id;
            this.password = password;
        }
    }
}
