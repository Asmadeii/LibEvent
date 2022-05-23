using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LibEvent
{
    public partial class BankView : Form
    {     
        public BankView()
        {
            InitializeComponent();
        }

        DataTable table = new();

        public struct Bank
        {
            public long bankcode;
            public string adress;
            public string bankname;
            public long bankphone;
            public long bankcacc;

            public Bank(long _bankcode, string _adress, string _bankname, long _bankphone, long _bankcacc)
            {
                bankcode = _bankcode;
                adress = _adress;
                bankname = _bankname;
                bankphone = _bankphone;
                bankcacc = _bankcacc;
            }
        }

        List<Bank> banks = new();    

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new();
            directory.Show();
        }

        private void BankView_Load(object sender, EventArgs e)
        {
            banks.Add(new Bank(403858638, "Москва, ул. Перерва, д. 24", "Юстус", 84994560231, 02249027483534134785));
            banks.Add(new Bank(503324728, "Москва, ул. Иловайская, д. 45", "Алекс", 84955167925, 4714524522345444645));
            banks.Add(new Bank(724031537, "Москва, ул. Наримановская, д. 67", "Альфа", 84957662053, 3112315313551332852));
            banks.Add(new Bank(340360492, "Москва, ул. Токарная, д. 4", "Центавра", 84998858638, 2804534544542017493));
            banks.Add(new Bank(969888754, "Москва, ул. Лосиноостровская, д. 33", "Сид", 84957056932, 2731703492234348083));
            banks.Add(new Bank(117056932, "Москва, ул. Выборгская, д. 15", "Нэнси", 84996969888, 8943523452345396795));        

            table.Columns.Add("БИК", typeof(long));
            table.Columns.Add("Адрес отделения банка", typeof(string));
            table.Columns.Add("Наименование банка", typeof(string));
            table.Columns.Add("Телефон банка", typeof(long));
            table.Columns.Add("Корреспондентский счет", typeof(long));

            for (int i = 0; i < banks.Count; i++)
            {
                table.Rows.Add(banks[i].bankcode, banks[i].adress, banks[i].bankname, banks[i].bankphone, banks[i].bankcacc);
            }
            BankList.DataSource = table;
        }

        

        private void BAddButton_Click(object sender, EventArgs e)
        {   
            table.Rows.Add(BycBox.Text, adrBox.Text, bnameBox.Text, phoBox.Text, krrBox.Text);
            BankList.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = BankList.CurrentCell.RowIndex;
            BankList.Rows.RemoveAt(rowIndex);
        }

    }  
}

