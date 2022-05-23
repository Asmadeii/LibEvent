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
    public partial class Contractdocs : Form
    {
        public Contractdocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct cDoc
        {
            public int cnum;
            public string cname;
            public int crcode;
            public string csdate;
            public string cfdate;
            public string cstime;
            public string cftime;
            public int cecode;
            public int cprice;
            public long ccbill;
            public long ccinn;
            public long cebill;
            public long ceinn;
            public long csost;

        public cDoc (int _cnum, string _cname, int _crcode, string _csdate, string _cfdate, string _cstime, string _cftime, int _cecode,
            int _cprice, long _ccbill, long _ccinn, long _cebill, long _ceinn, int _csost )
            {
                cnum = _cnum;
                cname = _cname;
                crcode = _crcode;
                csdate = _csdate;
                cfdate = _cfdate;
                cstime = _cstime;
                cftime = _cftime;
                cecode = _cecode;
                cprice = _cprice;
                ccbill = _ccbill;
                ccinn = _ccinn;
                cebill = _cebill;
                ceinn = _ceinn;
                csost = _csost;
            }         
        }

        List<cDoc> cddoc = new List<cDoc>();

        private void Contractdocs_Load(object sender, EventArgs e)
        {
           cddoc.Add(new cDoc(128, "Мастер-класс по лепке из глины", 11, "11 мая", "11 мая", "16:00", "17:00", 4683, 2500, 2862345324234858,
               237917442079, 87231123411343993, 7721062542, 302));

            table.Columns.Add("Номер договора", typeof(int));
            table.Columns.Add("Наименование мероприятия", typeof(string));
            table.Columns.Add("Код помещения", typeof(int));
            table.Columns.Add("Дата мероприятия", typeof(string));
            table.Columns.Add("Дата окончания мероприятия", typeof(string));
            table.Columns.Add("Время начала мероприятия", typeof(string));
            table.Columns.Add("Время окончания мероприятия", typeof(string));
            table.Columns.Add("Код оборудования", typeof(int));
            table.Columns.Add("Стоимость аренды", typeof(int));
            table.Columns.Add("Номер счета заказчика", typeof(long));
            table.Columns.Add("ИНН заказчика", typeof(long));
            table.Columns.Add("Номер счета исполнителя", typeof(long));
            table.Columns.Add("ИНН исполнителя", typeof(long));
            table.Columns.Add("Состояние договора", typeof(int));

            for (int i = 0; i < cddoc.Count; i++)
            {
                table.Rows.Add(cddoc[i].cnum, cddoc[i].cname, cddoc[i].crcode, cddoc[i].csdate, cddoc[i].cfdate, cddoc[i].cstime, cddoc[i].cftime,
                   cddoc[i].cecode, cddoc[i].cprice, cddoc[i].ccbill, cddoc[i].ccinn, cddoc[i].cebill, cddoc[i].ceinn, cddoc[i].csost );
            }
            DogList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(numBox.Text, nameBox.Text, codRBox.Text, datSBox.Text, datFBox.Text, timeSBox.Text, timeFBox.Text,
                equBox.Text, priceBox.Text, billCBox.Text, innCBox.Text, billEBox.Text, innEbox.Text, condBox.Text);
            DogList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = DogList.CurrentCell.RowIndex;
            DogList.Rows.RemoveAt(rowIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contracts contracts = new Contracts();
            contracts.Show();
        }

        Point lastPoint;
        private void Contractdocs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Contractdocs_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
