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
    public partial class Partners : Form
    {
        public Partners()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct ePartn
        {
            public string enpart;
            public string efpart;

            public ePartn(string _enpart, string _efpart)
            {
               enpart = _enpart;
               efpart = _efpart;
            }
        }

        List<ePartn> epartn = new List<ePartn>();

        private void Partners_Load(object sender, EventArgs e)
        {
            epartn.Add(new ePartn("ГБОУ школа № 1222", "Участие в мероприятии"));
            epartn.Add(new ePartn("МРОД 'Студенты Столицы'", "Проведение и участие в мероприятии"));
            epartn.Add(new ePartn("Театр кукол 'Волшебный чемоданЧик'", "Проведение спектакля"));
            epartn.Add(new ePartn("Детская музыкальная школа № 35", "Участие в концерте"));
            epartn.Add(new ePartn("ГБОУ школа № 1524", "Участие в мероприятии"));
            epartn.Add(new ePartn("Инспектор пожарного надзора Южнопортового района", 
                "Проведение лекции, участие в мероприятии"));
            epartn.Add(new ePartn("Управа Южнопортового района", "Участие в организации и проведении мероприяти"));
            epartn.Add(new ePartn("Унтилова Елена", "Проведение Масленицы")); 
            epartn.Add(new ePartn("ГБОУ школа № 2129", "Участие в мероприятии"));
            epartn.Add(new ePartn("Государственный музей-заповедник М.Ю.Лермонтова", "Организация мероприятия"));
            epartn.Add(new ePartn("ДК 'Заречье'", "Участие в организации и проведении мероприяти"));
            epartn.Add(new ePartn("АНОО Лицей 'Ковчег-ХХI'", "Участие в мероприятии"));
            epartn.Add(new ePartn("Студенты Москвы", "Участие в мероприятии"));

            table.Columns.Add("Партнер (заказчик) мероприятия", typeof(string));
            table.Columns.Add("Содействие библиотеке", typeof(string));

            for (int i = 0; i < epartn.Count; i++)
            {
                table.Rows.Add(epartn[i].enpart, epartn[i].efpart);
            }
            PartnList.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autoLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
