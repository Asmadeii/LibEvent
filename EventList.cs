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
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct eEvent
        {
            public string emon;
            public string ename;
            public string eprog;
            public string einf;

            public eEvent(string _emon, string _ename, string _eprog, string _einf)
            {
                emon = _emon;
                ename = _ename;
                eprog = _eprog;
                einf = _einf;
            }
        }

        List<eEvent> eevent = new List<eEvent>();

        private void EventList_Load(object sender, EventArgs e)
        {
            eevent.Add(new eEvent("Февраль", "Чуньцзе, или китайский Новый год", "Студенты в библиотеке", "Волонтеры: привлечение и работа с ними"));
            eevent.Add(new eEvent("Февраль", "Студенческий Stand-up", "Студенты в библиотеке", "Волонтеры: привлечение и работа с ними"));
            eevent.Add(new eEvent("Февраль", "Волшебная школа Карандаша и Самоделкина", "В рамках проектной деятельности", "Проектная деятельность"));
            eevent.Add(new eEvent("Февраль", "Композитор-детям", "225 - лет со дня рождения Ф. Шуберта", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Февраль", "О подвигах, о доблести, о славе", "День защитника Отечества", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Февраль", "Пожар не шутка!", "Безопасность детства", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Февраль", "Становись, честной народ, в дружный наш хоровод...", "Масленица/ Москва праздничная", 
                "Работа с партнерами/ Творческие люди"));

            eevent.Add(new eEvent("Март", "Москва глазами детей", "Краеведение", "Волонтеры: привлечение и работа с ними"));
            eevent.Add(new eEvent("Март", "Мы выбираем жизнь!", "Работа с партнерами/ Безопасность детства/Антинаркотическое", "Лекториум"));
            eevent.Add(new eEvent("Март", "Стань шефом презентаций", "Проектная деятельность 'Учебный день в библиотеке'", "Проектная деятельность"));
            eevent.Add(new eEvent("Март", "Прогулки по Чукоккале", "140-лет со дня рождения К.И.Чуковского/ " +
                "Работа с партнерами/ Московская неделя детской книги", "Волонтеры: привлечение и работа с ними"));
            eevent.Add(new eEvent("Март", "Вечер музыки и поэзии", "Всемирный день поэзии", "Работа с партнерами/ Творческие люди"));


            eevent.Add(new eEvent("Апрель", "Тотальный диктант- 2022", "В рамках международной акции 'Тотальный диктант'",
                "Волонтеры: привлечение и работа с ними"));
            eevent.Add(new eEvent("Апрель", "Культура победит тоску и грусть!", "Международный день культуры", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Апрель", "Благодатный огонь в сердце каждого", "Благовещение/ Пасха", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Апрель", "Зажги свою звезду", "День космонавтики", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Апрель", "В память о прошлом и во имя будущего", "750- летие победы Александра Невского на Чудском озере", 
                "Работа с партнерами/ Творческие люди"));

            eevent.Add(new eEvent("Май", "Вечер настольных игр", "Студенты в библиотеке/ Партнеры: привлечение и работа с ними",
                "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Май", "Весенняя карусель", "Праздник Весны и Труда", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Май", "Чтобы помнили, какой ценой завоеван мир!", "В рамках празднования 77-й годовщины " +
                "Победы в Великой Отечественной войне", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Май", "Сказание о письменах славянских", "День славянской письменности и культуры/ Работа с партнерами",
                "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Май", "Культурные традиции", "Общегородская Акция'Библионочь'", "Работа с партнерами/ Творческие люди"));
            eevent.Add(new eEvent("Май", "Спасём жизнь вместе!", "Антинаркотическое/ Безопасность детства", "Лекториум"));
            eevent.Add(new eEvent("Май", "Ярмарка проектов", "Проектная деятельность 'Учебный день в библиотеке'", "Проектная деятельность"));
            eevent.Add(new eEvent("Май", "Встечаемся в библиотеке!", "День открытых дверей", "Работа с партнерами/ Творческие люди"));

            table.Columns.Add("Месяц проведения", typeof(string));
            table.Columns.Add("Наименование мероприятия", typeof(string));
            table.Columns.Add("Программа/приуроченная дата", typeof(string));
            table.Columns.Add("В рамках какого проекта", typeof(string));

            for (int i = 0; i < eevent.Count; i++)
            {
                table.Rows.Add(eevent[i].emon, eevent[i].ename, eevent[i].eprog, eevent[i].einf);
            }
            eEventList.DataSource = table;
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
