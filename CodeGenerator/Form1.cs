using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gridTable.DataSource = DB.GetColumns("Customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.mConStr = mConnStr.Text.Trim();
            CodeGenerator gen = new CodeGenerator();
            gen.Execute();
            
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.mConStr = mConnStr.Text.Trim();
            gridTable.DataSource = DB.GetTables();

            
        }
    }
}
