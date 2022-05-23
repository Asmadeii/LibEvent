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
    public partial class Servdocs : Form
    {
        public Servdocs()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct Sdoc
        {
            public int scode;
            public int stcode;
            public string sname;
            public string sdescr;
            public string scond;
            public int sprice;

            public Sdoc(int _scode, int _stcode, string _sname, string _sdescr, string _scond, int _sprice)
            {
                scode = _scode;
                stcode = _stcode;
                sname = _sname;
                sdescr = _sdescr;
                scond = _scond;
                sprice = _sprice;
            }
        }

        List<Sdoc> sdocs = new List<Sdoc>();

        private void Servdocs_Load(object sender, EventArgs e)
        {
            
            sdocs.Add(new Sdoc(1102, 45261, "Администрирование мероприятия", "Составление программы мероприятия и его проведение", 
                "Условия обговариваются с библиотекой", 5000));
            sdocs.Add(new Sdoc(1175, 15234, "Информационная поддержка", "Поддержка в проведении мероприятия, предоставление материалов",
                "Условия обговариваются с библиотекой", 2000));
            sdocs.Add(new Sdoc(1002, 32162, "Клининг", "Уборка помещения после мероприятия", "Условия обговариваются с библиотекой", 1500));
            sdocs.Add(new Sdoc(1007, 43561, "Коворкинг", "Предоставление помещения под коворкинг", "Условия обговариваются с библиотекой", 2000));
            sdocs.Add(new Sdoc(1078, 53183, "Мероприятие Под ключ", "Полное проведение мероприятия с подбором информации/персонала", 
                "Условия обговариваются с библиотекой", 10000));
            sdocs.Add(new Sdoc(1009, 16567, "Музыкальное оборудование", "Предоставление музыкального оборудования библиотеки заказчику", 
                "Условия обговариваются с библиотекой", 5000));
            sdocs.Add(new Sdoc(1054, 32361, "Световое оборудование", "Предоставление светового оборудования библиотеки заказчику", 
                "Условия обговариваются с библиотекой", 5000));
            sdocs.Add(new Sdoc(1177, 15265, "Техническая поддержка", "Поддержка в проведении мероприятия, помощь в обращении с оборудованием",
               "Условия обговариваются с библиотекой", 2000));

            
            table.Columns.Add("Код услуги", typeof(int));
            table.Columns.Add("Код вида услуги", typeof(int));
            table.Columns.Add("Наименование услуги", typeof(string));
            table.Columns.Add("Краткое описание", typeof(string));
            table.Columns.Add("Условия проведения", typeof(string));
            table.Columns.Add("Стоимость", typeof(int));

            for (int i = 0; i < sdocs.Count; i++)
            {
                table.Rows.Add(sdocs[i].scode, sdocs[i].stcode, sdocs[i].sname, sdocs[i].sdescr, sdocs[i].scond, sdocs[i].sprice);
            }
            ServList.DataSource = table;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = ServList.CurrentCell.RowIndex;
            ServList.Rows.RemoveAt(rowIndex);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(codBox.Text, codTBox.Text, nameBox.Text, descBox.Text, condBox.Text, priceBox.Text);
            ServList.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }
    }
}
