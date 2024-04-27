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

        public login()
        {
            HospitalDBContext = new HospitalDB_Context();
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome r1 = new welcome();
            r1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long id = long.Parse(textBox1.Text);
            string password = this.textBox2.Text;
            Register users = (from _user in HospitalDBContext.Register
                                  where _user.Id == id
                                  && _user.Password == password
                                  select _user).FirstOrDefault();


            if(users != null)
            {
                MessageBox.Show("Login success");
            }
            else
            {
                MessageBox.Show("login failed");
            }
            //this.Hide();
            //register r1 = new register();
            //r1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
