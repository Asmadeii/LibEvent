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
    public partial class Contracts : Form
    {
        int i = 1;
        public Contracts()
        {
            InitializeComponent();

        }

        private void Contracts_Load(object sender, EventArgs e)
        {
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;

            if (i > 5)
            {
                i = 1;
            }

            changeImage(i);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 5;
            }

            changeImage(i);
        }

        private void changeImage(int num)
        {
            switch(num)
            {
                case 1:
                    picBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    picBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    picBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    picBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    picBox.Image = Properties.Resources._5;
                    break;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contractdocs contractdocs = new Contractdocs();
            contractdocs.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
