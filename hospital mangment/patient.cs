using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;
using hospital_mangment.Models;


namespace hospital_mangment
{
    public partial class patient : Form
    {
        HospitalDB_Context hospitalDB_Context;
        public patient()
        {
            hospitalDB_Context = new HospitalDB_Context();
            InitializeComponent();
        }
         public int RandomID()
         {
            Random random = new Random();
            var numbers= new List<int>();
            int count;
            do
            {
                count = random.Next(0, 1000);
            }
            while (numbers.Contains(count));
            numbers.Add(count);
            return count;
         }
  
        

        private void patient_Load(object sender, EventArgs e)
        {

        }

  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage r1 = new Frontdeskpage();
            r1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && date.Text != "" && gender.Text != "" && eMail.Text != "" && number.Text != "" &&
                    emergencyNumber.Text != "" && sickness.Text != "" && history.Text != "" && address.Text != "" && password.Text != "" && verifyPassword.Text != "")
                {
                    if (password.Text != verifyPassword.Text)
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                    else
                    {
                        int id = RandomID();
                        PatientClass P1 = new PatientClass(name.Text.ToString(), id, int.Parse(number.Text.ToString()),
                        int.Parse(emergencyNumber.Text.ToString()), date.Text.ToString(), gender.Text.ToString(),
                        address.Text.ToString(), eMail.Text.ToString(), password.Text.ToString(), sickness.Text.ToString(),
                        history.Text.ToString(), verifyPassword.Text.ToString());
                   
                        hospitalDB_Context.Register.Add(new Register
                        {
                            Name = P1.name,
                            Id = P1.id,
                            Number = P1.number,
                            EmergencyNumber = P1.emergencyNumber,
                            Date = P1.date,
                            History = P1.history,
                            Gender = P1.gender,
                            Address = P1.address,
                            EMail = P1.eMail,
                            Password = P1.password,
                            Sickness = P1.sickness,
                            VerifyPassword = P1.verifyPassword
                        });
                        hospitalDB_Context.SaveChanges();
                        MessageBox.Show($"Patient Added with id {id} ");

                        this.Hide();
                        Patientpage r1 = new Patientpage();
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
    }
}
