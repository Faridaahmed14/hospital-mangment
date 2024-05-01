using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal abstract class Person
    {
    public string name { get; set; }
    public string date { get; set; }
    public int id { get; set; }
    public string gender { get; set; }
    public int number { get; set; }
    public string password { get; set; }
    public string verifyPassword { get; set; }

    public string eMail { get; set; }



    public Person(string name, int id,string date,string gender,int number,string password,string eMail,string verifyPassword)
        {
            this.name = name;
            this.date = date;
            this.id = id;
            this.gender = gender;
            this.number = number;
            this.password = password;
            this.verifyPassword = verifyPassword;
            this.eMail = eMail;
        }
 
    public void bills(float rate, int days)
        {
        }
        virtual public void hourlysalary(float rate, int hourly)
        {
        }
        virtual public void ScheduleAppointment(int date, string Doctor)
        {

        }
    }