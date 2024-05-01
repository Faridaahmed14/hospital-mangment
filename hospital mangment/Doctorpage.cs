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
    public partial class Doctorpage : Form
    {
        public HospitalDB_Context HospitalDBContext;

        public Doctorpage()
        {
            HospitalDBContext = new HospitalDB_Context();
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login w1 = new login();
            w1.Show();
        }
        private void Doctorpage_Load(object sender, EventArgs e)
        {
            this.registerTableAdapter.Fill(this.person_DatabaseDataSet.register);
          
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
