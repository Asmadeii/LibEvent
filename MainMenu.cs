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

    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pricelist pricelist= new Pricelist();
            pricelist.Show();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Events events = new Events();
            events.Show();
        }

        private void contractButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contractdocs contractdocs = new Contractdocs();
            contractdocs.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
