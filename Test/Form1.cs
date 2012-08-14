using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyFrameWork;  // change this by db name

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyFrameWork.Customer c1 = new Customer();
            //c1.Where.CustomerId.LessThanEqual(3);
            DataSet ds = c1.Select();
            gridTable.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear table
            Customer c1 = new Customer();
            c1.LastWhere = " where CustomerId < 100";
            c1.Delete();

            for (int i = 1; i <= 10; i++)
            {
                Customer c = new Customer();
                c.CustomerId = i;
                c.Name = "Name " + i;
                c.Addres = "Address " + i;
                c.Int = i * 10;
                c.BigInt = (i + 2) * 100;
                c.Insert();
            }
            MessageBox.Show("Done");
        }
    }
}
