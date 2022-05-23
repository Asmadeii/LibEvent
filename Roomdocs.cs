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
    public partial class Roomdocs : Form
    {
        public Roomdocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct rDoc
        {
            public int rcode;
            public int rtcode;
            public string rname;
            public string rdescr;
            public string rsqua;
            public string rspac;

            public rDoc(int _rcode, int _rtcode, string _rname, string _rdescr, string _rsqua, string _rspac)
            {
                rcode = _rcode;
                rtcode = _rtcode;
                rname = _rname;
                rdescr = _rdescr;
                rsqua = _rsqua;
                rspac = _rspac;
            }
        }

        List<rDoc> rdocs = new List<rDoc>();

        private void Roomdocs_Load(object sender, EventArgs e)
        {
            rdocs.Add(new rDoc(11, 653, "Зал для занятий", "Помещение для проведения занятий", "33,7 кв.м", "10-15 человек"));
            rdocs.Add(new rDoc(11, 234, "Зал для физкультурно-оздоровительных мероприятий", "Помещение для занятий спортом", "44 кв.м", 
                "15-20 человек"));
            rdocs.Add(new rDoc(11, 934, "Зал для мастер-классов и занятий", "Помещение для занятий", "64,7 кв.м", "15-20 человек"));
            
            table.Columns.Add("Код помещения", typeof(int));
            table.Columns.Add("Код вида помещения", typeof(int));
            table.Columns.Add("Наименование помещения", typeof(string));
            table.Columns.Add("Краткое описание", typeof(string));
            table.Columns.Add("Площадь", typeof(string));
            table.Columns.Add("Вместительность", typeof(string));

            for (int i = 0; i < rdocs.Count; i++)
            {
                table.Rows.Add(rdocs[i].rcode, rdocs[i].rtcode, rdocs[i].rname, rdocs[i].rdescr, rdocs[i].rsqua, rdocs[i].rspac);
            }
            RoomList.DataSource = table;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(codBox.Text, codTBox.Text, nameBox.Text, descBox.Text, sqBox.Text, spacBox.Text);
            RoomList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = RoomList.CurrentCell.RowIndex;
            RoomList.Rows.RemoveAt(rowIndex);
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

        
    }
}
