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
            listView1.Items.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (radioButtonCustomer.Checked == true)
            {
                if (textBox_ID.Text == "" || textBox_FirstName.Text == "" || textBox_LastName.Text == "")
                {
                    MessageBox.Show("Необходимо ввести ID, имя и фамилию клиента");
                }
                else
                {
                    try
                    {
                        using (MyDBEntities ctx = new MyDBEntities())
                        {
                             var customer = new Customers()
                                { PersonID = Convert.ToInt32(textBox_ID.Text), FirstName = textBox_FirstName.Text, LastName = textBox_LastName.Text };
                             ctx.Customers.Add(customer);
                             ctx.SaveChanges();
                        }
                        MessageBox.Show("Клиент добавлен.");
                        textBox_ID.Clear();
                        textBox_FirstName.Clear();
                        textBox_LastName.Clear();
                        textBox_Order.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Клиент с таким ID уже существует");
                    }
                }
            }
            else
            {
                if (radioButtonOrder.Checked == true)
                {
                    if (textBox_Order.Text == "" || textBox_ID.Text == "")
                    {
                        MessageBox.Show("Необходимо ввести ID клиента и номер заказа");
                    }
                    else
                    {
                        try
                        {
                            using (MyDBEntities ctx = new MyDBEntities())
                            {
                                var order = new Orders()
                                    { OrderID = Convert.ToInt32(textBox_Order.Text), CustomerID = Convert.ToInt32(textBox_ID.Text) };
                                ctx.Orders.Add(order);
                                ctx.SaveChanges();
                            }
                            MessageBox.Show("Заказ добавлен.");
                            textBox_ID.Clear();
                            textBox_FirstName.Clear();
                            textBox_LastName.Clear();
                            textBox_Order.Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Номер заказа уже существует, либо отсутствует клиент с указанным ID");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать таблицу для добавления данных");
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            using (MyDBEntities ctx = new MyDBEntities())
            {
                ctx.SaveChanges();
            }
        }
    }
}


