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
    public partial class Room_1 : Form
    {
        public Room_1()
        {
            InitializeComponent();
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room rooom = new Room();
            rooom.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_2 room = new Room_2();
            room.Show();
        }
    }
}
