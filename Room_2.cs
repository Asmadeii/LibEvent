using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibEvent
{
    public partial class Room_2 : Form
    {
        public Room_2()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room rooom = new Room();
            rooom.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_3 room_3 = new Room_3();
            room_3.Show();
        }
    }
}
