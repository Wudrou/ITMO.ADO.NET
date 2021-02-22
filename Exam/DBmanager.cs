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
        }

        private void show_Click(object sender, EventArgs e)
        {
            using (MyDBEntities ctx = new MyDBEntities())
            {
                foreach (Customers cust in ctx.Customers)
                    listBox1.Items.Add(cust.PersonID + "  |  " + cust.FirstName + "  |  " + cust.LastName);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}


