using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibEvent
{
    public partial class Pricelist : Form
    {
        public Pricelist()
        {
            InitializeComponent();           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pricedocs pricedocs = new Pricedocs();
            pricedocs.Show();
        }
    }
}
