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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace hospital_mangment
{
    public partial class ResetPassword : Form
    {
        public HospitalDB_Context HospitalDBContext;

        public ResetPassword()
        {
            HospitalDBContext = new HospitalDB_Context();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patientpage w1 = new Patientpage();
            w1.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (newPass.Text != "" && confirmPass.Text != ""  )
                {
                    if (newPass.Text != confirmPass.Text)
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                    else
                    {
                        UpdatePassClass P1 = new UpdatePassClass(newPass.Text.ToString(), confirmPass.Text.ToString(), int.Parse(id1.Text.ToString()));
                        Register users = (from _user in HospitalDBContext.Register
                                          where _user.Id == login.userID
                                          select _user).FirstOrDefault();

                        users.Password = newPass.Text;
                        HospitalDBContext.SaveChanges();
                        MessageBox.Show($"Password updated ");
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

        private void newPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            
        }
    }
}
