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


      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login r1 = new login();
            r1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r1 = new register();
            r1.Show();
        }
    }
}
