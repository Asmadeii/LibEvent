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
    public partial class Directory : Form
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

            public Directory()
        {
            InitializeComponent();
            /*LoadFont();
            LoadFont2();
            autoLabel.Font = headFont;
            backButton.Font = myFont;

            customerButton.Font = myFont;
            custfaceButton.Font = myFont;
            executorButton.Font = myFont;
            execfaceButton.Font = myFont;  
            bankButton.Font = myFont;
            custcheckButton.Font = myFont;
            execcheckButton.Font = myFont;
            contrstateButton.Font = myFont;
            roomButton.Font= myFont;
            equipButton.Font = myFont;
            serviceButton.Font = myFont;
            faciButton.Font = myFont;*/

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu(); 
            mainMenu.Show();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room room = new Room();
            room.Show();
        }

        private void faciButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facilities facilities = new Facilities();  
            facilities.Show();
        }

        

        private void serviceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.Show();
        }              

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        

        private void bankButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankView bankView = new BankView();
            bankView.Show();
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipment equipment = new Equipment();
            equipment.Show();
        }

        private void execcheckButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillExecutor executor = new BillExecutor();
            executor.Show();
        }

        private void custcheckButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillCustomer customer = new BillCustomer();
            customer.Show();
        }

        private void contrstateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContractCond contractCond = new ContractCond();
            contractCond.Show();
        }

        private void custfaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFace customerface = new CustomerFace();
            customerface.Show();
        }

        private void execfaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExecutorFace executorFace = new ExecutorFace();
            executorFace.Show();
        }

        private void executorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Executor exec = new Executor();
            exec.Show();
        }
    }
}
