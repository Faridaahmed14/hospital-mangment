using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    internal class Person
    {
    public string name { get; set; }
    public string date { get; set; }
    public int id { get; set; }
    public string gender { get; set; }
    public int number { get; set; }
    public string password { get; set; }
    public string verifyPassword { get; set; }

    public string address { get; set; }
    public string eMail { get; set; }



    public Person(string name, int id,string date,string gender,int number,string password,string address,string eMail,string verifyPassword)
        {
            this.name = name;
            this.date = date;
            this.id = id;
            this.gender = gender;
            this.number = number;
            this.password = password;
        this.verifyPassword = verifyPassword;
            this.address = address;
            this.eMail = eMail;
        }
   
        virtual public float bills(float rate, int days)
        {
            return rate * days;
        }
        virtual public float hourlysalary(float rate, int hourly)
        {
            return rate * hourly;
        }
        virtual public void ScheduleAppointment(int date, string Doctor)
        {

        }
    }