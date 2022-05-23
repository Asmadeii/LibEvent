using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibEvent
{
    public partial class Events : Form
    {
        int month, year;
      
        public Events()
        {
            InitializeComponent();
            
        }

        private void Events_Load(object sender, EventArgs e)
        {
            DisplaDays();
        }

        private void DisplaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            DateTime startofthemonth = new(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 7;

            for(int i = 1; i<dayoftheweek;i++ )
            {
                UserControlBlank ucblank = new();
                dayContainer.Controls.Add((ucblank));
            }
            for (int i = 0; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i+1);
                dayContainer.Controls.Add((ucdays));
            }
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + "  " + year;

            DateTime startofthemonth = new(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new();
                dayContainer.Controls.Add((ucblank));
            }
            for (int i = 0; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i+1);
                dayContainer.Controls.Add((ucdays));
            }
        }

        private void docButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eventdocs eventdocs = new Eventdocs();
            eventdocs.Show();
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;

            DateTime startofthemonth = new(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new();
                dayContainer.Controls.Add((ucblank));
            }
            for (int i = 0; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i+1);
                dayContainer.Controls.Add((ucdays));
            }
        }
    }
}
