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
    public partial class DoctorDisplay : Form
    {
        public DoctorDisplay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patientpage w1 = new Patientpage();
            w1.Show();
        }

        private void DoctorDisplay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.RegDoctor' table. You can move, or remove it, as needed.
            this.regDoctorTableAdapter.Fill(this.person_DatabaseDataSet.RegDoctor);

        }
    }
}
