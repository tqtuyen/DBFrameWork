using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Personal;

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
            Person a = new Person();
            DataSet ds = a.Select();
            gridTable.DataSource = ds.Tables[0];

            a.FirstName = "";
            a.LastWhere = "";
            a.Insert();


            a.Select();
            a.Where.FirstName.Equal("fkfk");
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person a = new Person();

            a.Where.PersonID.Equal(2);
            a.Delete();
            
        }
        //public T test<String>(T a)
        //{
        //    return a;

        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            //Person a = new Person();
            //a.Where.PersonID.Equal("van");
            //a.Select();

            //a.FirstName = "vna";
            //a.LastName = "nguyen";
            //a.Where.PersonID.Equal(0);

            ////select 1
            //Customer a = new Customer();
            //a.select(); //return dataset of all fields
            //a.select(a.id, a.firstName, a.lastName); // return dataset of customer with id, firstname, lastname
            //a.select().where.id.equal(40); //return dataset of customer with all fields and id = 40
            //a.select().where.id.equal(40).or.firstName.like("van"); //return dataset of Customer with id = 40 or firstname like van

            ////select 2
            //a.select();
            //a.where.id.equal(50);
            //a.and.firstname.like("vna");
            //a.execute();

            //a.selectAll();
            //a.select().where.id.equal(50);
            //a.select().where.id.equal(50);

            //a.update.where.id.equal(40);
            //a.update.where.id.equal(40).or.firstName.equal("tung");
            //a.delete.where.id.equal(50);

            //a.join.b(a.id, b.AID);
            //a.join.c(b.id, c.id);
            //a.select().where.a.id.equal(10);

            //t.selectAll().DataSet();
            //t.SelectAll(firstname, lastnamek);

            //t.Select(Test.ID.Equal("van"), Or.Test.Firstname.equal("van"), And.Test.lastname.equal("nguhen"));

            //String a = t.Where.ID.Equal<String>("van", Or.test.firstname);
            //t.Select(firstname, lastname).where.id.equal("van");
            //t.Select(firstname, lastname).where.id.equal("van").Or.FirstName.equal("tng");
            

            //t.fistName;
            //t.lastname;
            //t.update().where.firstname.equal("id");

            //t.delete().where.id(0);


            //t.Where.ID.Equal(0).Or.ID.Equal(0).Select();
            //t.Where.ID.Equal(0).Or.ID.Equal(0).Update();
            //t.Where.ID.Equal(0).Delete();

            //t.join.b(a.id, b.id).select()
            //t.join.b(a.id, b.id).or.(a.id, "").select()
            //t.join.c(b.id, c.id).select()

            

        }
        

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
