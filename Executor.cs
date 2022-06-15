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
    public partial class Executor : Form
    {
        public Executor()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public struct Execc
        {
            public long einn;
            public string ename;
            public string eadr;
            public string enal;
            public long ephone;
            public string esite;
            public string email;
            public int efcode;

            public Execc (long _einn, string _ename, string _eadr, string _enal, long _ephone, string _esite, string _email, int _efcode)
            {
                einn = _einn;
                ename = _ename;
                eadr = _eadr;
                enal = _enal;
                ephone = _ephone;
                esite = _esite;
                email = _email;
                efcode = _efcode;   
            }
        }

        List<Execc> execc = new();
        private void Executor_Load(object sender, EventArgs e)
        {
            ExeList.AllowUserToAddRows = false;
            execc.Add(new Execc(7721062542, "ГБУК г. Москвы ОКЦ ЮВАО", "г.Москва, Зарайская ул., д.56а", "ОСН", 84991708410, "https://okcuvao.ru/",
                "info@okcuvao.ru", 3852));

            table.Columns.Add("ИНН", typeof(long));
            table.Columns.Add("Наименование исполнителя", typeof(string));
            table.Columns.Add("Юридический адрес", typeof(string));
            table.Columns.Add("Система налогового учета ", typeof(string));
            table.Columns.Add("Контактный телефон", typeof(long));
            table.Columns.Add("Официальный сайт", typeof(string));
            table.Columns.Add("E-mail", typeof(string));
            table.Columns.Add("Код_отв_лица_зак", typeof(int));

            for (int i = 0; i < execc.Count; i++)
            {
                table.Rows.Add(execc[i].einn, execc[i].ename, execc[i].eadr, execc[i].enal, execc[i].ephone,
                    execc[i].esite, execc[i].email, execc[i].efcode);
            }
            ExeList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }
    }
}
