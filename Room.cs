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
    public partial class Room : Form
    {
       /* Font myFont;
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
        public Room()
        {
            InitializeComponent();
            /*LoadFont();
            LoadFont2();
            autoLabel.Font = headFont;
            backButton.Font = myFont;*/
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void room1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_1 room1 = new Room_1();
            room1.Show();
        }

        private void room2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_2 room2 = new Room_2();
            room2.Show();
        }

        private void room3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_3 room3 = new Room_3();
            room3.Show();
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roomdocs roomdocs  = new Roomdocs();
            roomdocs.Show();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }
    }
}
