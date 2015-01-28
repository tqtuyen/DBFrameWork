using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBGenerator;

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
            Customer c1 = new Customer();
            //c1.Where.CustomerId.LessThanEqual(3);
            DataSet ds = c1.Select();
            gridTable.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear table
            Customer c1 = new Customer();
			/*
			c1.Where.ID.Equal(1);
            c1.LastWhere = " where ID < 100";
            c1.Delete();
			*/
			c1.Update.Where.ID.Equal(12).Or.ID.Equal(13).And.Name.Like("abc");

            for (int i = 1; i <= 10; i++)
            {
                Customer c = new Customer();
                c.ID = i;
                c.Name = "Name " + i;
                /*
				c.Address = "Address " + i;
                c.Int = i * 10;
                c.BigInt = (i + 2) * 100;
				*/
                c.Insert();
            }
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer cu = new Customer();
            cu.Name = "update name";
			
            cu.Where.ID.Equal(1);
            cu.UpdateEx();
        }
    }
}
