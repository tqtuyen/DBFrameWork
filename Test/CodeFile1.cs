using System;
using System.Data.SqlClient;

namespace Test
{
    public class TbBaseClass
    {
        public String Where { get; set; }

    }
    public class BaseField
    {
        public readonly TbBaseClass Parent = null;
        public String Name { get; protected set; }
        public BaseField(TbBaseClass parent)
        {
            this.Parent = parent;
        }
        public String Equal(Object value)
        {

            this.Parent.Where = "";
            return "";
        }
    }

    public class Field1 : BaseField
    {
        public Field1() : base(null)
        {
            Name = "Field1";
        }

    }

    public class A
    {
        public string Field1;
        private string Field2;
        public string Pro1
        {
            get;
            set;
        }
    }

    public class B
    {
        private A instance;

        public B(A a)
        {
            this.instance = a;
        }

        public void f1()
        {
            this.instance.Pro1 = "";
        }
    }
}