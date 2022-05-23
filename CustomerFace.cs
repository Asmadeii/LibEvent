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
    public partial class CustomerFace : Form
    {
        public CustomerFace()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct Cfusst
        {
            public long cfcode;
            public string cname;
            public string cdol;
            public long cphone;
            public string cmail;

            public Cfusst(int _cfcode, string _cname, string _cdol, long _cphone, string _cmail)
            {
                cfcode = _cfcode;
                cname = _cname;
                cdol = _cdol;
                cphone = _cphone;
                cmail = _cmail;
            }
        }

        List<Cfusst> cfusst = new();


        private void CustomerFace_Load(object sender, EventArgs e)
        {
            cfusst.Add(new Cfusst(4641, "Саларьев Виктор Андреевич", "Менеджер", 89264908345, "salarva@mail.ru"));
            cfusst.Add(new Cfusst(9178, "Кропоткина Надежда Борисовна", "Директор", 89297491203, "kropotnb@mail.ru"));
            cfusst.Add(new Cfusst(4523, "Криговец Стеман Матвеевич", "Менеджер", 89103083445, "krigg@ya.ru"));
            cfusst.Add(new Cfusst(7521, "Звонарева Алевтина Григорьевна", "Частное лицо", 89983179382, "zvvonag@ya.ru"));

            table.Columns.Add("Код_отв_лица_зак", typeof(long));
            table.Columns.Add("ФИО", typeof(string));
            table.Columns.Add("Должность", typeof(string));
            table.Columns.Add("Контактный телефон", typeof(long));
            table.Columns.Add("E-mail", typeof(string));

            for (int i = 0; i < cfusst.Count; i++)
            {
                table.Rows.Add(cfusst[i].cfcode, cfusst[i].cname, cfusst[i].cdol, cfusst[i].cphone, cfusst[i].cmail);
            }
            CfusList.DataSource = table;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = CfusList.CurrentCell.RowIndex;
            CfusList.Rows.RemoveAt(rowIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(cfcodeBox.Text, nameBox.Text, dolBox.Text, phoBox.Text, mailBox.Text);
            CfusList.DataSource = table;
        }
    }
}
