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
    public partial class Facilities : Form
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
        public Facilities()
        {
            InitializeComponent();
           /* LoadFont();
            LoadFont2();
            autoLabel.Font = headFont;
            backButton.Font = myFont;

            fasText.Font = myFont;
            facildoc.Font = myFont;*/
        }

       

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        private void facildoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facildocs facildocs = new Facildocs();
            facildocs.Show();
        }

        
    }
}
