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
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient p1 = new patient();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff d1 = new staff();
            d1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w1 = new welcome();
            w1.Show();
        }
    }
}
