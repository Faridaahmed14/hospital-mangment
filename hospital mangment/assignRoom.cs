using hospital_mangment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace hospital_mangment
{
    public partial class assignRoom : Form
    {
        HospitalDB_Context hospitalDB_Context;

        public assignRoom()
        {
            hospitalDB_Context = new HospitalDB_Context();
            InitializeComponent();
        }
        public int RandomID()
        {
            Random random = new Random();
            var numbers = new List<int>();
            int count;
            do
            {
                count = random.Next(0, 100);
            }
            while (numbers.Contains(count));
            numbers.Add(count);
            return count;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage w1 = new Frontdeskpage();
            w1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && department.Text != "" && id.Text != "" &&
                    doctor.Text != "")
                {
                    int room = RandomID();
                    RoomClass R1 = new RoomClass(name.Text.ToString(), int.Parse(id.Text.ToString()), department.Text.ToString(),
                    doctor.Text.ToString(), room);

                    hospitalDB_Context.Rooms.Add(new Rooms
                    {
                        Name = R1.name,
                        Id = R1.id,
                        Doctor = R1.doctor,
                        Department = R1.department,
                        Room = R1.room,
                    });
                    hospitalDB_Context.SaveChanges();
                    MessageBox.Show($"Room Assigned,your rooom is{room}");
                }
                else
                    MessageBox.Show("Fill in the blanks!");

            }
            catch (Exception ex)
            { 
              MessageBox.Show(ex.Message);
            }
        }

        private void room_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
