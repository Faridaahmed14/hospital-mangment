using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace hospital_mangment.Models
{
    public partial class FrontDesk
    {
        public string Name { get; set; }
        public long Number { get; set; }
        public long Id { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Department { get; set; }
        public string Date { get; set; }
        public string VerifyPassword { get; set; }
    }
}
