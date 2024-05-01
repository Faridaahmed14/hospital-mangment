using hospital_mangment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_mangment
{
    public partial class DeletePatient : Form
    {
        HospitalDB_Context hospitalDB_Context;

        public DeletePatient()
        {
            hospitalDB_Context = new HospitalDB_Context();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage r1 = new Frontdeskpage();
            r1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //if (delete.Text == " ")
            //    MessageBox.Show("Enter the id");
            //else
            //{
            //    long id = long.Parse(delete.Text);
            //    hospitalDB_Context = new HospitalDB_Context();

            //    Register users = (from _user in HospitalDBContext.Register
            //                      where _user.Id == id
            //                      select _user).FirstOrDefault();
            //}
        }
    }
}
