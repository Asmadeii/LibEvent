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
    public partial class BillExecutor : Form
    {
        public BillExecutor()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct ExecBill
        {
            public long execbill;
            public string billtype;
            public ExecBill(long _execbill, string _billtype)
            {
                execbill = _execbill;
                billtype = _billtype;                
            }
        }

        List<ExecBill> eBill = new List<ExecBill>();

        private void BillExecutor_Load(object sender, EventArgs e)
        {

            eBill.Add(new ExecBill(87231123411343993, "Обычный"));
            eBill.Add(new ExecBill(65174123411162280, "Аккредитивный"));
            eBill.Add(new ExecBill(48899122344933761, "Расчетный"));


            table.Columns.Add("Номер_счета_исполнителя", typeof(long));
            table.Columns.Add("Тип_счета", typeof(string));

            for (int i = 0; i < eBill.Count; i++)
            {
                table.Rows.Add(eBill[i].execbill, eBill[i].billtype);
            }
            BillList.DataSource = table;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(billBox.Text, typeBox.Text);
            BillList.DataSource = table;
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = BillList.CurrentCell.RowIndex;
            BillList.Rows.RemoveAt(rowIndex);
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
