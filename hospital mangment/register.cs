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
    public partial class register : Form
    {
        HospitalDB_Context hospitalDB_Context;

        public register()
        {
            hospitalDB_Context = new HospitalDB_Context();
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient p1 = new patient();
            p1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome p1 = new welcome();
            p1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegDoc p1 = new RegDoc();
            p1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegFront p1 = new RegFront();
            p1.Show();
        }


    }
}
