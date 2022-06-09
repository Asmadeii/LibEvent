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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        

        public void days (int numday)
        {
            lbdays.Text = numday + " ";
        }     

        public void evnt (string evtext)
        {
            text_1.Text = evtext;
        }
     
        private void lbdays_Click(object sender, EventArgs e)
        {

        }

        private void addEventButton_Doubleclick(object sender, EventArgs e)
        {
            addEvCalendar evCalendar = new addEvCalendar();
            evCalendar.Show();
        }

    }
}
