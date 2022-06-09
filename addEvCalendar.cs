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
    public partial class addEvCalendar : Form
    {
        public addEvCalendar()
        {
            InitializeComponent();
           

            fEvBox.Text = "Ввести время и название мероприятия";
            fEvBox.ForeColor = Color.Gray;

        }       

        private void fEvBox_Enter(object sender, EventArgs e)
        {
            if (fEvBox.Text == "Ввести время и название мероприятия")
            {
                fEvBox.Text = " ";
                fEvBox.ForeColor = Color.Black;
            }            
        }
        private void fEvBox_Leave(object sender, EventArgs e)
        {
            if (fEvBox.Text == " ")
            {
                fEvBox.Text = "Ввести время и название мероприятия";
                fEvBox.ForeColor = Color.Gray;
            }                
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEvButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Событие добавлено в календарь!");
            this.Close();
            
        }
    }
}
