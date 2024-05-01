using hospital_mangment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace hospital_mangment
{
    public partial class appointments : Form
    {
        HospitalDB_Context hospitalDB_Context;

        public appointments()
        {
            hospitalDB_Context = new HospitalDB_Context();
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && date.Text != "" && department.Text != "" && id.Text != "" &&
                    doctor.Text != "" && room.Text != "" && time.Text != "")
                { 

                AppointmentClass A1 = new AppointmentClass(name.Text.ToString(), int.Parse(id.Text.ToString()), department.Text.ToString(),
                doctor.Text.ToString(), date.Text.ToString(), time.Text.ToString(),
                room.Text.ToString());


                hospitalDB_Context.Appointments.Add(new Appointments
                {
                    Name = A1.name,
                     Id = A1.id,
                    Doctor = A1.doctor,
                  Department=A1.department,
                    Time = A1.time,
                    Room = A1.room,
                    Date = A1.date,
                });

                hospitalDB_Context.SaveChanges();
                MessageBox.Show($"appoitment Added ");
     
                this.Hide();
                Frontdeskpage r1 = new Frontdeskpage();
                r1.Show();
                 }
                else         
                    MessageBox.Show("Fill in the blanks!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage r1 = new Frontdeskpage();
            r1.Show();
        }

        private void doctor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
