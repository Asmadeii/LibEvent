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
    public partial class ContractCond : Form
    {
        public ContractCond()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        public struct cCond
        {
            public int ccode;
            public string ctype;
            public cCond(int _ccode, string _ctype)
            {
                ccode = _ccode;
                ctype = _ctype;
            }
        }

        List<cCond> cList = new List<cCond>();

        private void ContractCond_Load(object sender, EventArgs e)
        {
            cList.Add(new cCond(301, "Действует"));
            cList.Add(new cCond(302, "Завершен"));

            table.Columns.Add("Код_состояния_договора", typeof(int));
            table.Columns.Add("Вид_состояния", typeof(string));

            for (int i = 0; i < cList.Count; i++)
            {
                table.Rows.Add(cList[i].ccode, cList[i].ctype);
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
            Directory directory = new Directory();
            directory.Show();
        }

        
    }
}
