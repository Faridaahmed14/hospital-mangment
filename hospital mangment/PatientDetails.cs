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
    public partial class PatientDetails : Form
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage r1 = new Frontdeskpage();
            r1.Show();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.person_DatabaseDataSet.register);
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.register' table. You can move, or remove it, as needed.
            //  this.registerTableAdapter.Fill(this.person_DatabaseDataSet.register);

        }
    }
}
