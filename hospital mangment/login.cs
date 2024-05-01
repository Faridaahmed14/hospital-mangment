using hospital_mangment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_mangment
{
    public partial class login: Form
    {

        public HospitalDB_Context HospitalDBContext;
         public static long userID;
        public login()
        {
            HospitalDBContext = new HospitalDB_Context();
            InitializeComponent();
        }
      
        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            welcome w1 = new welcome();
            w1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                long id = long.Parse(textBox1.Text);
                string password = this.textBox2.Text;
                Register users = (from _user in HospitalDBContext.Register
                                  where _user.Id == id
                                  && _user.Password == password
                                  select _user).FirstOrDefault();

                if (users != null)
                {
                    MessageBox.Show("Login success");
                    login.userID = users.Id;
                }
                    if (id >= 0 && id <= 1000)
                    {
                        this.Hide();
                        Patientpage w1 = new Patientpage();
                        w1.Show();
                    }
                    else if (id >= 1001 && id <= 2000)
                    {
                        this.Hide();
                        Doctorpage w1 = new Doctorpage();
                        w1.Show();
                    }
                    else if (id >= 3001 && id <= 4000)
                    {
                        this.Hide();
                        Frontdeskpage w1 = new Frontdeskpage();
                        w1.Show();
                    }
                  
                else
                {
                    MessageBox.Show("login failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("enter correct id ");

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w1 = new welcome();
            w1.Show();
        }
    }
}
