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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct Cusst
        {
            public long cinn;
            public string cname;
            public string cadr;
            public long cphone;
            public string cmail;
            public int cfcode;

            public Cusst(long _cinn, string _cname, string _cadr, long _cphone, string _cmail, int _cfcode)
            {
                cinn = _cinn;
                cname = _cname;
                cadr = _cadr;
                cphone = _cphone;
                cmail = _cmail;
                cfcode = _cfcode;
            }
        }

        List<Cusst> cusst = new();

        private void Customer_Load(object sender, EventArgs e)
        {
            cusst.Add(new Cusst(408858612344, "Гусятки и Ко", "Москва, ул. Королькова, д. 14", 84955054637, "goose@goos.ru", 1238));
            cusst.Add(new Cusst(512975809237, "Слонопотам", "Москва, ул. Ландышевая, д. 87 ", 84956996032, "slonopotam@slon.ru", 4641));
            cusst.Add(new Cusst(433039876861, "Скатерть-самобранка", "Москва, ул. Фридриха Энгельса, д.2 ", 84954531025, "samobranka@skatert.ru", 6347));
            cusst.Add(new Cusst(795620813546, "Федорино Горе", "Москва, ул. Казакова, д. 63", 84997623941, "fedora@gore.ru", 9178));
            cusst.Add(new Cusst(237917442079, "Гончарный дом", "Москва, ул. Одинцовская, д. 87", 84954531025, "gonchar@dom.ru", 4523));


            table.Columns.Add("ИНН", typeof(long));
            table.Columns.Add("Наименование заказчика", typeof(string));
            table.Columns.Add("Юридический адрес", typeof(string));
            table.Columns.Add("Контактный телефон", typeof(long));
            table.Columns.Add("E-mail", typeof(string));
            table.Columns.Add("Код_отв_лица_зак", typeof(int));

            for (int i = 0; i < cusst.Count; i++)
            {
                table.Rows.Add(cusst[i].cinn, cusst[i].cname, cusst[i].cadr, cusst[i].cphone, cusst[i].cmail, cusst[i].cfcode);
            }
            CusList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(InnBox.Text, nameBox.Text, adrBox.Text, phoBox.Text, mailBox.Text, fcodeBox.Text);
            CusList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = CusList.CurrentCell.RowIndex;
            CusList.Rows.RemoveAt(rowIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }
    }
}
