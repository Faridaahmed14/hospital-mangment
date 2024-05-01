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
    public partial class welcome: Form
    {
        public welcome()
        {
            InitializeComponent();
        }

      

     
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login r1 = new login();
            r1.Show();

        }

        private void welcome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.RegDoctor' table. You can move, or remove it, as needed.
           // this.regDoctorTableAdapter.Fill(this.person_DatabaseDataSet.RegDoctor);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r1 = new register();
            r1.Show();
        }
    }
}
