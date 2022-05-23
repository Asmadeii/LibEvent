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
    public partial class Facildocs : Form
    {
        public Facildocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct Fdoc
        {
            public int fcode;
            public int ftcode;
            public string fname;
            public string fdescr;

            public Fdoc(int _fcode, int _ftcode,string _fname, string _fdescr)
            {
                fcode = _fcode;
                ftcode = _ftcode;
                fname = _fname;
                fdescr = _fdescr;
            }
        }

        List<Fdoc> fdocs = new List<Fdoc>();

        private void Facildocs_Load(object sender, EventArgs e)
        {
            FasList.AllowUserToAddRows = false;

            fdocs.Add(new Fdoc(094, 7392, "Кондиционер", "Расположен в помещениях библиотеки"));
            fdocs.Add(new Fdoc(063, 5625, "Велопарковка", "Расположена у входа в библиотеку"));
            fdocs.Add(new Fdoc(002, 3162, "Гардероб", "Расположен в помещении библиотеки на входе"));
            fdocs.Add(new Fdoc(007, 4561, "Игровая зона", "Расположена помещении библиотеки"));
            fdocs.Add(new Fdoc(078, 3183, "Розетки", "Расположены помещениях библиотеки"));
            fdocs.Add(new Fdoc(009, 6567, "Селфи-зона", "Расположена в помещении библиотеки"));
            fdocs.Add(new Fdoc(054, 2361, "Wi-Fi", "Доступен по всей библиотеке, необходим пароль"));

            
            table.Columns.Add("Код удобства", typeof(int));
            table.Columns.Add("Код вида удобства", typeof(int));
            table.Columns.Add("Наименование удобства", typeof(string));
            table.Columns.Add("Краткое описание", typeof(string));

            for (int i = 0; i < fdocs.Count; i++)
            {
                table.Rows.Add(fdocs[i].fcode, fdocs[i].ftcode, fdocs[i].fname, fdocs[i].fdescr);
            }
            FasList.DataSource = table;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(codBox.Text, codTBox.Text, nameBox.Text, descBox.Text);
            FasList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = FasList.CurrentCell.RowIndex;
            FasList.Rows.RemoveAt(rowIndex);
        }
    }
}
