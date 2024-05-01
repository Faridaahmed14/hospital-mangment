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
    public partial class RoomDisplay : Form
    {
        public RoomDisplay()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontdeskpage w1 = new Frontdeskpage();
            w1.Show();
        }

        private void RoomDisplay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.person_DatabaseDataSet.rooms);
            // TODO: This line of code loads data into the 'person_DatabaseDataSet.rooms' table. You can move, or remove it, as needed.
            //   this.roomsTableAdapter.Fill(this.person_DatabaseDataSet.rooms);

        }
    }
}
