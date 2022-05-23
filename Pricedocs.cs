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
    public partial class Pricedocs : Form
    {
        public Pricedocs()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct cCond
        {
            public int ccode;
            public string ctype;
            public string cdisc;
            public int cprice;
            public cCond(int _ccode, string _ctype, string _cdisc, int _cprice)
            {
                ccode = _ccode;
                ctype = _ctype;
                cdisc = _cdisc;
                cprice = _cprice;
            }
        }

        List<cCond> cList = new List<cCond>();

        private void Pricedocs_Load(object sender, EventArgs e)
        {
            CondList.AllowUserToAddRows = false;

            cList.Add(new cCond(1001, "Индивидуальный заказ", "Проведение мероприятия любого формата (выпускной, день рождения и т.п.)",500));
            cList.Add(new cCond(1002, "Серия мастер-классов", "Проведение обучающих занятий в течение некоторого времени",1000));
            cList.Add(new cCond(1003, "Мастер-класс (разовый)", "Проведение обучающего занятия один раз",2500));

            table.Columns.Add("Код", typeof(int));
            table.Columns.Add("Наименование", typeof(string));
            table.Columns.Add("Краткое описание", typeof(string));
            table.Columns.Add("Руб/час", typeof(int));

            for (int i = 0; i < cList.Count; i++)
            {
                table.Rows.Add(cList[i].ccode, cList[i].ctype, cList[i].cdisc, cList[i].cprice);
            }
            CondList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pricelist pricelist = new Pricelist();
            pricelist.Show();
        }
    }
}
