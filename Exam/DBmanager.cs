using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class DBmanager : Form
    {
        public DBmanager()
        {
            InitializeComponent();
            Clear();
        }

        private void show_Click(object sender, EventArgs e)
        {
            using (MyDBEntities ctx = new MyDBEntities())
            {
                Clear();
                if (radioButtonCustomer.Checked == true)
                {
                    listView1.Columns[0].Width = 100;
                    listView1.Columns[1].Width = 100;
                    listView1.Columns[2].Width = 100;
                    foreach (Customers cust in ctx.Customers)
                    {
                        ListViewItem lvi = new ListViewItem(Convert.ToString(cust.PersonID));
                        lvi.SubItems.Add(cust.FirstName);
                        lvi.SubItems.Add(cust.LastName);
                        listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    if (radioButtonOrder.Checked == true)
                    {
                        listView1.Columns[0].Width = 100;
                        listView1.Columns[3].Width = 100;
                        foreach (Orders ord in ctx.Orders)
                        {
                            ListViewItem lvi = new ListViewItem(Convert.ToString(ord.CustomerID));
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add("");
                            lvi.SubItems.Add(Convert.ToString(ord.OrderID));
                            listView1.Items.Add(lvi);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Необходимо выбрать источник данных");
                    }
                }
            }
        }
        private void Clear()
        {
            listView1.Columns[0].Width = 0;
            listView1.Columns[1].Width = 0;
            listView1.Columns[2].Width = 0;
            listView1.Columns[3].Width = 0;
            listBox1.Items.Clear();
            listView1.Items.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}


