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
    public partial class Equipdocs : Form
    {
        public Equipdocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct eDoc
        {
            public int ecode;
            public int etcode;
            public string ename;
            public string edescr;
            public string econd;
            public int eprice;

            public eDoc(int _ecode, int _etcode, string _ename, string _edescr, string _econd, int _eprice)
            {
                ecode = _ecode;
                etcode = _etcode;
                ename = _ename;
                edescr = _edescr;
                econd = _econd;
                eprice = _eprice;
            }
        }
        
        List<eDoc> edocs = new List<eDoc>();

        private void Equipdocs_Load(object sender, EventArgs e)
        {
            edocs.Add(new eDoc(4212, 261, "Компьютер", "Предоставление ПК", "Условия обговариваются с библиотекой", 500));
            edocs.Add(new eDoc(4021, 524, "Флипчарт", "Переносной флипчарт", "Условия обговариваются с библиотекой", 300));
            edocs.Add(new eDoc(4821, 162, "Маркерная доска", "Переносная маркерная доска", "Условия обговариваются с библиотекой", 250));
            edocs.Add(new eDoc(4683, 431, "Столы", "Свободные стулья", "Условия обговариваются с библиотекой", 0));
            edocs.Add(new eDoc(4078, 583, "Стулья", "Свободные столы", "Условия обговариваются с библиотекой", 0));
            edocs.Add(new eDoc(4509, 567, "Проектор", "Предоставление проектора", "Условия обговариваются с библиотекой", 500));
            edocs.Add(new eDoc(4954, 321, "Принтер", "Предоставление принтера", "Условия обговариваются с библиотекой", 500));
            edocs.Add(new eDoc(4177, 165, "Чайник (термопот)", "Предоставление кипятка", "Условия обговариваются с библиотекой", 0));


            table.Columns.Add("Код оборудования", typeof(int));
            table.Columns.Add("Код вида оборудования", typeof(int));
            table.Columns.Add("Наименование оборудования", typeof(string));
            table.Columns.Add("Краткое описание", typeof(string));
            table.Columns.Add("Условия аренды", typeof(string));
            table.Columns.Add("Стоимость", typeof(int));

            for (int i = 0; i < edocs.Count; i++)
            {
                table.Rows.Add(edocs[i].ecode, edocs[i].etcode, edocs[i].ename, edocs[i].edescr, edocs[i].econd, edocs[i].eprice);
            }
            EquipList.DataSource = table;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(codBox.Text, codTBox.Text, nameBox.Text, descBox.Text, condBox.Text, priceBox.Text);
            EquipList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = EquipList.CurrentCell.RowIndex;
            EquipList.Rows.RemoveAt(rowIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipment equipment= new Equipment();
            equipment.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
