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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
          
        private void docButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servdocs servdocs = new Servdocs();
            servdocs.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }
    }
}
