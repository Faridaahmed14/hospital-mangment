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
    public partial class Patientpage : Form
    {
        public Patientpage()
        {
            InitializeComponent();
        }

        private void Patientpage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            this.Hide();
            login w1 = new login();
            w1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDisplay w1 = new DoctorDisplay();
            w1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPassword w1 = new ResetPassword();
            w1.Show();
        }
    }
}
