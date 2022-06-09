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
    public partial class InfoPovod : Form
    {
        public InfoPovod()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct eInfo
        {
            public string emon;
            public string einfo;
            public int esum;

            public eInfo(string _emon, string _einfo, int _esum)
            {
                emon = _emon;
                einfo = _einfo;
                esum = _esum;
            }
        }

        List<eInfo> einfo = new List<eInfo>();
        private void InfoPovod_Load(object sender, EventArgs e)
        {
            einfo.Add(new eInfo("Февраль", "Волонтеры: привлечение и работа с ними", 2));
            einfo.Add(new eInfo("Февраль", "Лекториум", 0));
            einfo.Add(new eInfo("Февраль", "Проектная деятельность", 3));
            einfo.Add(new eInfo("Февраль", "Работа с партнерами/ Творческие люди", 4));

            einfo.Add(new eInfo("Март", "Волонтеры: привлечение и работа с ними", 2));
            einfo.Add(new eInfo("Март", "Лекториум", 2));
            einfo.Add(new eInfo("Март", "Проектная деятельность", 3));
            einfo.Add(new eInfo("Март", "Работа с партнерами/ Творческие люди", 5));


            einfo.Add(new eInfo("Апрель", "Волонтеры: привлечение и работа с ними", 3));
            einfo.Add(new eInfo("Апрель", "Проектная деятельность", 4));
            einfo.Add(new eInfo("Апрель", "Работа с партнерами/ Творческие люди", 4));

            einfo.Add(new eInfo("Май", "Волонтеры: привлечение и работа с ними", 3));
            einfo.Add(new eInfo("Май", "Лекториум", 1));
            einfo.Add(new eInfo("Май", "Проектная деятельность", 7));
            einfo.Add(new eInfo("Май", "Работа с партнерами/ Творческие люди", 8));

            table.Columns.Add("Месяц проведения", typeof(string));
            table.Columns.Add("В рамках какого проекта", typeof(string));
            table.Columns.Add("Количество проведенных мероприятий", typeof(int));

            for (int i = 0; i < einfo.Count; i++)
            {
                table.Rows.Add(einfo[i].emon, einfo[i].einfo, einfo[i].esum);
            }
            InfoList.DataSource = table;
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
