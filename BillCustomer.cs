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
    public partial class BillCustomer : Form
    {
        public BillCustomer()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public struct CustBill
        {
            public long custombill;
            public string billtype;
            public CustBill(long _custombill, string _billtype)
            {
                custombill = _custombill;
                billtype = _billtype;
            }
        }
        List<CustBill> cBill = new List<CustBill>();

        private void BillCustomer_Load(object sender, EventArgs e)
        {
            cBill.Add(new CustBill(2862345324234858, "Расчетный"));
            cBill.Add(new CustBill(7329452347244895, "Аккредитивный"));
            cBill.Add(new CustBill(4082832345213215, "Расчетный"));
            cBill.Add(new CustBill(8575002345234677, "Обычный"));
            cBill.Add(new CustBill(2860234521314672, "Обычный"));


            table.Columns.Add("Номер_счета_заказчика", typeof(long));
            table.Columns.Add("Тип_счета", typeof(string));

            for (int i = 0; i < cBill.Count; i++)
            {
                table.Rows.Add(cBill[i].custombill, cBill[i].billtype);
            }
            CustomList.DataSource = table;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            table.Rows.Add(billBox.Text, typeBox.Text);
            CustomList.DataSource = table;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int rowIndex = CustomList.CurrentCell.RowIndex;
            CustomList.Rows.RemoveAt(rowIndex);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory directory = new Directory();
            directory.Show();
        }

        
    }
}
