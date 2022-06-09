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
        /*Font myFont;
        Font headFont;
        private void LoadFont()
        {
            PrivateFontCollection librFont = new PrivateFontCollection();
            librFont.AddFontFile("LibFont.ttf");
            myFont = new Font(librFont.Families[0], 18);
        }
        private void LoadFont2()
        {
            PrivateFontCollection librFont = new PrivateFontCollection();
            librFont.AddFontFile("LibFont.ttf");
            headFont = new Font(librFont.Families[0], 32);
        }*/
        public MainMenu()
        {
            InitializeComponent();
            /*LoadFont();
            LoadFont2();
            autoLabel.Font=headFont;
            closeButton.Font=myFont;            
            backButton.Font=myFont;

            eventButton.Font = myFont;
            contractButton.Font = myFont;
            priceButton.Font = myFont;*/
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
            Contracts contracts = new Contracts();
            contracts.Show();
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
