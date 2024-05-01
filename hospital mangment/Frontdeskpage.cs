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
    public partial class Frontdeskpage : Form
    {
        public Frontdeskpage()
        {
            InitializeComponent();
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
            patient w1 = new patient();
            w1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointments w1 = new appointments();
            w1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            assignRoom w1 = new assignRoom();
            w1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientDetails w1 = new PatientDetails();
            w1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomDisplay w1 = new RoomDisplay();
            w1.Show();
        }
    }
}
