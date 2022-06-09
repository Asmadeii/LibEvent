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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
 
        private void btnPartn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Partners partners = new Partners();
            partners.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoPovod infoPovod = new InfoPovod();
            infoPovod.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventList eventList = new EventList();
            eventList.Show();

        }
    }
}
