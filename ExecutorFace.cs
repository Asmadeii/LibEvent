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
    public partial class ExecutorFace : Form
    {
        public ExecutorFace()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct Efusst
        {
            public long cfcode;
            public string cname;
            public string cdol;
            public long cphone;
            public string cmail;

            public Efusst(int _cfcode, string _cname, string _cdol, long _cphone, string _cmail)
            {
                cfcode = _cfcode;
                cname = _cname;
                cdol = _cdol;
                cphone = _cphone;
                cmail = _cmail;
            }
        }

        List<Efusst> efusst = new();


        private void ExecutorFace_Load(object sender, EventArgs e)
        {
            efusst.Add(new Efusst(3852, "Анисимова Анастасия Петровна", "Старший библиотекарь", 8916497334, "aniicap@mail.ru"));
            efusst.Add(new Efusst(3852, "Галарьева Виктория Михайловна", "Библиотекарь", 89097499833, "galarvm@mail.ru"));
            

            table.Columns.Add("Код_отв_лица_зак", typeof(long));
            table.Columns.Add("ФИО", typeof(string));
            table.Columns.Add("Должность", typeof(string));
            table.Columns.Add("Контактный телефон", typeof(long));
            table.Columns.Add("E-mail", typeof(string));

            for (int i = 0; i < efusst.Count; i++)
            {
                table.Rows.Add(efusst[i].cfcode, efusst[i].cname, efusst[i].cdol, efusst[i].cphone, efusst[i].cmail);
            }
            EfusList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(cfcodeBox.Text, nameBox.Text, dolBox.Text, phoBox.Text, mailBox.Text);
            EfusList.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = EfusList.CurrentCell.RowIndex;
            EfusList.Rows.RemoveAt(rowIndex);
        }
    }
}
