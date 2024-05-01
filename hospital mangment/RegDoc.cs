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

namespace hospital_mangment
{
    public partial class RegDoc : Form
    {
        HospitalDB_Context hospitalDB_Context;
        public RegDoc()
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
                count = random.Next(1001, 2000);
            }
            while (numbers.Contains(count));
            numbers.Add(count);
            return count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            register p1 = new register();
            p1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && date.Text != "" && gender.Text != "" && eMail.Text != "" && number.Text != "" 
                       && password.Text != "" && verifyPassword.Text != "" && specialization.Text != "")
                {
                    if (password.Text != verifyPassword.Text)
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                    else
                    {
                        int id = RandomID();
                        DoctorClass D1 = new DoctorClass(name.Text.ToString(), id, int.Parse(number.Text.ToString()),
                        date.Text.ToString(), gender.Text.ToString(),
                       eMail.Text.ToString(), password.Text.ToString(),
                        verifyPassword.Text.ToString(),specialization.Text.ToString());

                        hospitalDB_Context.RegDoctor.Add(new RegDoctor
                        {
                            Name = D1.name,
                            Id = D1.id,
                            Number = D1.number,
                            Date = D1.date,
                            Gender = D1.gender,
                            EMail = D1.eMail,
                            Password = D1.password,
                           Specialization = D1.specialization,
                            VerifyPassword = D1.verifyPassword
                        });
                        hospitalDB_Context.SaveChanges();
                        MessageBox.Show($"Doctor Added with id {id} ");

                        this.Hide();
                        Doctorpage r1 = new Doctorpage();
                        r1.Show();
                    }
                }
                else
                    MessageBox.Show("Fill in the blanks!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegDoc_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
