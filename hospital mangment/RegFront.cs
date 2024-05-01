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

namespace hospital_mangment
{
    public partial class RegFront : Form
    {
        HospitalDB_Context hospitalDB_Context;

        public RegFront()
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
                count = random.Next(3001,4000);
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
                if (name.Text != "" && date.Text != "" && gender.Text != "" && eMail.Text != "" && number.Text != "" &&
                    department.Text != "" && password.Text != "" && verifyPassword.Text != "")
                {
                    if (password.Text != verifyPassword.Text)
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                    else
                    {
                        int id = RandomID();
                        FrontDeskClass F1 = new FrontDeskClass(name.Text.ToString(), id, int.Parse(number.Text.ToString()),
                        date.Text.ToString(), gender.Text.ToString(),
                        eMail.Text.ToString(), password.Text.ToString(),
                     verifyPassword.Text.ToString(), department.Text.ToString());

                        hospitalDB_Context.FrontDesk.Add(new FrontDesk
                        {
                            Name = F1.name,
                            Id = F1.id,
                            Number = F1.number,
                            Date = F1.date,
                            Gender = F1.gender,
                            EMail = F1.eMail,
                            Password = F1.password,
                            Department = F1.department,
                            VerifyPassword = F1.verifyPassword
                        });
                        hospitalDB_Context.SaveChanges();
                        MessageBox.Show($"Staff Added with id {id} ");

                        this.Hide();
                        Frontdeskpage p1 = new Frontdeskpage();
                        p1.Show();

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

        private void sickness_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifyPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void eMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void emergencyNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegFront_Load(object sender, EventArgs e)
        {

        }
    }
}
